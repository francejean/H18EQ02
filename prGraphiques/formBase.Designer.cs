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
            this.picLogo1 = new System.Windows.Forms.PictureBox();
            this.panTitre = new System.Windows.Forms.Panel();
            this.picLogo2 = new System.Windows.Forms.PictureBox();
            this.btnAction4 = new prGraphiques.btnAction();
            this.btnAction3 = new prGraphiques.btnAction();
            this.btnAction2 = new prGraphiques.btnAction();
            this.btnAction1 = new prGraphiques.btnAction();
            this.lbHeure = new prGraphiques.lbDateHeure();
            this.lbDate = new prGraphiques.lbDateHeure();
            this.btnReserv = new prGraphiques.btnNewform();
            this.btnChambre = new prGraphiques.btnNewform();
            this.btnArrivee = new prGraphiques.btnNewform();
            this.btnDepart = new prGraphiques.btnNewform();
            this.btnQuit = new prGraphiques.btnNewform();
            this.lbTitre = new prGraphiques.lbTitre();
            this.btnNav1 = new prGraphiques.btnNavigation();
            this.btnNav2 = new prGraphiques.btnNavigation();
            this.btnNav3 = new prGraphiques.btnNavigation();
            this.btnNav4 = new prGraphiques.btnNavigation();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo1)).BeginInit();
            this.panTitre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo2)).BeginInit();
            this.SuspendLayout();
            // 
            // picLogo1
            // 
            this.picLogo1.Image = global::prGraphiques.Properties.Resources.logo;
            this.picLogo1.Location = new System.Drawing.Point(0, 0);
            this.picLogo1.Name = "picLogo1";
            this.picLogo1.Size = new System.Drawing.Size(150, 150);
            this.picLogo1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo1.TabIndex = 0;
            this.picLogo1.TabStop = false;
            // 
            // panTitre
            // 
            this.panTitre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(255)))), ((int)(((byte)(161)))));
            this.panTitre.Controls.Add(this.lbTitre);
            this.panTitre.Location = new System.Drawing.Point(150, 80);
            this.panTitre.Name = "panTitre";
            this.panTitre.Size = new System.Drawing.Size(682, 70);
            this.panTitre.TabIndex = 4;
            // 
            // picLogo2
            // 
            this.picLogo2.Image = global::prGraphiques.Properties.Resources.logo;
            this.picLogo2.Location = new System.Drawing.Point(832, 0);
            this.picLogo2.Name = "picLogo2";
            this.picLogo2.Size = new System.Drawing.Size(150, 150);
            this.picLogo2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo2.TabIndex = 5;
            this.picLogo2.TabStop = false;
            // 
            // btnAction4
            // 
            this.btnAction4.Image = global::prGraphiques.Properties.Resources.list;
            this.btnAction4.Location = new System.Drawing.Point(916, 435);
            this.btnAction4.Name = "btnAction4";
            this.btnAction4.Size = new System.Drawing.Size(50, 50);
            this.btnAction4.TabIndex = 1;
            this.btnAction4.UseVisualStyleBackColor = true;
            // 
            // btnAction3
            // 
            this.btnAction3.Image = global::prGraphiques.Properties.Resources.edit;
            this.btnAction3.Location = new System.Drawing.Point(848, 435);
            this.btnAction3.Name = "btnAction3";
            this.btnAction3.Size = new System.Drawing.Size(50, 50);
            this.btnAction3.TabIndex = 1;
            this.btnAction3.UseVisualStyleBackColor = true;
            // 
            // btnAction2
            // 
            this.btnAction2.Image = global::prGraphiques.Properties.Resources.minus;
            this.btnAction2.Location = new System.Drawing.Point(916, 367);
            this.btnAction2.Name = "btnAction2";
            this.btnAction2.Size = new System.Drawing.Size(50, 50);
            this.btnAction2.TabIndex = 1;
            this.btnAction2.UseVisualStyleBackColor = true;
            // 
            // btnAction1
            // 
            this.btnAction1.Image = global::prGraphiques.Properties.Resources.plus;
            this.btnAction1.Location = new System.Drawing.Point(848, 367);
            this.btnAction1.Name = "btnAction1";
            this.btnAction1.Size = new System.Drawing.Size(50, 50);
            this.btnAction1.TabIndex = 1;
            this.btnAction1.UseVisualStyleBackColor = true;
            // 
            // lbHeure
            // 
            this.lbHeure.AutoSize = true;
            this.lbHeure.Font = new System.Drawing.Font("Rockwell Condensed", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHeure.Location = new System.Drawing.Point(660, 25);
            this.lbHeure.Name = "lbHeure";
            this.lbHeure.Size = new System.Drawing.Size(97, 33);
            this.lbHeure.TabIndex = 3;
            this.lbHeure.Text = "HH:MM";
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Font = new System.Drawing.Font("Rockwell Condensed", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDate.Location = new System.Drawing.Point(225, 25);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(167, 33);
            this.lbDate.TabIndex = 3;
            this.lbDate.Text = "YYYY-MM-DD";
            // 
            // btnReserv
            // 
            this.btnReserv.Font = new System.Drawing.Font("Rockwell Condensed", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReserv.Location = new System.Drawing.Point(848, 175);
            this.btnReserv.Name = "btnReserv";
            this.btnReserv.Size = new System.Drawing.Size(118, 30);
            this.btnReserv.TabIndex = 2;
            this.btnReserv.Text = "Réservations";
            this.btnReserv.UseVisualStyleBackColor = true;
            // 
            // btnChambre
            // 
            this.btnChambre.Font = new System.Drawing.Font("Rockwell Condensed", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChambre.Location = new System.Drawing.Point(848, 223);
            this.btnChambre.Name = "btnChambre";
            this.btnChambre.Size = new System.Drawing.Size(118, 30);
            this.btnChambre.TabIndex = 2;
            this.btnChambre.Text = "Chambres";
            this.btnChambre.UseVisualStyleBackColor = true;
            // 
            // btnArrivee
            // 
            this.btnArrivee.Font = new System.Drawing.Font("Rockwell Condensed", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArrivee.Location = new System.Drawing.Point(848, 271);
            this.btnArrivee.Name = "btnArrivee";
            this.btnArrivee.Size = new System.Drawing.Size(118, 30);
            this.btnArrivee.TabIndex = 2;
            this.btnArrivee.Text = "Arrivées";
            this.btnArrivee.UseVisualStyleBackColor = true;
            // 
            // btnDepart
            // 
            this.btnDepart.Font = new System.Drawing.Font("Rockwell Condensed", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDepart.Location = new System.Drawing.Point(848, 319);
            this.btnDepart.Name = "btnDepart";
            this.btnDepart.Size = new System.Drawing.Size(118, 30);
            this.btnDepart.TabIndex = 2;
            this.btnDepart.Text = "Départs";
            this.btnDepart.UseVisualStyleBackColor = true;
            // 
            // btnQuit
            // 
            this.btnQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuit.Location = new System.Drawing.Point(848, 547);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(118, 30);
            this.btnQuit.TabIndex = 2;
            this.btnQuit.Text = "Quitter";
            this.btnQuit.UseVisualStyleBackColor = true;
            // 
            // lbTitre
            // 
            this.lbTitre.AutoSize = true;
            this.lbTitre.Font = new System.Drawing.Font("Rockwell Extra Bold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitre.Location = new System.Drawing.Point(255, 16);
            this.lbTitre.Name = "lbTitre";
            this.lbTitre.Size = new System.Drawing.Size(173, 39);
            this.lbTitre.TabIndex = 4;
            this.lbTitre.Text = "lbTitre1";
            this.lbTitre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNav1
            // 
            this.btnNav1.Image = global::prGraphiques.Properties.Resources.first_arrow;
            this.btnNav1.Location = new System.Drawing.Point(848, 503);
            this.btnNav1.Name = "btnNav1";
            this.btnNav1.Size = new System.Drawing.Size(25, 25);
            this.btnNav1.TabIndex = 0;
            this.btnNav1.UseVisualStyleBackColor = true;
            // 
            // btnNav2
            // 
            this.btnNav2.Image = global::prGraphiques.Properties.Resources.prev_arrow;
            this.btnNav2.Location = new System.Drawing.Point(879, 503);
            this.btnNav2.Name = "btnNav2";
            this.btnNav2.Size = new System.Drawing.Size(25, 25);
            this.btnNav2.TabIndex = 3;
            this.btnNav2.UseVisualStyleBackColor = true;
            // 
            // btnNav3
            // 
            this.btnNav3.Image = global::prGraphiques.Properties.Resources.next_arrow;
            this.btnNav3.Location = new System.Drawing.Point(910, 503);
            this.btnNav3.Name = "btnNav3";
            this.btnNav3.Size = new System.Drawing.Size(25, 25);
            this.btnNav3.TabIndex = 2;
            this.btnNav3.UseVisualStyleBackColor = true;
            // 
            // btnNav4
            // 
            this.btnNav4.Image = global::prGraphiques.Properties.Resources.last_arrrow;
            this.btnNav4.Location = new System.Drawing.Point(941, 503);
            this.btnNav4.Name = "btnNav4";
            this.btnNav4.Size = new System.Drawing.Size(25, 25);
            this.btnNav4.TabIndex = 1;
            this.btnNav4.UseVisualStyleBackColor = true;
            // 
            // formBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(255)))), ((int)(((byte)(200)))));
            this.ClientSize = new System.Drawing.Size(982, 603);
            this.Controls.Add(this.btnAction4);
            this.Controls.Add(this.btnAction3);
            this.Controls.Add(this.btnAction2);
            this.Controls.Add(this.btnAction1);
            this.Controls.Add(this.lbHeure);
            this.Controls.Add(this.lbDate);
            this.Controls.Add(this.btnReserv);
            this.Controls.Add(this.btnChambre);
            this.Controls.Add(this.btnArrivee);
            this.Controls.Add(this.btnDepart);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.picLogo1);
            this.Controls.Add(this.picLogo2);
            this.Controls.Add(this.panTitre);
            this.Controls.Add(this.btnNav1);
            this.Controls.Add(this.btnNav2);
            this.Controls.Add(this.btnNav3);
            this.Controls.Add(this.btnNav4);
            this.Name = "formBase";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picLogo1)).EndInit();
            this.panTitre.ResumeLayout(false);
            this.panTitre.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picLogo1;
        private btnNavigation btnNav1;
        private btnNavigation btnNav4;
        private btnNavigation btnNav3;
        private btnNavigation btnNav2;
        private System.Windows.Forms.Panel panTitre;
        private System.Windows.Forms.PictureBox picLogo2;
        private btnNewform btnQuit;
        private btnNewform btnDepart;
        private btnNewform btnArrivee;
        private btnNewform btnChambre;
        private btnNewform btnReserv;
        private lbDateHeure lbDate;
        private lbDateHeure lbHeure;
        private lbTitre lbTitre;
        private btnAction btnAction1;
        private btnAction btnAction2;
        private btnAction btnAction3;
        private btnAction btnAction4;
    }
}

