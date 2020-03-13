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
    public partial class Choose : Form
    {
        public string ChosenItem { get; private set; }

        public Choose (string[] items)
        {
            InitializeComponent ();
            checkedListBox1.Items.AddRange(items);
        }

        private void button2_Click (object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close ();
        }

        private void button1_Click (object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            DetermineChosenItem ();
            Close ();
        }

        private void DetermineChosenItem ()
        {
            IEnumerable<string> output = checkedListBox1.Items.OfType<string> ().Except (checkedListBox1.CheckedItems.Cast<string>());
            if (output.Count () > 1) ChosenItem = null;
            else ChosenItem = output.FirstOrDefault ();
        }
    }
}
