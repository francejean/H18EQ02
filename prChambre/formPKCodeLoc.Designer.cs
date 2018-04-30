namespace prChambre
{
    partial class formPKCodeLoc
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
            this.dgCodeLoc = new System.Windows.Forms.DataGridView();
            this.codLocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descLocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lOCALISATIONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsChambre = new prChambre.dsChambre();
            this.lOCALISATIONTableAdapter = new prChambre.dsChambreTableAdapters.LOCALISATIONTableAdapter();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgCodeLoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOCALISATIONBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsChambre)).BeginInit();
            this.SuspendLayout();
            // 
            // dgCodeLoc
            // 
            this.dgCodeLoc.AllowUserToAddRows = false;
            this.dgCodeLoc.AllowUserToDeleteRows = false;
            this.dgCodeLoc.AutoGenerateColumns = false;
            this.dgCodeLoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCodeLoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codLocDataGridViewTextBoxColumn,
            this.descLocDataGridViewTextBoxColumn});
            this.dgCodeLoc.DataSource = this.lOCALISATIONBindingSource;
            this.dgCodeLoc.Location = new System.Drawing.Point(13, 13);
            this.dgCodeLoc.Name = "dgCodeLoc";
            this.dgCodeLoc.ReadOnly = true;
            this.dgCodeLoc.RowTemplate.Height = 24;
            this.dgCodeLoc.Size = new System.Drawing.Size(678, 355);
            this.dgCodeLoc.TabIndex = 0;
            // 
            // codLocDataGridViewTextBoxColumn
            // 
            this.codLocDataGridViewTextBoxColumn.DataPropertyName = "CodLoc";
            this.codLocDataGridViewTextBoxColumn.HeaderText = "CodLoc";
            this.codLocDataGridViewTextBoxColumn.Name = "codLocDataGridViewTextBoxColumn";
            this.codLocDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descLocDataGridViewTextBoxColumn
            // 
            this.descLocDataGridViewTextBoxColumn.DataPropertyName = "DescLoc";
            this.descLocDataGridViewTextBoxColumn.HeaderText = "DescLoc";
            this.descLocDataGridViewTextBoxColumn.Name = "descLocDataGridViewTextBoxColumn";
            this.descLocDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lOCALISATIONBindingSource
            // 
            this.lOCALISATIONBindingSource.DataMember = "LOCALISATION";
            this.lOCALISATIONBindingSource.DataSource = this.dsChambre;
            // 
            // dsChambre
            // 
            this.dsChambre.DataSetName = "dsChambre";
            this.dsChambre.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lOCALISATIONTableAdapter
            // 
            this.lOCALISATIONTableAdapter.ClearBeforeFill = true;
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(13, 374);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(326, 47);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(345, 374);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(347, 47);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // formPKCodeLoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 433);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.dgCodeLoc);
            this.MaximumSize = new System.Drawing.Size(721, 480);
            this.MinimumSize = new System.Drawing.Size(721, 480);
            this.Name = "formPKCodeLoc";
            this.Text = "formPKCodeLoc";
            this.Load += new System.EventHandler(this.formPKCodeLoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgCodeLoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOCALISATIONBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsChambre)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgCodeLoc;
        private dsChambre dsChambre;
        private System.Windows.Forms.BindingSource lOCALISATIONBindingSource;
        private dsChambreTableAdapters.LOCALISATIONTableAdapter lOCALISATIONTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codLocDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descLocDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
    }
}