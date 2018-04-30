using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using prGraphiques;

namespace prChambre
{
    public partial class formChambre : formBase
    {
        private formPKCodeType fPKCodeType;
        private formPKCodeLoc fPKCodeLoc;
        private enum Mode { Consultation, Modification, Ajout, Suppression };
        private Mode currentmode;

        private DataRow rowchambre;
        private DataRow rowayant;
        private DataRow backuprowcom;

        private BindingSource BSbkcom = new BindingSource();

        public formChambre()
        {
            InitializeComponent();
            modeConsultation();
            prepareList();
        }

        private void prepareList()
        {
            fPKCodeType = new formPKCodeType();
            fPKCodeType.DgCodeType.DataSource = BStypc;
            fPKCodeLoc = new formPKCodeLoc();
            fPKCodeLoc.DgCodeLoc.DataSource = BSloc;
        }

        private bool validerAjout()
        {
            bool validated = true;
            errorProvider1.SetError(txtEtage, "");
            errorProvider1.SetError(txtEtat, "");
            errorProvider1.SetError(txtPrix, "");
            errorProvider1.SetError(txtCodeLoc, "");
            errorProvider1.SetError(txtCodeType, "");
            Match match = Regex.Match(txtEtage.Text, @"[0][1-9]");
            if (!match.Success)
            {
                errorProvider1.SetError(txtEtage,"Étage invalide! (Doit être entre 01 et 09)");
                validated = false;
            }
            else
            {
                int i = 1;
                int ind = 0;
                while (i < 100 && ind != -1)
                {
                    if (i < 10) ind = BScha.Find("NoCham", txtEtage.Text.ElementAt(1) + "0" + i.ToString());
                    else ind = BScha.Find("NoCham", txtEtage.Text.ElementAt(1) + i.ToString());
                    i++;
                }
                if (ind != -1)
                {
                    errorProvider1.SetError(txtEtage, "Étage plein! (Ne peut avoir plus de 99 chambres)");
                    validated = false;
                }
                else
                {
                    i--;
                    if (i < 10) txtNoCham.Text = txtEtage.Text.ElementAt(1) + "0" + i.ToString();
                    else txtNoCham.Text = txtEtage.Text.ElementAt(1) + i.ToString();
                }
            }
            match = Regex.Match(txtEtat.Text, @"[01]");
            if (!match.Success)
            {
                errorProvider1.SetError(txtEtat, "État invalide! (Doit être 0 ou 1)");
                validated = false;
            }
            match = Regex.Match(txtPrix.Text, @"\d+(\.\d{1,2})?");
            if (!match.Success)
            {
                errorProvider1.SetError(txtPrix, "Format du prix invalide! (999.99$ Maximum)");
                validated = false;
            }
            if (txtCodeLoc.Text == "")
            {
                errorProvider1.SetError(txtCodeLoc, "Localisation vide!");
                validated = false;
            }
            if (txtCodeType.Text == "")
            {
                errorProvider1.SetError(txtCodeType, "Type de chambre vide!");
                validated = false;
            }
            return validated;
        }

        private void updateDG()
        {
            this.BSaya.Filter = "NoCham = '" + txtNoCham.Text + "'";
        }

        private void modeConsultation()
        {
            btnAction1.Enabled = true;
            btnAction2.Enabled = true;
            btnAction3.Enabled = true;
            btnAction4.Enabled = false;
            btnConfirmer.Enabled = false;
            btnAnnuler.Enabled = false;
            btnNav1.Enabled = true;
            btnNav2.Enabled = true;
            btnNav3.Enabled = true;
            btnNav4.Enabled = true;
            btnQuit.Enabled = true;

            btnAjoutAyant.Enabled = false;
            btnSuppressionAyant.Enabled = false;

            txtNoCham.Enabled = true;
            txtNoCham.ReadOnly = true;
            txtEtage.ReadOnly = true;
            txtEtat.ReadOnly = true;
            txtCodeType.ReadOnly = true;
            txtCodeLoc.ReadOnly = true;
            txtPrix.ReadOnly = true;
            txtTypeDesc.ReadOnly = true;
            txtLocDesc.ReadOnly = true;
            txtMemo.ReadOnly = true;

            txtCodeType.Enabled = false;
            txtCodeLoc.Enabled = false;

            currentmode = Mode.Consultation;
        }

        private void modeModification()
        {
            btnAction1.Enabled = false;
            btnAction2.Enabled = false;
            btnAction3.Enabled = false;
            btnAction4.Enabled = false;
            btnConfirmer.Enabled = true;
            btnAnnuler.Enabled = true;
            btnNav1.Enabled = false;
            btnNav2.Enabled = false;
            btnNav3.Enabled = false;
            btnNav4.Enabled = false;
            btnQuit.Enabled = false;

            btnAjoutAyant.Enabled = true;
            btnSuppressionAyant.Enabled = true;

            txtNoCham.Enabled = false;
            txtNoCham.ReadOnly = false;
            txtEtage.ReadOnly = false;
            txtEtat.ReadOnly = false;
            txtCodeType.ReadOnly = true;
            txtCodeLoc.ReadOnly = true;
            txtPrix.ReadOnly = false;
            txtTypeDesc.ReadOnly = true;
            txtLocDesc.ReadOnly = true;
            txtMemo.ReadOnly = false;

            txtCodeType.Enabled = true;
            txtCodeLoc.Enabled = true;

            currentmode = Mode.Modification;
        }

