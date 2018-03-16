namespace prChambre
{
    partial class formChambre
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
            this.TAde = new prChambre.dsChambreTableAdapters.DETableAdapter();
            this.TAres = new prChambre.dsChambreTableAdapters.RESERVATIONTableAdapter();
            this.TAcha = new prChambre.dsChambreTableAdapters.CHAMBRETableAdapter();
            this.TAaya = new prChambre.dsChambreTableAdapters.AYANTTableAdapter();
            this.TAtypc = new prChambre.dsChambreTableAdapters.TYPECHAMTableAdapter();
            this.TAloc = new prChambre.dsChambreTableAdapters.LOCALISATIONTableAdapter();
            this.dsChambre = new prChambre.dsChambre();
            this.BSde = new System.Windows.Forms.BindingSource(this.components);
            this.BSres = new System.Windows.Forms.BindingSource(this.components);
            this.BScha = new System.Windows.Forms.BindingSource(this.components);
            this.BSaya = new System.Windows.Forms.BindingSource(this.components);
            this.BStypc = new System.Windows.Forms.BindingSource(this.components);
            this.BSloc = new System.Windows.Forms.BindingSource(this.components);
            this.txtNoCham = new prGraphiques.txtInfo();
            this.lbNoCham = new prGraphiques.lbInfo();
            this.txtEtage = new prGraphiques.txtInfo();
            this.txtEtat = new prGraphiques.txtInfo();
            this.txtCodeType = new prGraphiques.txtInfo();
            this.txtCodeLoc = new prGraphiques.txtInfo();
            this.txtPrix = new prGraphiques.txtInfo();
            this.txtMemo = new prGraphiques.txtInfo();
            this.txtLocDesc = new prGraphiques.txtInfo();
            this.txtTypeDesc = new prGraphiques.txtInfo();
            this.lbEtage = new prGraphiques.lbInfo();
            this.lbEtat = new prGraphiques.lbInfo();
            this.lbCodeType = new prGraphiques.lbInfo();
            this.lbCodeLoc = new prGraphiques.lbInfo();
            this.lbPrix = new prGraphiques.lbInfo();
            this.lbTypeDesc = new prGraphiques.lbInfo();
            this.lbLocDesc = new prGraphiques.lbInfo();
            this.lbMemo = new prGraphiques.lbInfo();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo1)).BeginInit();
            this.panTitre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsChambre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSde)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BScha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSaya)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BStypc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSloc)).BeginInit();
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
            this.lbTitre.Location = new System.Drawing.Point(130, 16);
            this.lbTitre.Size = new System.Drawing.Size(453, 39);
            this.lbTitre.Text = "Gestion des chambres";
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
            // TAde
            // 
            this.TAde.ClearBeforeFill = true;
            // 
            // TAres
            // 
            this.TAres.ClearBeforeFill = true;
            // 
            // TAcha
            // 
            this.TAcha.ClearBeforeFill = true;
            // 
            // TAaya
            // 
            this.TAaya.ClearBeforeFill = true;
            // 
            // TAtypc
            // 
            this.TAtypc.ClearBeforeFill = true;
            // 
            // TAloc
            // 
            this.TAloc.ClearBeforeFill = true;
            // 
            // dsChambre
            // 
            this.dsChambre.DataSetName = "dsChambre";
            this.dsChambre.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtNoCham
            // 
            this.txtNoCham.Location = new System.Drawing.Point(133, 196);
            this.txtNoCham.Name = "txtNoCham";
            this.txtNoCham.Size = new System.Drawing.Size(65, 22);
            this.txtNoCham.TabIndex = 5;
            // 
            // lbNoCham
            // 
            this.lbNoCham.AutoSize = true;
            this.lbNoCham.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNoCham.Location = new System.Drawing.Point(32, 199);
            this.lbNoCham.Name = "lbNoCham";
            this.lbNoCham.Size = new System.Drawing.Size(95, 17);
            this.lbNoCham.TabIndex = 6;
            this.lbNoCham.Text = "No. Chambre:";
            // 
            // txtEtage
            // 
            this.txtEtage.Location = new System.Drawing.Point(133, 239);
            this.txtEtage.Name = "txtEtage";
            this.txtEtage.Size = new System.Drawing.Size(49, 22);
            this.txtEtage.TabIndex = 5;
            // 
            // txtEtat
            // 
            this.txtEtat.Location = new System.Drawing.Point(133, 278);
            this.txtEtat.Name = "txtEtat";
            this.txtEtat.Size = new System.Drawing.Size(100, 22);
            this.txtEtat.TabIndex = 5;
            // 
            // txtCodeType
            // 
            this.txtCodeType.Location = new System.Drawing.Point(387, 196);
            this.txtCodeType.Name = "txtCodeType";
            this.txtCodeType.Size = new System.Drawing.Size(34, 22);
            this.txtCodeType.TabIndex = 5;
            // 
            // txtCodeLoc
            // 
            this.txtCodeLoc.Location = new System.Drawing.Point(387, 239);
            this.txtCodeLoc.Name = "txtCodeLoc";
            this.txtCodeLoc.Size = new System.Drawing.Size(34, 22);
            this.txtCodeLoc.TabIndex = 5;
            // 
            // txtPrix
            // 
            this.txtPrix.Location = new System.Drawing.Point(321, 278);
            this.txtPrix.Name = "txtPrix";
            this.txtPrix.Size = new System.Drawing.Size(100, 22);
            this.txtPrix.TabIndex = 5;
            // 
            // txtMemo
            // 
            this.txtMemo.Location = new System.Drawing.Point(505, 278);
            this.txtMemo.Name = "txtMemo";
            this.txtMemo.Size = new System.Drawing.Size(327, 22);
            this.txtMemo.TabIndex = 5;
            // 
            // txtLocDesc
            // 
            this.txtLocDesc.Location = new System.Drawing.Point(539, 239);
            this.txtLocDesc.Name = "txtLocDesc";
            this.txtLocDesc.Size = new System.Drawing.Size(293, 22);
            this.txtLocDesc.TabIndex = 5;
            // 
            // txtTypeDesc
            // 
            this.txtTypeDesc.Location = new System.Drawing.Point(539, 196);
            this.txtTypeDesc.Name = "txtTypeDesc";
            this.txtTypeDesc.Size = new System.Drawing.Size(293, 22);
            this.txtTypeDesc.TabIndex = 5;
            // 
            // lbEtage
            // 
            this.lbEtage.AutoSize = true;
            this.lbEtage.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEtage.Location = new System.Drawing.Point(78, 242);
            this.lbEtage.Name = "lbEtage";
            this.lbEtage.Size = new System.Drawing.Size(49, 17);
            this.lbEtage.TabIndex = 6;
            this.lbEtage.Text = "Étage:";
            // 
            // lbEtat
            // 
            this.lbEtat.AutoSize = true;
            this.lbEtat.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEtat.Location = new System.Drawing.Point(89, 281);
            this.lbEtat.Name = "lbEtat";
            this.lbEtat.Size = new System.Drawing.Size(37, 17);
            this.lbEtat.TabIndex = 6;
            this.lbEtat.Text = "État:";
            // 
            // lbCodeType
            // 
            this.lbCodeType.AutoSize = true;
            this.lbCodeType.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCodeType.Location = new System.Drawing.Point(300, 199);
            this.lbCodeType.Name = "lbCodeType";
            this.lbCodeType.Size = new System.Drawing.Size(81, 17);
            this.lbCodeType.TabIndex = 6;
            this.lbCodeType.Text = "Code Type:";
            // 
            // lbCodeLoc
            // 
            this.lbCodeLoc.AutoSize = true;
            this.lbCodeLoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCodeLoc.Location = new System.Drawing.Point(257, 242);
            this.lbCodeLoc.Name = "lbCodeLoc";
            this.lbCodeLoc.Size = new System.Drawing.Size(124, 17);
            this.lbCodeLoc.TabIndex = 6;
            this.lbCodeLoc.Text = "Code Localisation:";
            // 
            // lbPrix
            // 
            this.lbPrix.AutoSize = true;
            this.lbPrix.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrix.Location = new System.Drawing.Point(280, 281);
            this.lbPrix.Name = "lbPrix";
            this.lbPrix.Size = new System.Drawing.Size(35, 17);
            this.lbPrix.TabIndex = 6;
            this.lbPrix.Text = "Prix:";
            // 
            // lbTypeDesc
            // 
            this.lbTypeDesc.AutoSize = true;
            this.lbTypeDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTypeDesc.Location = new System.Drawing.Point(450, 199);
            this.lbTypeDesc.Name = "lbTypeDesc";
            this.lbTypeDesc.Size = new System.Drawing.Size(83, 17);
            this.lbTypeDesc.TabIndex = 6;
            this.lbTypeDesc.Text = "Description:";
            // 
            // lbLocDesc
            // 
            this.lbLocDesc.AutoSize = true;
            this.lbLocDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLocDesc.Location = new System.Drawing.Point(450, 242);
            this.lbLocDesc.Name = "lbLocDesc";
            this.lbLocDesc.Size = new System.Drawing.Size(83, 17);
            this.lbLocDesc.TabIndex = 6;
            this.lbLocDesc.Text = "Description:";
            // 
            // lbMemo
            // 
            this.lbMemo.AutoSize = true;
            this.lbMemo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMemo.Location = new System.Drawing.Point(449, 281);
            this.lbMemo.Name = "lbMemo";
            this.lbMemo.Size = new System.Drawing.Size(50, 17);
            this.lbMemo.TabIndex = 6;
            this.lbMemo.Text = "Mémo:";
            // 
            // formChambre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 603);
            this.Controls.Add(this.lbTypeDesc);
            this.Controls.Add(this.lbLocDesc);
            this.Controls.Add(this.lbMemo);
            this.Controls.Add(this.lbPrix);
            this.Controls.Add(this.lbCodeLoc);
            this.Controls.Add(this.lbCodeType);
            this.Controls.Add(this.lbEtat);
            this.Controls.Add(this.lbEtage);
            this.Controls.Add(this.lbNoCham);
            this.Controls.Add(this.txtTypeDesc);
            this.Controls.Add(this.txtLocDesc);
            this.Controls.Add(this.txtMemo);
            this.Controls.Add(this.txtPrix);
            this.Controls.Add(this.txtCodeLoc);
            this.Controls.Add(this.txtCodeType);
            this.Controls.Add(this.txtEtat);
            this.Controls.Add(this.txtEtage);
            this.Controls.Add(this.txtNoCham);
            this.Name = "formChambre";
            this.Load += new System.EventHandler(this.formChambre_Load);
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
            this.Controls.SetChildIndex(this.txtNoCham, 0);
            this.Controls.SetChildIndex(this.txtEtage, 0);
            this.Controls.SetChildIndex(this.txtEtat, 0);
            this.Controls.SetChildIndex(this.txtCodeType, 0);
            this.Controls.SetChildIndex(this.txtCodeLoc, 0);
            this.Controls.SetChildIndex(this.txtPrix, 0);
            this.Controls.SetChildIndex(this.txtMemo, 0);
            this.Controls.SetChildIndex(this.txtLocDesc, 0);
            this.Controls.SetChildIndex(this.txtTypeDesc, 0);
            this.Controls.SetChildIndex(this.lbNoCham, 0);
            this.Controls.SetChildIndex(this.lbEtage, 0);
            this.Controls.SetChildIndex(this.lbEtat, 0);
            this.Controls.SetChildIndex(this.lbCodeType, 0);
            this.Controls.SetChildIndex(this.lbCodeLoc, 0);
            this.Controls.SetChildIndex(this.lbPrix, 0);
            this.Controls.SetChildIndex(this.lbMemo, 0);
            this.Controls.SetChildIndex(this.lbLocDesc, 0);
            this.Controls.SetChildIndex(this.lbTypeDesc, 0);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo1)).EndInit();
            this.panTitre.ResumeLayout(false);
            this.panTitre.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsChambre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSde)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BScha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSaya)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BStypc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSloc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private dsChambreTableAdapters.DETableAdapter TAde;
        private dsChambreTableAdapters.RESERVATIONTableAdapter TAres;
        private dsChambreTableAdapters.CHAMBRETableAdapter TAcha;
        private dsChambreTableAdapters.AYANTTableAdapter TAaya;
        private dsChambreTableAdapters.TYPECHAMTableAdapter TAtypc;
        private dsChambreTableAdapters.LOCALISATIONTableAdapter TAloc;
        private dsChambre dsChambre;
        private System.Windows.Forms.BindingSource BSde;
        private System.Windows.Forms.BindingSource BSres;
        private System.Windows.Forms.BindingSource BScha;
        private System.Windows.Forms.BindingSource BSaya;
        private System.Windows.Forms.BindingSource BStypc;
        private System.Windows.Forms.BindingSource BSloc;
        private prGraphiques.txtInfo txtNoCham;
        private prGraphiques.lbInfo lbNoCham;
        private prGraphiques.txtInfo txtEtage;
        private prGraphiques.txtInfo txtEtat;
        private prGraphiques.txtInfo txtCodeType;
        private prGraphiques.txtInfo txtCodeLoc;
        private prGraphiques.txtInfo txtPrix;
        private prGraphiques.txtInfo txtMemo;
        private prGraphiques.txtInfo txtLocDesc;
        private prGraphiques.txtInfo txtTypeDesc;
        private prGraphiques.lbInfo lbEtage;
        private prGraphiques.lbInfo lbEtat;
        private prGraphiques.lbInfo lbCodeType;
        private prGraphiques.lbInfo lbCodeLoc;
        private prGraphiques.lbInfo lbPrix;
        private prGraphiques.lbInfo lbTypeDesc;
        private prGraphiques.lbInfo lbLocDesc;
        private prGraphiques.lbInfo lbMemo;
    }
}

