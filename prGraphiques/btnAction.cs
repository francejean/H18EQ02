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
    public partial class btnAction : Button
    {
        public btnAction()
        {
            InitializeComponent();
            this.Location = new System.Drawing.Point(43, 12);
            this.Name = "btnAction";
            this.Size = new System.Drawing.Size(50, 50);
            this.TabIndex = 1;
            this.Text = "btnAction";
            this.UseVisualStyleBackColor = true;
        }
    }
}
