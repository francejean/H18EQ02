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

namespace prArivee
{
    public partial class formArrivee : formBase
    {
        public formArrivee()
        {
            InitializeComponent();
        }

        private void formArrivee_Load(object sender, EventArgs e)
        {
            Fill();
            linkArrive();
        }

        private void Fill()
        {
            this.TAarr.Fill(this.dsArrivee.ARRIVE);
            this.TAcha.Fill(this.dsArrivee.CHAMBRE);
            this.TAcli.Fill(this.dsArrivee.CLIENT);
            this.TAde.Fill(this.dsArrivee.DE);
            this.TAdep.Fill(this.dsArrivee.DEPART);
            this.TAres.Fill(this.dsArrivee.RESERVATION);
            this.TAtrx.Fill(this.dsArrivee.TRX);
        }

        private void linkArrive()
        {
            this.BSarr.DataMember = "ARRIVE";
            this.BSarr.DataSource = this.dsArrivee;

            try
            {
                txtNoArr.DataBindings.Add("Text", BSarr, "IdArrive");
            }
            catch(Exception ee)
            {

            }
        }
    }
}
