using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tidenotes
{
    public partial class tidenotes : Form
    {
        public tidenotes()
        {
            InitializeComponent();
        }
        public int howmanynotes = 0;
        private void addnote_Click(object sender, EventArgs e)
        {
            if (howmanynotes >= 10)
            {
                MessageBox.Show("Ты зачем стол засираешь? Больше десяти нельзя", "ебаная ошибка");
            }
            else
            {
                Form addnote;
                addnote = new note();
                addnote.Show();
                howmanynotes++;
            }
        }
    }
}
