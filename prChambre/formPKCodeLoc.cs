using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prChambre
{
    public partial class formPKCodeLoc : Form
    {
        public formPKCodeLoc()
        {
            InitializeComponent();
        }

        public DataGridView DgCodeLoc
        {
            get
            {
                return dgCodeLoc;
            }
            set
            {
                dgCodeLoc = value;
            }
        }

        private void formPKCodeLoc_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsChambre.LOCALISATION' table. You can move, or remove it, as needed.
            //this.lOCALISATIONTableAdapter.Fill(this.dsChambre.LOCALISATION);

        }
    }
}
