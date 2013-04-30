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
    public partial class Form2 : Form
    {
        private BoggleClientModel model;
        private Form1 form1;
        public Form2(BoggleClientModel _model, Form1 form)
        {
            InitializeComponent();
            model = _model;
            form1 = form;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(playerNameTextBox.Text) && !String.IsNullOrEmpty(hostNameTextBox.Text))
            {
                model.Connect(hostNameTextBox.Text, playerNameTextBox.Text);
                form1.setToEnabled();
                this.Close();
            }
            
        }
    }
}