        private void modeAjout()
        {
            btnAction1.Enabled = false;
            btnAction2.Enabled = false;
            btnAction3.Enabled = false;
            btnAction4.Enabled = false;
            btnConfirmer.Enabled = true;
            btnAnnuler.Enabled = true;
            btnNav1.Enabled = false;
            btnNav2.Enabled = false;
            btnNav3.Enabled = false;
            btnNav4.Enabled = false;
            btnQuit.Enabled = false;

            btnAjoutAyant.Enabled = true;
            btnSuppressionAyant.Enabled = true;

            txtNoCham.Enabled = false;
            txtNoCham.ReadOnly = false;
            txtEtage.ReadOnly = false;
            txtEtat.ReadOnly = false;
            txtCodeType.ReadOnly = true;
            txtCodeLoc.ReadOnly = true;
            txtPrix.ReadOnly = false;
            txtTypeDesc.ReadOnly = true;
            txtLocDesc.ReadOnly = true;
            txtMemo.ReadOnly = false;
            
            txtCodeType.Enabled = true;
            txtCodeLoc.Enabled = true;

            currentmode = Mode.Ajout;
        }

        private void formChambre_Load(object sender, EventArgs e)
        {
            Fill();
            linkChambre();
            linkAyant();
        }

        private void Fill()
        {
            this.TAaya.Fill(this.dsChambre.AYANT);
            this.TAde.Fill(this.dsChambre.DE);
            this.TAloc.Fill(this.dsChambre.LOCALISATION);
            this.TAres.Fill(this.dsChambre.RESERVATION);
            this.TAtypc.Fill(this.dsChambre.TYPECHAM);
            this.TAcha.FillBy(this.dsChambre.CHAMBRE);
        }

        private void linkChambre()
        {
            this.BScha.DataMember = "CHAMBRE";
            this.BScha.DataSource = this.dsChambre;

            this.BSaya.DataMember = "AYANT";
            this.BSaya.DataSource = this.dsChambre;

            this.BStypc.DataMember = "TYPECHAM";
            this.BStypc.DataSource = this.dsChambre;

            this.BSloc.DataMember = "LOCALISATION";
            this.BSloc.DataSource = this.dsChambre;

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
                dgCom.Columns[0].DataPropertyName = "CodCom";
                dgCom.Columns[1].DataPropertyName = "DescCom";
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }

            updateDG();
        }

        private void linkAyant()
        {
            BSaya.Position = 0;
        }

        private void btnNav1_Click(object sender, EventArgs e)
        {
            BScha.MoveFirst();
            updateDG();
        }

        private void btnNav2_Click(object sender, EventArgs e)
        {
            BScha.MovePrevious();
            updateDG();
        }

        private void btnNav3_Click(object sender, EventArgs e)
        {
            BScha.MoveNext();
            updateDG();
        }

        private void btnNav4_Click(object sender, EventArgs e)
        {
            BScha.MoveLast();
            updateDG();
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
            modeAjout();

            BScha.Position = BScha.Count - 1;
            rowchambre = dsChambre.Tables["CHAMBRE"].NewRow();

            rowchambre["NoCham"] = "000";
            rowchambre["Etage"] = "00";
            rowchambre["Prix"] = 100.00;
            rowchambre["Etat"] = 0;
            rowchambre["Memo"] = "Entrez un memo.";

            dsChambre.Tables["CHAMBRE"].Rows.Add(rowchambre);
            BScha.Position = BScha.Count - 1;

            updateDG();

            rowchambre.BeginEdit();
        }

        private void btnAction2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cette fonction est en cours de développement!", "En développement", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void txtCodeType_DoubleClick(object sender, EventArgs e)
        {
            if (fPKCodeType.ShowDialog() == DialogResult.OK)
            {
                txtCodeType.Text = dsChambre.Tables["TYPECHAM"].Rows[BStypc.Position]["CodTypCham"].ToString();
                txtTypeDesc.Text = dsChambre.Tables["TYPECHAM"].Rows[BStypc.Position]["DescTyp"].ToString();
            }
        }

        private void txtCodeLoc_DoubleClick(object sender, EventArgs e)
        {
            if (fPKCodeLoc.ShowDialog() == DialogResult.OK)
            {
                txtCodeLoc.Text = dsChambre.Tables["LOCALISATION"].Rows[BSloc.Position]["CodLoc"].ToString();
                txtLocDesc.Text = dsChambre.Tables["LOCALISATION"].Rows[BSloc.Position]["DescLoc"].ToString();
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            if (currentmode == Mode.Ajout)
            {
                dsChambre.Tables["CHAMBRE"].RejectChanges();
                errorProvider1.SetError(txtEtage, "");
                errorProvider1.SetError(txtEtat, "");
                errorProvider1.SetError(txtPrix, "");
                errorProvider1.SetError(txtCodeLoc, "");
                errorProvider1.SetError(txtCodeType, "");
                modeConsultation();
                updateDG();
            }
            else if (currentmode == Mode.Modification)
            {
                modeConsultation();
            }
        }

        private void btnConfirmer_Click(object sender, EventArgs e)
        {
            if (currentmode == Mode.Ajout)
            {
                if (validerAjout())
                {
                    rowchambre.EndEdit();

                    TAcha.Update(this.dsChambre.CHAMBRE);

                    modeConsultation();
                    updateDG();
                }
                else
                {
                    MessageBox.Show("Il y a une ou des erreurs!", "Erreur!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (currentmode == Mode.Modification)
            {
                modeConsultation();
            }
        }
    }
}
