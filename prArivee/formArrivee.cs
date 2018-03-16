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
            modeConsultation();
        }

        private void modeConsultation()
        {
            btnAction3.Enabled = true;
            btnAction4.Enabled = false;

            txtNomR.Enabled = false;
            txtNoCliR.Enabled = false;
            txtDateFin.Enabled = false;
            txtDateDeb.Enabled = false;
            txtDateRes.Enabled = false;
            txtNoRes.Enabled = false;
            txtNoChambre.Enabled = false;
            txtDateExp.Enabled = false;
            txtTypeCarte.Enabled = false;
            txtNoCarte.Enabled = false;
            txtTelephone.Enabled = false;
            txtAdresse.Enabled = false;
            txtNoCli.Enabled = false;
            txtNom.Enabled = false;
        }

        private void modeModification()
        {
            btnAction3.Enabled = false;
            btnAction4.Enabled = true;

            txtNomR.Enabled = true;
            txtNoCliR.Enabled = true;
            txtDateFin.Enabled = true;
            txtDateDeb.Enabled = true;
            txtDateRes.Enabled = true;
            txtNoRes.Enabled = true;
            txtNoChambre.Enabled = true;    
            txtDateExp.Enabled = true;
            txtTypeCarte.Enabled = true;
            txtNoCarte.Enabled = true;
            txtTelephone.Enabled = true;
            txtAdresse.Enabled = true;
            txtNoCli.Enabled = true;
            txtNom.Enabled = true;
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

                txtNoCli.DataBindings.Add("Text", BSarr, "IdCli");
                txtAdresse.DataBindings.Add("Text", BSarr, "Adresse");
                txtTelephone.DataBindings.Add("Text", BSarr, "Telephone");
                txtNoCarte.DataBindings.Add("Text", BSarr, "NoCarte");
                txtTypeCarte.DataBindings.Add("Text", BSarr, "TypeCarte");
                txtDateExp.DataBindings.Add("Text", BSarr, "DateExp");
                txtNoChambre.DataBindings.Add("Text", BSarr, "NoCham");
                txtNom.DataBindings.Add("Text", BSarr, "Nom");

                txtNoRes.DataBindings.Add("Text", BSarr, "IdReser");
                txtDateRes.DataBindings.Add("Text", BSarr, "DateReser");
                txtDateDeb.DataBindings.Add("Text", BSarr, "DateDebut");
                txtDateFin.DataBindings.Add("Text", BSarr, "DateFin");
                txtNoCliR.DataBindings.Add("Text", BSarr, "IdCli");
                txtNomR.DataBindings.Add("Text", BSarr, "Nom");
            }
            catch(Exception ee)
            {

            }
        }

        private void btnNav1_Click(object sender, EventArgs e)
        {
            BSarr.MoveFirst();
        }

        private void btnNav2_Click(object sender, EventArgs e)
        {
            BSarr.MovePrevious();
        }

        private void btnNav3_Click(object sender, EventArgs e)
        {
            BSarr.MoveNext();
        }

        private void btnNav4_Click(object sender, EventArgs e)
        {
            BSarr.MoveLast();
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

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
                                                                                            