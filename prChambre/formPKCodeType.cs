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
    public partial class formPKCodeType : Form
    {
        public formPKCodeType()
        {
            InitializeComponent();
        }

        public DataGridView DgCodeType
        {
            get
            {
                return dgCodeType;
            }
            set
            {
                dgCodeType = value;
            }
        }

        private void formPKCodeType_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsChambre.TYPECHAM' table. You can move, or remove it, as needed.
            //this.tYPECHAMTableAdapter.Fill(this.dsChambre.TYPECHAM);

        }
    }
}
