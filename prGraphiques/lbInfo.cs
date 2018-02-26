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
    public partial class lbInfo : Label
    {
        public lbInfo()
        {
            InitializeComponent();
            this.AutoSize = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Location = new System.Drawing.Point(163, 55);
            this.Name = "label3";
            this.Size = new System.Drawing.Size(42, 17);
            this.TabIndex = 6;
            this.Text = "lbInfo";
        }
    }
}
