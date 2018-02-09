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
    public partial class btnNavigation : Button
    {
        public btnNavigation()
        {
            InitializeComponent();
            this.Location = new System.Drawing.Point(12, 12);
            this.Name = "button1";
            this.Size = new System.Drawing.Size(25, 25);
            this.TabIndex = 0;
            this.Text = "btnNavigation";
            this.UseVisualStyleBackColor = true;
        }
    }
}
