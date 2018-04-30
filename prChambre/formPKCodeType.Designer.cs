namespace prChambre
{
    partial class formPKCodeType
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
            this.dgCodeType = new System.Windows.Forms.DataGridView();
            this.codTypChamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descTypDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nbDispoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tYPECHAMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsChambre = new prChambre.dsChambre();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tYPECHAMTableAdapter = new prChambre.dsChambreTableAdapters.TYPECHAMTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgCodeType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tYPECHAMBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsChambre)).BeginInit();
            this.SuspendLayout();
            // 
            // dgCodeType
            // 
            this.dgCodeType.AllowUserToAddRows = false;
            this.dgCodeType.AllowUserToDeleteRows = false;
            this.dgCodeType.AutoGenerateColumns = false;
            this.dgCodeType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCodeType.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codTypChamDataGridViewTextBoxColumn,
            this.descTypDataGridViewTextBoxColumn,
            this.nbDispoDataGridViewTextBoxColumn});
            this.dgCodeType.DataSource = this.tYPECHAMBindingSource;
            this.dgCodeType.Location = new System.Drawing.Point(12, 12);
            this.dgCodeType.Name = "dgCodeType";
            this.dgCodeType.ReadOnly = true;
            this.dgCodeType.RowTemplate.Height = 24;
            this.dgCodeType.Size = new System.Drawing.Size(679, 356);
            this.dgCodeType.TabIndex = 0;
            // 
            // codTypChamDataGridViewTextBoxColumn
            // 
            this.codTypChamDataGridViewTextBoxColumn.DataPropertyName = "CodTypCham";
            this.codTypChamDataGridViewTextBoxColumn.HeaderText = "CodTypCham";
            this.codTypChamDataGridViewTextBoxColumn.Name = "codTypChamDataGridViewTextBoxColumn";
            this.codTypChamDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descTypDataGridViewTextBoxColumn
            // 
            this.descTypDataGridViewTextBoxColumn.DataPropertyName = "DescTyp";
            this.descTypDataGridViewTextBoxColumn.HeaderText = "DescTyp";
            this.descTypDataGridViewTextBoxColumn.Name = "descTypDataGridViewTextBoxColumn";
            this.descTypDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nbDispoDataGridViewTextBoxColumn
            // 
            this.nbDispoDataGridViewTextBoxColumn.DataPropertyName = "NbDispo";
            this.nbDispoDataGridViewTextBoxColumn.HeaderText = "NbDispo";
            this.nbDispoDataGridViewTextBoxColumn.Name = "nbDispoDataGridViewTextBoxColumn";
            this.nbDispoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tYPECHAMBindingSource
            // 
            this.tYPECHAMBindingSource.DataMember = "TYPECHAM";
            this.tYPECHAMBindingSource.DataSource = this.dsChambre;
            // 
            // dsChambre
            // 
            this.dsChambre.DataSetName = "dsChambre";
            this.dsChambre.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(12, 374);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(326, 47);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(344, 374);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(347, 47);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // tYPECHAMTableAdapter
            // 
            this.tYPECHAMTableAdapter.ClearBeforeFill = true;
            // 
            // formPKCodeType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 433);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.dgCodeType);
            this.MaximumSize = new System.Drawing.Size(721, 480);
            this.MinimumSize = new System.Drawing.Size(721, 480);
            this.Name = "formPKCodeType";
            this.Text = "formPKCodeType";
            this.Load += new System.EventHandler(this.formPKCodeType_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgCodeType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tYPECHAMBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsChambre)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgCodeType;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private dsChambre dsChambre;
        private System.Windows.Forms.BindingSource tYPECHAMBindingSource;
        private dsChambreTableAdapters.TYPECHAMTableAdapter tYPECHAMTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codTypChamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descTypDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nbDispoDataGridViewTextBoxColumn;
    }
}