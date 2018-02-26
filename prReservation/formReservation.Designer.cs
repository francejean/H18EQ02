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
            this.TAres = new prReservation.dsReservationTableAdapters.RESERVATIONTableAdapter();
            this.TAcli = new prReservation.dsReservationTableAdapters.CLIENTTableAdapter();
            this.TAde = new prReservation.dsReservationTableAdapters.DETableAdapter();
            this.TAcha = new prReservation.dsReservationTableAdapters.CHAMBRETableAdapter();
            this.TAarr = new prReservation.dsReservationTableAdapters.ARRIVETableAdapter();
            this.TAdep = new prReservation.dsReservationTableAdapters.DEPARTTableAdapter();
            this.TAtrx = new prReservation.dsReservationTableAdapters.TRXTableAdapter();
            this.TAtypc = new prReservation.dsReservationTableAdapters.TYPECHAMTableAdapter();
            this.dsReservation = new prReservation.dsReservation();
            this.BSres = new System.Windows.Forms.BindingSource(this.components);
            this.BScli = new System.Windows.Forms.BindingSource(this.components);
            this.BSde = new System.Windows.Forms.BindingSource(this.components);
            this.BScha = new System.Windows.Forms.BindingSource(this.components);
            this.BSarr = new System.Windows.Forms.BindingSource(this.components);
            this.BSdep = new System.Windows.Forms.BindingSource(this.components);
            this.BStrx = new System.Windows.Forms.BindingSource(this.components);
            this.BStypc = new System.Windows.Forms.BindingSource(this.components);
            this.txtNoRes = new prGraphiques.txtInfo();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo1)).BeginInit();
            this.panTitre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsReservation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BScli)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSde)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BScha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSarr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSdep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BStrx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BStypc)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNav3
            // 
            this.btnNav3.Click += new System.EventHandler(this.btnNav3_Click);
            // 
            // lbTitre
            // 
            this.lbTitre.Location = new System.Drawing.Point(100, 16);
            this.lbTitre.Size = new System.Drawing.Size(500, 39);
            this.lbTitre.Text = "Gestion des réservations";
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
            // txtNoRes
            // 
            this.txtNoRes.Location = new System.Drawing.Point(137, 280);
            this.txtNoRes.Name = "txtNoRes";
            this.txtNoRes.Size = new System.Drawing.Size(100, 22);
            this.txtNoRes.TabIndex = 5;
            // 
            // formReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 603);
            this.Controls.Add(this.txtNoRes);
            this.Name = "formReservation";
            this.Load += new System.EventHandler(this.formReservation_Load);
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
            this.Controls.SetChildIndex(this.txtNoRes, 0);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo1)).EndInit();
            this.panTitre.ResumeLayout(false);
            this.panTitre.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsReservation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BScli)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSde)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BScha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSarr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSdep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BStrx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BStypc)).EndInit();
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
        private prGraphiques.txtInfo txtNoRes;
    }
}

