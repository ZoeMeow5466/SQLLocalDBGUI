using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Zoe13010.SQLLocalDB.GUI
{
    public partial class CreateInstance : Form
    {
        public CreateInstance()
        {
            InitializeComponent();
        }

        public string TextBoxData
        {
            get { return textBox1.Text; }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.TextLength == 0)
            {
                label2.Visible = true;
                button2.Enabled = false;
            }
            else
            {
                label2.Visible = false;
                button2.Enabled = true;
            }
        }

        private void Event_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                button2_Click(button2, new EventArgs());
            else if (e.KeyCode == Keys.Escape)
                button3_Click(button3, new EventArgs());
        }
    }
}
