using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using prGraphiques;

namespace prGlobal
{
    public partial class formMenu : formBase
    {
        public formMenu()
        {
            InitializeComponent();
        }

        private void btnNewform1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cette fonction est en cours de développement!", "En développement", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void btnNewform2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cette fonction est en cours de développement!", "En développement", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void btnNewform3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cette fonction est en cours de développement!", "En développement", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void btnNewform4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cette fonction est en cours de développement!", "En développement", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
