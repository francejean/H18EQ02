namespace prArivee
{
    partial class formArrivee
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.TAarr = new prArivee.dsArriveeTableAdapters.ARRIVETableAdapter();
            this.TAcli = new prArivee.dsArriveeTableAdapters.CLIENTTableAdapter();
            this.TAcha = new prArivee.dsArriveeTableAdapters.CHAMBRETableAdapter();
            this.TAde = new prArivee.dsArriveeTableAdapters.DETableAdapter();
            this.TAres = new prArivee.dsArriveeTableAdapters.RESERVATIONTableAdapter();
            this.TAdep = new prArivee.dsArriveeTableAdapters.DEPARTTableAdapter();
            this.TAtrx = new prArivee.dsArriveeTableAdapters.TRXTableAdapter();
            this.dsArrivee = new prArivee.dsArrivee();
            this.BSarr = new System.Windows.Forms.BindingSource(this.components);
            this.BScli = new System.Windows.Forms.BindingSource(this.components);
            this.BScha = new System.Windows.Forms.BindingSource(this.components);
            this.BSde = new System.Windows.Forms.BindingSource(this.components);
            this.BSres = new System.Windows.Forms.BindingSource(this.components);
            this.BSdep = new System.Windows.Forms.BindingSource(this.components);
            this.BStrx = new System.Windows.Forms.BindingSource(this.components);
            this.btnNewform1 = new prGraphiques.btnNewform();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtNoChambre = new prGraphiques.txtInfo();
            this.txtDateExp = new prGraphiques.txtInfo();
            this.txtTypeCarte = new prGraphiques.txtInfo();
            this.txtNoCarte = new prGraphiques.txtInfo();
            this.txtTelephone = new prGraphiques.txtInfo();
            this.txtAdresse = new prGraphiques.txtInfo();
            this.txtNoCli = new prGraphiques.txtInfo();
            this.lbNom = new prGraphiques.lbInfo();
            this.lbNoChambre = new prGraphiques.lbInfo();
            this.lbDateExp = new prGraphiques.lbInfo();
            this.lbTypeCarte = new prGraphiques.lbInfo();
            this.lbNoCarte = new prGraphiques.lbInfo();
            this.lbTelephone = new prGraphiques.lbInfo();
            this.lbAdresse = new prGraphiques.lbInfo();
            this.lbNoCli = new prGraphiques.lbInfo();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtNomR = new prGraphiques.txtInfo();
            this.txtNoCliR = new prGraphiques.txtInfo();
            this.txtDateFin = new prGraphiques.txtInfo();
            this.txtDateDeb = new prGraphiques.txtInfo();
            this.txtDateRes = new prGraphiques.txtInfo();
            this.txtNoRes = new prGraphiques.txtInfo();
            this.lbNomR = new prGraphiques.lbInfo();
            this.lbNoCliR = new prGraphiques.lbInfo();
            this.lbDateFin = new prGraphiques.lbInfo();
            this.lbDateDeb = new prGraphiques.lbInfo();
            this.lbDateRes = new prGraphiques.lbInfo();
            this.lbNoRes = new prGraphiques.lbInfo();
            this.lbNoArr = new prGraphiques.lbInfo();
            this.txtNoArr = new prGraphiques.txtInfo();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo1)).BeginInit();
            this.panTitre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsArrivee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSarr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BScli)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BScha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSde)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSdep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BStrx)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNav1
            // 
            this.btnNav1.Click += new System.EventHandler(this.btnNav1_Click);
            // 
            // btnNav4
            // 
            this.btnNav4.Click += new System.EventHandler(this.btnNav4_Click);
            // 
            // btnNav3
            // 
            this.btnNav3.Click += new System.EventHandler(this.btnNav3_Click);
            // 
            // btnNav2
            // 
            this.btnNav2.Click += new System.EventHandler(this.btnNav2_Click);
            // 
            // lbTitre
            // 
            this.lbTitre.Location = new System.Drawing.Point(133, 16);
            this.lbTitre.Size = new System.Drawing.Size(414, 39);
            this.lbTitre.Text = "Gestion des arrivées";
            // 
            // btnAction1
            // 
            this.btnAction1.Click += new System.EventHandler(this.btnAction1_Click);
            // 
            // btnAction2
            // 
            this.btnAction2.Click += new System.EventHandler(this.btnAction2_Click);
            // 
            // btnAction3
            // 
            this.btnAction3.Click += new System.EventHandler(this.btnAction3_Click);
            // 
            // btnAction4
            // 
            this.btnAction4.Click += new System.EventHandler(this.btnAction4_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // TAarr
            // 
            this.TAarr.ClearBeforeFill = true;
            // 
            // TAcli
            // 
            this.TAcli.ClearBeforeFill = true;
            // 
            // TAcha
            // 
            this.TAcha.ClearBeforeFill = true;
            // 
            // TAde
            // 
            this.TAde.ClearBeforeFill = true;
            // 
            // TAres
            // 
            this.TAres.ClearBeforeFill = true;
            // 
            // TAdep
            // 
            this.TAdep.ClearBeforeFill = true;
            // 
            // TAtrx
            // 
            this.TAtrx.ClearBeforeFill = true;
            // 
            // dsArrivee
            // 
            this.dsArrivee.DataSetName = "dsArrivee";
            this.dsArrivee.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnNewform1
            // 
            this.btnNewform1.Font = new System.Drawing.Font("Rockwell Condensed", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewform1.Location = new System.Drawing.Point(321, 310);
            this.btnNewform1.Name = "btnNewform1";
            this.btnNewform1.Size = new System.Drawing.Size(8, 8);
            this.btnNewform1.TabIndex = 2;
            this.btnNewform1.Text = "btnNewform1";
            this.btnNewform1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtNoChambre);
            this.panel1.Controls.Add(this.txtDateExp);
            this.panel1.Controls.Add(this.txtTypeCarte);
            this.panel1.Controls.Add(this.txtNoCarte);
            this.panel1.Controls.Add(this.txtTelephone);
            this.panel1.Controls.Add(this.txtAdresse);
            this.panel1.Controls.Add(this.txtNoCli);
            this.panel1.Controls.Add(this.lbNom);
            this.panel1.Controls.Add(this.lbNoChambre);
            this.panel1.Controls.Add(this.lbDateExp);
            this.panel1.Controls.Add(this.lbTypeCarte);
            this.panel1.Controls.Add(this.lbNoCarte);
            this.panel1.Controls.Add(this.lbTelephone);
            this.panel1.Controls.Add(this.lbAdresse);
            this.panel1.Controls.Add(this.lbNoCli);
            this.panel1.Controls.Add(this.txtNom);
            this.panel1.Location = new System.Drawing.Point(36, 197);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(430, 220);
            this.panel1.TabIndex = 6;
            // 
            // txtNoChambre
            // 
            this.txtNoChambre.Location = new System.Drawing.Point(133, 195);
            this.txtNoChambre.Name = "txtNoChambre";
            this.txtNoChambre.Size = new System.Drawing.Size(100, 22);
            this.txtNoChambre.TabIndex = 5;
            // 
            // txtDateExp
            // 
            this.txtDateExp.Location = new System.Drawing.Point(133, 167);
            this.txtDateExp.Name = "txtDateExp";
            this.txtDateExp.Size = new System.Drawing.Size(268, 22);
            this.txtDateExp.TabIndex = 5;
            // 
            // txtTypeCarte
            // 
            this.txtTypeCarte.Location = new System.Drawing.Point(89, 138);
            this.txtTypeCarte.Name = "txtTypeCarte";
            this.txtTypeCarte.Size = new System.Drawing.Size(312, 22);
            this.txtTypeCarte.TabIndex = 5;
            // 
            // txtNoCarte
            // 
            this.txtNoCarte.Location = new System.Drawing.Point(89, 106);
            this.txtNoCarte.Name = "txtNoCarte";
            this.txtNoCarte.Size = new System.Drawing.Size(312, 22);
            this.txtNoCarte.TabIndex = 5;
            // 
            // txtTelephone
            // 
            this.txtTelephone.Location = new System.Drawing.Point(89, 70);
            this.txtTelephone.Name = "txtTelephone";
            this.txtTelephone.Size = new System.Drawing.Size(160, 22);
            this.txtTelephone.TabIndex = 5;
            // 
            // txtAdresse
            // 
            this.txtAdresse.Location = new System.Drawing.Point(74, 36);
            this.txtAdresse.Name = "txtAdresse";
            this.txtAdresse.Size = new System.Drawing.Size(327, 22);
            this.txtAdresse.TabIndex = 5;
            // 
            // txtNoCli
            // 
            this.txtNoCli.Location = new System.Drawing.Point(73, 7);
            this.txtNoCli.Name = "txtNoCli";
            this.txtNoCli.Size = new System.Drawing.Size(100, 22);
            this.txtNoCli.TabIndex = 5;
            // 
            // lbNom
            // 
            this.lbNom.AutoSize = true;
            this.lbNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNom.Location = new System.Drawing.Point(179, 7);
            this.lbNom.Name = "lbNom";
            this.lbNom.Size = new System.Drawing.Size(37, 17);
            this.lbNom.TabIndex = 6;
            this.lbNom.Text = "Nom";
            // 
            // lbNoChambre
            // 
            this.lbNoChambre.AutoSize = true;
            this.lbNoChambre.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNoChambre.Location = new System.Drawing.Point(13, 195);
            this.lbNoChambre.Name = "lbNoChambre";
            this.lbNoChambre.Size = new System.Drawing.Size(117, 17);
            this.lbNoChambre.TabIndex = 6;
            this.lbNoChambre.Text = "Numéro chambre";
            // 
            // lbDateExp
            // 
            this.lbDateExp.AutoSize = true;
            this.lbDateExp.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDateExp.Location = new System.Drawing.Point(13, 170);
            this.lbDateExp.Name = "lbDateExp";
            this.lbDateExp.Size = new System.Drawing.Size(114, 17);
            this.lbDateExp.TabIndex = 6;
            this.lbDateExp.Text = "Date d\'expiration";
            // 
            // lbTypeCarte
            // 
            this.lbTypeCarte.AutoSize = true;
            this.lbTypeCarte.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTypeCarte.Location = new System.Drawing.Point(10, 141);
            this.lbTypeCarte.Name = "lbTypeCarte";
            this.lbTypeCarte.Size = new System.Drawing.Size(76, 17);
            this.lbTypeCarte.TabIndex = 6;
            this.lbTypeCarte.Text = "Type carte";
            // 
            // lbNoCarte
            // 
            this.lbNoCarte.AutoSize = true;
            this.lbNoCarte.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNoCarte.Location = new System.Drawing.Point(10, 108);
            this.lbNoCarte.Name = "lbNoCarte";
            this.lbNoCarte.Size = new System.Drawing.Size(64, 17);
            this.lbNoCarte.TabIndex = 6;
            this.lbNoCarte.Text = "No Carte";
            // 
            // lbTelephone
            // 
            this.lbTelephone.AutoSize = true;
            this.lbTelephone.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTelephone.Location = new System.Drawing.Point(7, 75);
            this.lbTelephone.Name = "lbTelephone";
            this.lbTelephone.Size = new System.Drawing.Size(76, 17);
            this.lbTelephone.TabIndex = 6;
            this.lbTelephone.Text = "Téléphone";
            // 
            // lbAdresse
            // 
            this.lbAdresse.AutoSize = true;
            this.lbAdresse.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAdresse.Location = new System.Drawing.Point(7, 42);
            this.lbAdresse.Name = "lbAdresse";
            this.lbAdresse.Size = new System.Drawing.Size(60, 17);
            this.lbAdresse.TabIndex = 6;
            this.lbAdresse.Text = "Adresse";
            // 
            // lbNoCli
            // 
            this.lbNoCli.AutoSize = true;
            this.lbNoCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNoCli.Location = new System.Drawing.Point(13, 7);
            this.lbNoCli.Name = "lbNoCli";
            this.lbNoCli.Size = new System.Drawing.Size(43, 17);
            this.lbNoCli.TabIndex = 6;
            this.lbNoCli.Text = "No cli";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(235, 4);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(121, 22);
            this.txtNom.TabIndex = 15;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtNomR);
            this.panel2.Controls.Add(this.txtNoCliR);
            this.panel2.Controls.Add(this.txtDateFin);
            this.panel2.Controls.Add(this.txtDateDeb);
            this.panel2.Controls.Add(this.txtDateRes);
            this.panel2.Controls.Add(this.txtNoRes);
            this.panel2.Controls.Add(this.lbNomR);
            this.panel2.Controls.Add(this.lbNoCliR);
            this.panel2.Controls.Add(this.lbDateFin);
            this.panel2.Controls.Add(this.lbDateDeb);
            this.panel2.Controls.Add(this.lbDateRes);
            this.panel2.Controls.Add(this.lbNoRes);
            this.panel2.Location = new System.Drawing.Point(507, 197);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(325, 220);
            this.panel2.TabIndex = 8;
            // 
            // txtNomR
            // 
            this.txtNomR.Location = new System.Drawing.Point(206, 183);
            this.txtNomR.Name = "txtNomR";
            this.txtNomR.Size = new System.Drawing.Size(100, 22);
            this.txtNomR.TabIndex = 5;
            // 
            // txtNoCliR
            // 
            this.txtNoCliR.Location = new System.Drawing.Point(83, 184);
            this.txtNoCliR.Name = "txtNoCliR";
            this.txtNoCliR.Size = new System.Drawing.Size(70, 22);
            this.txtNoCliR.TabIndex = 5;
            // 
            // txtDateFin
            // 
            this.txtDateFin.Location = new System.Drawing.Point(206, 147);
            this.txtDateFin.Name = "txtDateFin";
            this.txtDateFin.Size = new System.Drawing.Size(100, 22);
            this.txtDateFin.TabIndex = 5;
            // 
            // txtDateDeb
            // 
            this.txtDateDeb.Location = new System.Drawing.Point(206, 106);
            this.txtDateDeb.Name = "txtDateDeb";
            this.txtDateDeb.Size = new System.Drawing.Size(100, 22);
            this.txtDateDeb.TabIndex = 5;
            // 
            // txtDateRes
            // 
            this.txtDateRes.Location = new System.Drawing.Point(206, 75);
            this.txtDateRes.Name = "txtDateRes";
            this.txtDateRes.Size = new System.Drawing.Size(100, 22);
            this.txtDateRes.TabIndex = 5;
            // 
            // txtNoRes
            // 
            this.txtNoRes.Location = new System.Drawing.Point(206, 42);
            this.txtNoRes.Name = "txtNoRes";
            this.txtNoRes.Size = new System.Drawing.Size(100, 22);
            this.txtNoRes.TabIndex = 5;
            // 
            // lbNomR
            // 
            this.lbNomR.AutoSize = true;
            this.lbNomR.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNomR.Location = new System.Drawing.Point(159, 186);
            this.lbNomR.Name = "lbNomR";
            this.lbNomR.Size = new System.Drawing.Size(37, 17);
            this.lbNomR.TabIndex = 6;
            this.lbNomR.Text = "Nom";
            // 
            // lbNoCliR
            // 
            this.lbNoCliR.AutoSize = true;
            this.lbNoCliR.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNoCliR.Location = new System.Drawing.Point(11, 186);
            this.lbNoCliR.Name = "lbNoCliR";
            this.lbNoCliR.Size = new System.Drawing.Size(65, 17);
            this.lbNoCliR.TabIndex = 6;
            this.lbNoCliR.Text = "No Client";
            // 
            // lbDateFin
            // 
            this.lbDateFin.AutoSize = true;
            this.lbDateFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDateFin.Location = new System.Drawing.Point(8, 147);
            this.lbDateFin.Name = "lbDateFin";
            this.lbDateFin.Size = new System.Drawing.Size(81, 17);
            this.lbDateFin.TabIndex = 6;
            this.lbDateFin.Text = "Date de Fin";
            // 
            // lbDateDeb
            // 
            this.lbDateDeb.AutoSize = true;
            this.lbDateDeb.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDateDeb.Location = new System.Drawing.Point(8, 110);
            this.lbDateDeb.Name = "lbDateDeb";
            this.lbDateDeb.Size = new System.Drawing.Size(98, 17);
            this.lbDateDeb.TabIndex = 6;
            this.lbDateDeb.Text = "Date de début";
            // 
            // lbDateRes
            // 
            this.lbDateRes.AutoSize = true;
            this.lbDateRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDateRes.Location = new System.Drawing.Point(8, 73);
            this.lbDateRes.Name = "lbDateRes";
            this.lbDateRes.Size = new System.Drawing.Size(84, 17);
            this.lbDateRes.TabIndex = 6;
            this.lbDateRes.Text = "Réservé le :";
            // 
            // lbNoRes
            // 
            this.lbNoRes.AutoSize = true;
            this.lbNoRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNoRes.Location = new System.Drawing.Point(8, 37);
            this.lbNoRes.Name = "lbNoRes";
            this.lbNoRes.Size = new System.Drawing.Size(106, 17);
            this.lbNoRes.TabIndex = 6;
            this.lbNoRes.Text = "No Réservation";
            // 
            // lbNoArr
            // 
            this.lbNoArr.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.lbNoArr.AutoSize = true;
            this.lbNoArr.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNoArr.Location = new System.Drawing.Point(507, 170);
            this.lbNoArr.Name = "lbNoArr";
            this.lbNoArr.Size = new System.Drawing.Size(75, 17);
            this.lbNoArr.TabIndex = 6;
            this.lbNoArr.Text = "No Arrivée";
            // 
            // txtNoArr
            // 
            this.txtNoArr.Location = new System.Drawing.Point(583, 164);
            this.txtNoArr.Name = "txtNoArr";
            this.txtNoArr.Size = new System.Drawing.Size(100, 22);
            this.txtNoArr.TabIndex = 5;
            // 
            // formArrivee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 603);
            this.Controls.Add(this.txtNoArr);
            this.Controls.Add(this.lbNoArr);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnNewform1);
            this.Name = "formArrivee";
            this.Load += new System.EventHandler(this.formArrivee_Load);
            this.Controls.SetChildIndex(this.btnNewform1, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.btnNav4, 0);
            this.Controls.SetChildIndex(this.btnNav3, 0);
            this.Controls.SetChildIndex(this.btnNav2, 0);
            this.Controls.SetChildIndex(this.btnNav1, 0);
            this.Controls.SetChildIndex(this.panTitre, 0);
            this.Controls.SetChildIndex(this.picLogo2, 0);
            this.Controls.SetChildIndex(this.picLogo1, 0);
            this.Controls.SetChildIndex(this.btnQuit, 0);
            this.Controls.SetChildIndex(this.lbDate, 0);
            this.Controls.SetChildIndex(this.lbHeure, 0);
            this.Controls.SetChildIndex(this.btnAction4, 0);
            this.Controls.SetChildIndex(this.btnAction3, 0);
            this.Controls.SetChildIndex(this.btnAction2, 0);
            this.Controls.SetChildIndex(this.btnAction1, 0);
            this.Controls.SetChildIndex(this.lbNoArr, 0);
            this.Controls.SetChildIndex(this.txtNoArr, 0);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo1)).EndInit();
            this.panTitre.ResumeLayout(false);
            this.panTitre.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsArrivee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSarr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BScli)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BScha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSde)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSdep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BStrx)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private dsArriveeTableAdapters.ARRIVETableAdapter TAarr;
        private dsArriveeTableAdapters.CLIENTTableAdapter TAcli;
        private dsArriveeTableAdapters.CHAMBRETableAdapter TAcha;
        private dsArriveeTableAdapters.DETableAdapter TAde;
        private dsArriveeTableAdapters.RESERVATIONTableAdapter TAres;
        private dsArriveeTableAdapters.DEPARTTableAdapter TAdep;
        private dsArriveeTableAdapters.TRXTableAdapter TAtrx;
        private dsArrivee dsArrivee;
        private System.Windows.Forms.BindingSource BSarr;
        private System.Windows.Forms.BindingSource BScli;
        private System.Windows.Forms.BindingSource BScha;
        private System.Windows.Forms.BindingSource BSde;
        private System.Windows.Forms.BindingSource BSres;
        private System.Windows.Forms.BindingSource BSdep;
        private System.Windows.Forms.BindingSource BStrx;
        private prGraphiques.btnNewform btnNewform1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Panel panel2;
        private prGraphiques.lbInfo lbNoCli;
        private prGraphiques.lbInfo lbTelephone;
        private prGraphiques.lbInfo lbAdresse;
        private prGraphiques.lbInfo lbTypeCarte;
        private prGraphiques.lbInfo lbNoCarte;
        private prGraphiques.lbInfo lbNom;
        private prGraphiques.lbInfo lbNoChambre;
        private prGraphiques.lbInfo lbDateExp;
        private prGraphiques.lbInfo lbDateRes;
        private prGraphiques.lbInfo lbNoRes;
        private prGraphiques.lbInfo lbNoArr;
        private prGraphiques.lbInfo lbNoCliR;
        private prGraphiques.lbInfo lbDateFin;
        private prGraphiques.lbInfo lbDateDeb;
        private prGraphiques.lbInfo lbNomR;
        private prGraphiques.txtInfo txtTelephone;
        private prGraphiques.txtInfo txtAdresse;
        private prGraphiques.txtInfo txtNoCli;
        private prGraphiques.txtInfo txtDateExp;
        private prGraphiques.txtInfo txtTypeCarte;
        private prGraphiques.txtInfo txtNoCarte;
        private prGraphiques.txtInfo txtNoChambre;
        private prGraphiques.txtInfo txtNomR;
        private prGraphiques.txtInfo txtNoCliR;
        private prGraphiques.txtInfo txtDateFin;
        private prGraphiques.txtInfo txtDateDeb;
        private prGraphiques.txtInfo txtDateRes;
        private prGraphiques.txtInfo txtNoRes;
        private prGraphiques.txtInfo txtNoArr;
    }
}

