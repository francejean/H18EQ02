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
    public partial class btnNewform : Button
    {
        public btnNewform()
        {
            InitializeComponent();
            this.Font = new System.Drawing.Font("Rockwell Condensed", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Location = new System.Drawing.Point(43, 84);
            this.Name = "btnNewform";
            this.Size = new System.Drawing.Size(118, 30);
            this.TabIndex = 2;
            this.UseVisualStyleBackColor = true;
        }
    }
}
