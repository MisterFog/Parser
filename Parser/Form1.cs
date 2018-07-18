using Parser.Core;
using Parser.Core.Habra;
using System;
using System.Windows.Forms;

namespace Parser
{
    public partial class FormParser : Form
    {
        ParserWorker<string[]> parser;
        public FormParser()
        {
            InitializeComponent();
            parser = new ParserWorker<string[]>(new HabraParser());

            parser.OnCompleted += Parser_OnCompleted;
            parser.OnNewData += Parser_OnNewData;
        }

        private void Parser_OnNewData(object arg1, string[] arg2)
        {
            ListTitles.Items.AddRange(arg2);
        }

        private void Parser_OnCompleted(object obj)
        {
            MessageBox.Show("All works done!");
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            parser.Setings = new HabraSetings((int)numericStart.Value, (int)numericEnd.Value);
            parser.Start();
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            parser.Abort();
        }
    }
}
