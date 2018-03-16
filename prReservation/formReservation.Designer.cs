namespace prReservation
{
    partial class formReservation
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
            this.BSres = new System.Windows.Forms.BindingSource(this.components);
            this.BScli = new System.Windows.Forms.BindingSource(this.components);
            this.BSde = new System.Windows.Forms.BindingSource(this.components);
            this.BScha = new System.Windows.Forms.BindingSource(this.components);
            this.BSarr = new System.Windows.Forms.BindingSource(this.components);
            this.BSdep = new System.Windows.Forms.BindingSource(this.components);
            this.BStrx = new System.Windows.Forms.BindingSource(this.components);
            this.BStypc = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSoldDu = new prGraphiques.txtInfo();
            this.txtDateExp = new prGraphiques.txtInfo();
            this.txtTypCart = new prGraphiques.txtInfo();
            this.txtNoCart = new prGraphiques.txtInfo();
            this.txtNoTel = new prGraphiques.txtInfo();
            this.txtAdrss = new prGraphiques.txtInfo();
            this.txtNom = new prGraphiques.txtInfo();
            this.txtNoCli = new prGraphiques.txtInfo();
            this.lbNom = new prGraphiques.lbInfo();
            this.lbNoCli = new prGraphiques.lbInfo();
            this.lbNoTel = new prGraphiques.lbInfo();
            this.lbAdrss = new prGraphiques.lbInfo();
            this.lbNoCart = new prGraphiques.lbInfo();
            this.lbTypCart = new prGraphiques.lbInfo();
            this.lbSoldeDu = new prGraphiques.lbInfo();
            this.lbDateExp = new prGraphiques.lbInfo();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtDateDeb = new prGraphiques.txtInfo();
            this.txtDateFin = new prGraphiques.txtInfo();
            this.txtReservle = new prGraphiques.txtInfo();
            this.txtNoReserv = new prGraphiques.txtInfo();
            this.lbDateFin = new prGraphiques.lbInfo();
            this.lbDateDeb = new prGraphiques.lbInfo();
            this.lbReservle = new prGraphiques.lbInfo();
            this.lbNoReserv = new prGraphiques.lbInfo();
            this.TAres = new prReservation.dsReservationTableAdapters.RESERVATIONTableAdapter();
            this.TAcli = new prReservation.dsReservationTableAdapters.CLIENTTableAdapter();
            this.TAde = new prReservation.dsReservationTableAdapters.DETableAdapter();
            this.TAcha = new prReservation.dsReservationTableAdapters.CHAMBRETableAdapter();
            this.TAarr = new prReservation.dsReservationTableAdapters.ARRIVETableAdapter();
            this.TAdep = new prReservation.dsReservationTableAdapters.DEPARTTableAdapter();
            this.TAtrx = new prReservation.dsReservationTableAdapters.TRXTableAdapter();
            this.TAtypc = new prReservation.dsReservationTableAdapters.TYPECHAMTableAdapter();
            this.dsReservation = new prReservation.dsReservation();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo1)).BeginInit();
            this.panTitre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BScli)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSde)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BScha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSarr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSdep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BStrx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BStypc)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsReservation)).BeginInit();
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
            this.lbTitre.Location = new System.Drawing.Point(100, 16);
            this.lbTitre.Size = new System.Drawing.Size(500, 39);
            this.lbTitre.Text = "Gestion des réservations";
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
            // panel1
            // 
            this.panel1.Controls.Add(this.txtSoldDu);
            this.panel1.Controls.Add(this.txtDateExp);
            this.panel1.Controls.Add(this.txtTypCart);
            this.panel1.Controls.Add(this.txtNoCart);
            this.panel1.Controls.Add(this.txtNoTel);
            this.panel1.Controls.Add(this.txtAdrss);
            this.panel1.Controls.Add(this.txtNom);
            this.panel1.Controls.Add(this.txtNoCli);
            this.panel1.Controls.Add(this.lbNom);
            this.panel1.Controls.Add(this.lbNoCli);
            this.panel1.Controls.Add(this.lbNoTel);
            this.panel1.Controls.Add(this.lbAdrss);
            this.panel1.Controls.Add(this.lbNoCart);
            this.panel1.Controls.Add(this.lbTypCart);
            this.panel1.Controls.Add(this.lbSoldeDu);
            this.panel1.Controls.Add(this.lbDateExp);
            this.panel1.Location = new System.Drawing.Point(12, 211);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(478, 225);
            this.panel1.TabIndex = 6;
            // 
            // txtSoldDu
            // 
            this.txtSoldDu.Location = new System.Drawing.Point(328, 192);
            this.txtSoldDu.Name = "txtSoldDu";
            this.txtSoldDu.Size = new System.Drawing.Size(126, 22);
            this.txtSoldDu.TabIndex = 5;
            // 
            // txtDateExp
            // 
            this.txtDateExp.Location = new System.Drawing.Point(136, 192);
            this.txtDateExp.Name = "txtDateExp";
            this.txtDateExp.Size = new System.Drawing.Size(100, 22);
            this.txtDateExp.TabIndex = 5;
            // 
            // txtTypCart
            // 
            this.txtTypCart.Location = new System.Drawing.Point(117, 151);
            this.txtTypCart.Name = "txtTypCart";
            this.txtTypCart.Size = new System.Drawing.Size(152, 22);
            this.txtTypCart.TabIndex = 5;
            // 
            // txtNoCart
            // 
            this.txtNoCart.Location = new System.Drawing.Point(306, 108);
            this.txtNoCart.Name = "txtNoCart";
            this.txtNoCart.Size = new System.Drawing.Size(148, 22);
            this.txtNoCart.TabIndex = 5;
            // 
            // txtNoTel
            // 
            this.txtNoTel.Location = new System.Drawing.Point(89, 108);
            this.txtNoTel.Name = "txtNoTel";
            this.txtNoTel.Size = new System.Drawing.Size(128, 22);
            this.txtNoTel.TabIndex = 5;
            // 
            // txtAdrss
            // 
            this.txtAdrss.Location = new System.Drawing.Point(89, 58);
            this.txtAdrss.Name = "txtAdrss";
            this.txtAdrss.Size = new System.Drawing.Size(365, 22);
            this.txtAdrss.TabIndex = 5;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(285, 14);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(169, 22);
            this.txtNom.TabIndex = 5;
            // 
            // txtNoCli
            // 
            this.txtNoCli.Location = new System.Drawing.Point(89, 15);
            this.txtNoCli.Name = "txtNoCli";
            this.txtNoCli.Size = new System.Drawing.Size(114, 22);
            this.txtNoCli.TabIndex = 5;
            // 
            // lbNom
            // 
            this.lbNom.AutoSize = true;
            this.lbNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNom.Location = new System.Drawing.Point(224, 18);
            this.lbNom.Name = "lbNom";
            this.lbNom.Size = new System.Drawing.Size(45, 17);
            this.lbNom.TabIndex = 6;
            this.lbNom.Text = "Nom :";
            // 
            // lbNoCli
            // 
            this.lbNoCli.AutoSize = true;
            this.lbNoCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNoCli.Location = new System.Drawing.Point(7, 18);
            this.lbNoCli.Name = "lbNoCli";
            this.lbNoCli.Size = new System.Drawing.Size(77, 17);
            this.lbNoCli.TabIndex = 6;
            this.lbNoCli.Text = "No. Client :";
            // 
            // lbNoTel
            // 
            this.lbNoTel.AutoSize = true;
            this.lbNoTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNoTel.Location = new System.Drawing.Point(3, 108);
            this.lbNoTel.Name = "lbNoTel";
            this.lbNoTel.Size = new System.Drawing.Size(84, 17);
            this.lbNoTel.TabIndex = 6;
            this.lbNoTel.Text = "Telephone :";
            // 
            // lbAdrss
            // 
            this.lbAdrss.AutoSize = true;
            this.lbAdrss.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAdrss.Location = new System.Drawing.Point(7, 58);
            this.lbAdrss.Name = "lbAdrss";
            this.lbAdrss.Size = new System.Drawing.Size(68, 17);
            this.lbAdrss.TabIndex = 6;
            this.lbAdrss.Text = "Adresse :";
            // 
            // lbNoCart
            // 
            this.lbNoCart.AutoSize = true;
            this.lbNoCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNoCart.Location = new System.Drawing.Point(224, 108);
            this.lbNoCart.Name = "lbNoCart";
            this.lbNoCart.Size = new System.Drawing.Size(76, 17);
            this.lbNoCart.TabIndex = 6;
            this.lbNoCart.Text = "No. Carte :";
            // 
            // lbTypCart
            // 
            this.lbTypCart.AutoSize = true;
            this.lbTypCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTypCart.Location = new System.Drawing.Point(7, 154);
            this.lbTypCart.Name = "lbTypCart";
            this.lbTypCart.Size = new System.Drawing.Size(104, 17);
            this.lbTypCart.TabIndex = 6;
            this.lbTypCart.Text = "Type de carte :";
            // 
            // lbSoldeDu
            // 
            this.lbSoldeDu.AutoSize = true;
            this.lbSoldeDu.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSoldeDu.Location = new System.Drawing.Point(249, 192);
            this.lbSoldeDu.Name = "lbSoldeDu";
            this.lbSoldeDu.Size = new System.Drawing.Size(72, 17);
            this.lbSoldeDu.TabIndex = 6;
            this.lbSoldeDu.Text = "Solde dû :";
            // 
            // lbDateExp
            // 
            this.lbDateExp.AutoSize = true;
            this.lbDateExp.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDateExp.Location = new System.Drawing.Point(7, 189);
            this.lbDateExp.Name = "lbDateExp";
            this.lbDateExp.Size = new System.Drawing.Size(122, 17);
            this.lbDateExp.TabIndex = 6;
            this.lbDateExp.Text = "Date d\'expiration :";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtDateDeb);
            this.panel2.Controls.Add(this.txtDateFin);
            this.panel2.Controls.Add(this.txtReservle);
            this.panel2.Controls.Add(this.txtNoReserv);
            this.panel2.Controls.Add(this.lbDateFin);
            this.panel2.Controls.Add(this.lbDateDeb);
            this.panel2.Controls.Add(this.lbReservle);
            this.panel2.Controls.Add(this.lbNoReserv);
            this.panel2.Location = new System.Drawing.Point(513, 211);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(319, 225);
            this.panel2.TabIndex = 7;
            // 
            // txtDateDeb
            // 
            this.txtDateDeb.Location = new System.Drawing.Point(178, 122);
            this.txtDateDeb.Name = "txtDateDeb";
            this.txtDateDeb.Size = new System.Drawing.Size(100, 22);
            this.txtDateDeb.TabIndex = 5;
            // 
            // txtDateFin
            // 
            this.txtDateFin.Location = new System.Drawing.Point(178, 170);
            this.txtDateFin.Name = "txtDateFin";
            this.txtDateFin.Size = new System.Drawing.Size(100, 22);
            this.txtDateFin.TabIndex = 5;
            // 
            // txtReservle
            // 
            this.txtReservle.Location = new System.Drawing.Point(178, 77);
            this.txtReservle.Name = "txtReservle";
            this.txtReservle.Size = new System.Drawing.Size(100, 22);
            this.txtReservle.TabIndex = 5;
            // 
            // txtNoReserv
            // 
            this.txtNoReserv.Location = new System.Drawing.Point(178, 31);
            this.txtNoReserv.Name = "txtNoReserv";
            this.txtNoReserv.Size = new System.Drawing.Size(100, 22);
            this.txtNoReserv.TabIndex = 5;
            // 
            // lbDateFin
            // 
            this.lbDateFin.AutoSize = true;
            this.lbDateFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDateFin.Location = new System.Drawing.Point(31, 170);
            this.lbDateFin.Name = "lbDateFin";
            this.lbDateFin.Size = new System.Drawing.Size(85, 17);
            this.lbDateFin.TabIndex = 6;
            this.lbDateFin.Text = "Date de fin :";
            // 
            // lbDateDeb
            // 
            this.lbDateDeb.AutoSize = true;
            this.lbDateDeb.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDateDeb.Location = new System.Drawing.Point(31, 122);
            this.lbDateDeb.Name = "lbDateDeb";
            this.lbDateDeb.Size = new System.Drawing.Size(106, 17);
            this.lbDateDeb.TabIndex = 6;
            this.lbDateDeb.Text = "Date de début :";
            // 
            // lbReservle
            // 
            this.lbReservle.AutoSize = true;
            this.lbReservle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbReservle.Location = new System.Drawing.Point(31, 77);
            this.lbReservle.Name = "lbReservle";
            this.lbReservle.Size = new System.Drawing.Size(84, 17);
            this.lbReservle.TabIndex = 6;
            this.lbReservle.Text = "Réservé le :";
            // 
            // lbNoReserv
            // 
            this.lbNoReserv.AutoSize = true;
            this.lbNoReserv.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNoReserv.Location = new System.Drawing.Point(31, 31);
            this.lbNoReserv.Name = "lbNoReserv";
            this.lbNoReserv.Size = new System.Drawing.Size(118, 17);
            this.lbNoReserv.TabIndex = 6;
            this.lbNoReserv.Text = "No. Réservation :";
            // 
            // TAres
            // 
            this.TAres.ClearBeforeFill = true;
            // 
            // TAcli
            // 
            this.TAcli.ClearBeforeFill = true;
            // 
            // TAde
            // 
            this.TAde.ClearBeforeFill = true;
            // 
            // TAcha
            // 
            this.TAcha.ClearBeforeFill = true;
            // 
            // TAarr
            // 
            this.TAarr.ClearBeforeFill = true;
            // 
            // TAdep
            // 
            this.TAdep.ClearBeforeFill = true;
            // 
            // TAtrx
            // 
            this.TAtrx.ClearBeforeFill = true;
            // 
            // TAtypc
            // 
            this.TAtypc.ClearBeforeFill = true;
            // 
            // dsReservation
            // 
            this.dsReservation.DataSetName = "dsReservation";
            this.dsReservation.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // formReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 603);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "formReservation";
            this.Load += new System.EventHandler(this.formReservation_Load);
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
            ((System.ComponentModel.ISupportInitialize)(this.picLogo1)).EndInit();
            this.panTitre.ResumeLayout(false);
            this.panTitre.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BScli)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSde)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BScha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSarr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSdep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BStrx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BStypc)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsReservation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private dsReservationTableAdapters.RESERVATIONTableAdapter TAres;
        private dsReservationTableAdapters.CLIENTTableAdapter TAcli;
        private dsReservationTableAdapters.DETableAdapter TAde;
        private dsReservationTableAdapters.CHAMBRETableAdapter TAcha;
        private dsReservationTableAdapters.ARRIVETableAdapter TAarr;
        private dsReservationTableAdapters.DEPARTTableAdapter TAdep;
        private dsReservationTableAdapters.TRXTableAdapter TAtrx;
        private dsReservationTableAdapters.TYPECHAMTableAdapter TAtypc;
        private dsReservation dsReservation;
        private System.Windows.Forms.BindingSource BSres;
        private System.Windows.Forms.BindingSource BScli;
        private System.Windows.Forms.BindingSource BSde;
        private System.Windows.Forms.BindingSource BScha;
        private System.Windows.Forms.BindingSource BSarr;
        private System.Windows.Forms.BindingSource BSdep;
        private System.Windows.Forms.BindingSource BStrx;
        private System.Windows.Forms.BindingSource BStypc;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private prGraphiques.lbInfo lbNoCli;
        private prGraphiques.lbInfo lbNom;
        private prGraphiques.lbInfo lbNoTel;
        private prGraphiques.lbInfo lbAdrss;
        private prGraphiques.lbInfo lbTypCart;
        private prGraphiques.lbInfo lbDateExp;
        private prGraphiques.lbInfo lbSoldeDu;
        private prGraphiques.lbInfo lbNoCart;
        private prGraphiques.lbInfo lbDateFin;
        private prGraphiques.lbInfo lbDateDeb;
        private prGraphiques.lbInfo lbReservle;
        private prGraphiques.lbInfo lbNoReserv;
        private prGraphiques.txtInfo txtSoldDu;
        private prGraphiques.txtInfo txtDateExp;
        private prGraphiques.txtInfo txtTypCart;
        private prGraphiques.txtInfo txtNoCart;
        private prGraphiques.txtInfo txtNoTel;
        private prGraphiques.txtInfo txtAdrss;
        private prGraphiques.txtInfo txtNom;
        private prGraphiques.txtInfo txtNoCli;
        private prGraphiques.txtInfo txtDateFin;
        private prGraphiques.txtInfo txtReservle;
        private prGraphiques.txtInfo txtNoReserv;
        private prGraphiques.txtInfo txtDateDeb;
    }
}

