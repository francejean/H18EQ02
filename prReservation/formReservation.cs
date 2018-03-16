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
            modeConsultation();
        }

        private void formReservation_Load(object sender, EventArgs e)
        {
            Fill();
            linkReservation();
            //Link_Contient();

        }

        private void modeConsultation()
        {
            btnAction3.Enabled = true;
            btnAction4.Enabled = false;

            txtNoReserv.Enabled = false;
            txtNoCli.Enabled = false;
            txtNom.Enabled = false;
            txtAdrss.Enabled = false;
            txtNoTel.Enabled = false;
            txtNoCart.Enabled = false;
            txtTypCart.Enabled = false;
            txtDateExp.Enabled = false;
            txtSoldDu.Enabled = false;
            txtReservle.Enabled = false;
            txtDateDeb.Enabled = false;
            txtDateFin.Enabled = false;
        }

        private void modeModification()
        {
            btnAction3.Enabled = false;
            btnAction4.Enabled = true;

            txtNoReserv.Enabled = true;
            txtNoCli.Enabled = true;
            txtNom.Enabled = true;
            txtAdrss.Enabled = true;
            txtNoTel.Enabled = true;
            txtNoCart.Enabled = true;
            txtTypCart.Enabled = true;
            txtDateExp.Enabled = true;
            txtSoldDu.Enabled = true;
            txtReservle.Enabled = true;
            txtDateDeb.Enabled = true;
            txtDateFin.Enabled = true;
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
                txtNoReserv.DataBindings.Add("Text", BSres, "IdReser");
                txtNoCli.DataBindings.Add("Text", BSres, "IdCli");
                txtNom.DataBindings.Add("Text", BSres, "Nom");
                txtAdrss.DataBindings.Add("Text", BSres, "Adresse");
                txtNoTel.DataBindings.Add("Text", BSres, "Telephone");
                txtNoCart.DataBindings.Add("Text", BSres, "NoCarte");
                txtTypCart.DataBindings.Add("Text", BSres, "TypeCarte");
                txtDateExp.DataBindings.Add("Text", BSres, "DateExp");
                txtSoldDu.DataBindings.Add("Text", BSres, "SoldeDu");
                txtReservle.DataBindings.Add("Text", BSres, "DateReser");
                txtDateDeb.DataBindings.Add("Text", BSres, "DateDebut");
                txtDateFin.DataBindings.Add("Text", BSres, "DateFin");
            }
            catch(Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private void btnNav3_Click(object sender, EventArgs e)
        {
            BSres.MoveNext();
        }

        private void btnNav2_Click(object sender, EventArgs e)
        {
            BSres.MovePrevious();
        }

        private void btnNav1_Click(object sender, EventArgs e)
        {
            BSres.MoveFirst();
        }

        private void btnNav4_Click(object sender, EventArgs e)
        {
            BSres.MoveLast();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAction1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cette fonction est en cours de développement!", "En développement", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void btnAction2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cette fonction est en cours de développement!", "En développement", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void btnAction3_Click(object sender, EventArgs e)
        {
            modeModification();
        }

        private void btnAction4_Click(object sender, EventArgs e)
        {
            modeConsultation();
        }
    }
}
