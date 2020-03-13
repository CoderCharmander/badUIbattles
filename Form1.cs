using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpecialInput
{
    public partial class Form1 : Form
    {
        public Form1 ()
        {
            InitializeComponent ();
        }

        private void button2_Click (object sender, EventArgs e)
        {
            string[] alphabet = Enumerable.Range ('A', 'Z' - 'A').Select (i => ((char)i).ToString()).ToArray();
            alphabet = Utilities.Shuffle (alphabet);
            using (Choose c = new Choose(alphabet))
            {
                if (c.ShowDialog() == DialogResult.OK && c.ChosenItem != null)
                {
                    textBox2.Text += c.ChosenItem;
                }
            }
        }

        private void button3_Click (object sender, EventArgs e)
        {
            if (textBox2.TextLength > 0)
            textBox2.Text = textBox2.Text.Substring (0, textBox2.TextLength - 1);
        }
    }
}
