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

namespace prReservation
{
    public partial class formReservation : formBase
    {
        public formReservation()
        {
            InitializeComponent();
        }

        private void formReservation_Load(object sender, EventArgs e)
        {
            Fill();
            linkReservation();
            //Link_Contient();

        }

        private void Fill()
        {
            this.TAarr.Fill(this.dsReservation.ARRIVE);
            this.TAcha.Fill(this.dsReservation.CHAMBRE);
            this.TAcli.Fill(this.dsReservation.CLIENT);
            this.TAde.Fill(this.dsReservation.DE);
            this.TAdep.Fill(this.dsReservation.DEPART);
            this.TAres.Fill(this.dsReservation.RESERVATION);
            this.TAtrx.Fill(this.dsReservation.TRX);
            this.TAtypc.Fill(this.dsReservation.TYPECHAM);
        }

        private void linkReservation()
        {
            this.BSres.DataMember = "RESERVATION";
            this.BSres.DataSource = this.dsReservation;

            try
            {
                txtNoRes.DataBindings.Add("Text", BSres, "IdReser");

            }
            catch(Exception ee)
            {

            }
        }

        private void btnNav3_Click(object sender, EventArgs e)
        {
            BSres.MoveNext();
        }
    }
}
