using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CustomNetworking;
using System.Net.Sockets;
using BB;

namespace BoggleModel
{
    public class BoggleClientModel
    {
        private StringSocket socket;
        public event Action<string> IncomingLineEvent;

        public int playerScore { get; private set; }
        public int opponentScore { get; private set; }
        public int time { get; private set; }
        public string board { get; private set; }

        public string playerName { get; private set; }
        public string opponentName { get; private set; }

        public string finalStats;


        /// <summary>
        /// Creates a not yet connected client model.
        /// </summary>
        public BoggleClientModel()
        {
            socket = null;
        }

        /// <summary>
        /// Connect to the server at the given hostname and port and with the give name.
        /// </summary>
        public void Connect(string hostname, String name)
        {
            if (socket == null)
            {
                playerName = name;
                TcpClient client = new TcpClient(hostname, 2000);
                socket = new StringSocket(client.Client, UTF8Encoding.Default);
                socket.BeginSend("PLAY " + name + "\n", (e, p) => { }, null);
                socket.BeginReceive(LineReceived, null);
            }
        }
        /// <summary>
        /// Deal with an arriving line of text.
        /// </summary>
        private void LineReceived(String s, Exception e, object p)
        {
            if (!String.IsNullOrEmpty(s))
            {
                switch (s.Split(' ')[0].ToUpper().Trim())
                {
                    case "START":
                        getStart(s);
                        break;
                    case "SCORE":
                        getScore(s);
                        break;
                    case "TIME":
                        getTime(s);
                        break;
                    case "TERMINATED":
                        getTerminated(s);
                        break;
                    case "STOP":
                        getStop(s);
                        break;
                    case "IGNORING":
                        break;
                }
            }
            if (IncomingLineEvent != null)
            {
                IncomingLineEvent(s);
            }
            socket.BeginReceive(LineReceived, null);
        }
        /// <summary>
        /// Submits a word to the server.
        /// </summary>
        public void submitWord(String word)
        {
            if (socket != null)
            {
                socket.BeginSend("WORD " + word + "\n",(x,p) => {}, null);
            }
        }
        private void getStart(string command)
        {
            int _time;
            board = command.Split(' ')[1];
            Int32.TryParse(command.Split(' ')[2], out _time);
            opponentName = command.Split(' ')[3];

            time = _time;
        }
        private void getScore(string command)
        {
            int _playerScore;
            int _opponentScore;

            Int32.TryParse(command.Split(' ')[1], out _playerScore);
            Int32.TryParse(command.Split(' ')[2], out _opponentScore);
            opponentScore = _opponentScore;
            playerScore = _playerScore;

        }
        private void getTime(string command)
        {
            int _time;
            Int32.TryParse(command.Split(' ')[1], out _time);
            time = _time;
        }
        private void getTerminated(string command)
        {

        }
        private void getStop(string command)
        {
            finalStats = command.Substring(command.IndexOf(" ") + 1);
        }

    }
}
