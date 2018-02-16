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
    public partial class lbTitre : Label
    {
        public lbTitre()
        {
            InitializeComponent();
            this.AutoSize = true;
            this.Font = new System.Drawing.Font("Rockwell Extra Bold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Location = new System.Drawing.Point(100, 129);
            this.Name = "label2";
            this.Size = new System.Drawing.Size(156, 40);
            this.TabIndex = 4;
            this.Text = "lbTitre";
        }
    }
}
