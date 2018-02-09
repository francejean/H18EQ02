namespace prGraphiques
{
    partial class formBase
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
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.btnNav1 = new prGraphiques.btnNavigation();
            this.btnNav4 = new prGraphiques.btnNavigation();
            this.btnNav3 = new prGraphiques.btnNavigation();
            this.btnNav2 = new prGraphiques.btnNavigation();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // picLogo
            // 
            this.picLogo.Image = global::prGraphiques.Properties.Resources.logo;
            this.picLogo.Location = new System.Drawing.Point(0, 0);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(100, 100);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // btnNav1
            // 
            this.btnNav1.Image = global::prGraphiques.Properties.Resources.first_arrow;
            this.btnNav1.Location = new System.Drawing.Point(501, 363);
            this.btnNav1.Name = "btnNav1";
            this.btnNav1.Size = new System.Drawing.Size(25, 25);
            this.btnNav1.TabIndex = 0;
            this.btnNav1.UseVisualStyleBackColor = true;
            // 
            // btnNav4
            // 
            this.btnNav4.Image = global::prGraphiques.Properties.Resources.last_arrrow;
            this.btnNav4.Location = new System.Drawing.Point(594, 363);
            this.btnNav4.Name = "btnNav4";
            this.btnNav4.Size = new System.Drawing.Size(25, 25);
            this.btnNav4.TabIndex = 1;
            this.btnNav4.UseVisualStyleBackColor = true;
            // 
            // btnNav3
            // 
            this.btnNav3.Image = global::prGraphiques.Properties.Resources.next_arrow;
            this.btnNav3.Location = new System.Drawing.Point(563, 363);
            this.btnNav3.Name = "btnNav3";
            this.btnNav3.Size = new System.Drawing.Size(25, 25);
            this.btnNav3.TabIndex = 2;
            this.btnNav3.UseVisualStyleBackColor = true;
            // 
            // btnNav2
            // 
            this.btnNav2.Image = global::prGraphiques.Properties.Resources.prev_arrow;
            this.btnNav2.Location = new System.Drawing.Point(532, 363);
            this.btnNav2.Name = "btnNav2";
            this.btnNav2.Size = new System.Drawing.Size(25, 25);
            this.btnNav2.TabIndex = 3;
            this.btnNav2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(255)))), ((int)(((byte)(161)))));
            this.panel1.Location = new System.Drawing.Point(100, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(782, 70);
            this.panel1.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::prGraphiques.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(882, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // formBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(255)))), ((int)(((byte)(200)))));
            this.ClientSize = new System.Drawing.Size(982, 603);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnNav1);
            this.Controls.Add(this.btnNav2);
            this.Controls.Add(this.btnNav3);
            this.Controls.Add(this.btnNav4);
            this.Controls.Add(this.picLogo);
            this.Name = "formBase";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picLogo;
        private btnNavigation btnNav1;
        private btnNavigation btnNav4;
        private btnNavigation btnNav3;
        private btnNavigation btnNav2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

