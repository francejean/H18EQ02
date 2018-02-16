using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prGraphiques
{
    public partial class lbDateHeure : Label
    {
        public lbDateHeure()
        {
            InitializeComponent();
            this.AutoSize = true;
            this.Font = new System.Drawing.Font("Rockwell Condensed", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Location = new System.Drawing.Point(59, 181);
            this.Name = "label1";
            this.Size = new System.Drawing.Size(151, 33);
            this.TabIndex = 3;
            this.Text = "lbDateHeure";
        }
    }
}
