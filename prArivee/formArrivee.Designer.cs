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
            this.SuspendLayout();
            // 
            // lbTitre
            // 
            this.lbTitre.Location = new System.Drawing.Point(133, 16);
            this.lbTitre.Size = new System.Drawing.Size(414, 39);
            this.lbTitre.Text = "Gestion des arrivées";
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
            // txtNoArr
            // 
            this.txtNoArr.Location = new System.Drawing.Point(477, 349);
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
            this.Name = "formArrivee";
            this.Load += new System.EventHandler(this.formArrivee_Load);
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
        private prGraphiques.txtInfo txtNoArr;
    }
}

