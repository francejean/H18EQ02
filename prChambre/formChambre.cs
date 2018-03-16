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

namespace prChambre
{
    public partial class formChambre : formBase
    {
        public formChambre()
        {
            InitializeComponent();
            modeConsultation();
        }

        private void modeConsultation()
        {
            btnAction3.Enabled = true;
            btnAction4.Enabled = false;

            txtNoCham.Enabled = false;
            txtEtage.Enabled = false;
            txtEtat.Enabled = false;
            txtCodeType.Enabled = false;
            txtCodeLoc.Enabled = false;
            txtPrix.Enabled = false;
            txtTypeDesc.Enabled = false;
            txtLocDesc.Enabled = false;
            txtMemo.Enabled = false;
        }

        private void modeModification()
        {
            btnAction3.Enabled = false;
            btnAction4.Enabled = true;

            txtNoCham.Enabled = true;
            txtEtage.Enabled = true;
            txtEtat.Enabled = true;
            txtCodeType.Enabled = true;
            txtCodeLoc.Enabled = true;
            txtPrix.Enabled = true;
            txtTypeDesc.Enabled = true;
            txtLocDesc.Enabled = true;
            txtMemo.Enabled = true;
        }

        private void formChambre_Load(object sender, EventArgs e)
        {
            Fill();
            linkChambre();
        }

        private void Fill()
        {
            this.TAaya.Fill(this.dsChambre.AYANT);
            this.TAcha.Fill(this.dsChambre.CHAMBRE);
            this.TAde.Fill(this.dsChambre.DE);
            this.TAloc.Fill(this.dsChambre.LOCALISATION);
            this.TAres.Fill(this.dsChambre.RESERVATION);
            this.TAtypc.Fill(this.dsChambre.TYPECHAM);
        }

        private void linkChambre()
        {
            this.BScha.DataMember = "CHAMBRE";
            this.BScha.DataSource = this.dsChambre;

            try
            {
                txtNoCham.DataBindings.Add("Text", BScha, "NoCham");
                txtEtage.DataBindings.Add("Text", BScha, "Etage");
                txtEtat.DataBindings.Add("Text", BScha, "Etat");
                txtCodeType.DataBindings.Add("Text", BScha, "CodTypCham");
                txtCodeLoc.DataBindings.Add("Text", BScha, "CodLoc");
                txtPrix.DataBindings.Add("Text", BScha, "Prix");
                txtTypeDesc.DataBindings.Add("Text", BScha, "DescTyp");
                txtLocDesc.DataBindings.Add("Text", BScha, "DescLoc");
                txtMemo.DataBindings.Add("Text", BScha, "Memo");
            }
            catch (Exception ee)
            {
                //MessageBox.Show(ee.Message);
            }
        }

        private void btnNav1_Click(object sender, EventArgs e)
        {
            BScha.MoveFirst();
        }

        private void btnNav2_Click(object sender, EventArgs e)
        {
            BScha.MovePrevious();
        }

        private void btnNav3_Click(object sender, EventArgs e)
        {
            BScha.MoveNext();
        }

        private void btnNav4_Click(object sender, EventArgs e)
        {
            BScha.MoveLast();
        }

        private void btnAction4_Click(object sender, EventArgs e)
        {
            modeConsultation();
        }

        private void btnAction3_Click(object sender, EventArgs e)
        {
            modeModification();
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
    }
}
