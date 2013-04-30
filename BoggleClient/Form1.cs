using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BoggleModel;

namespace BoggleClient
{
    public partial class Form1 : Form
    {
        private BoggleClientModel model;

        public Form1()
        {
            InitializeComponent();
            model = new BoggleClientModel();
            model.IncomingLineEvent += MessageReceived;
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            model.submitWord(wordTextBox.Text);
        }
        public void setToEnabled()
        {
            wordTextBox.Enabled = true;
            SubmitButton.Enabled = true;
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 setup = new Form2(model, this);
            setup.Show();
        }

        private void MessageReceived(String command)
        {
            if (!String.IsNullOrEmpty(command))
            {
                switch (command.Split(' ')[0].ToUpper().Trim())
                {
                    case "START":
                        updateBoard(model.board);
                        PlayersName.Invoke(new Action(() => { PlayersName.Text = model.playerName; }));
                        OpponentsName.Invoke(new Action(() => { OpponentsName.Text = model.opponentName; }));
                        TimeValue.Invoke(new Action(() => { TimeValue.Text = model.time.ToString(); }));

                        break;
                    case "SCORE":

                        break;
                    case "TIME":
                        TimeValue.Invoke(new Action(() => { TimeValue.Text = model.time.ToString(); }));
                        break;
                    case "TERMINATED":

                        break;
                    case "STOP":

                        break;
                    case "IGNORING":
                        break;
                }
            }

        }

        private void updateBoard(String s)
        {
            one_one.Invoke(new Action(() => { one_one.Text = model.board[0].ToString(); }));
            one_two.Invoke(new Action(() => { one_two.Text = model.board[1].ToString(); }));
            one_three.Invoke(new Action(() => { one_three.Text = model.board[2].ToString(); }));
            one_four.Invoke(new Action(() => { one_four.Text = model.board[3].ToString(); }));

            two_one.Invoke(new Action(() => { two_one.Text = model.board[4].ToString(); }));
            two_two.Invoke(new Action(() => { two_two.Text = model.board[5].ToString(); }));
            two_three.Invoke(new Action(() => { two_three.Text = model.board[6].ToString(); }));
            two_four.Invoke(new Action(() => { two_four.Text = model.board[7].ToString(); }));

            three_one.Invoke(new Action(() => { three_one.Text = model.board[8].ToString(); }));
            three_two.Invoke(new Action(() => { three_two.Text = model.board[9].ToString(); }));
            three_three.Invoke(new Action(() => { three_three.Text = model.board[10].ToString(); }));
            three_four.Invoke(new Action(() => { three_four.Text = model.board[11].ToString(); }));

            four_one.Invoke(new Action(() => { four_one.Text = model.board[12].ToString(); }));
            four_two.Invoke(new Action(() => { four_two.Text = model.board[13].ToString(); }));
            four_three.Invoke(new Action(() => { four_three.Text = model.board[14].ToString(); }));
            four_four.Invoke(new Action(() => { four_four.Text = model.board[15].ToString(); }));
        }

    }
}
