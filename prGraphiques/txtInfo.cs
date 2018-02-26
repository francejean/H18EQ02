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
    public partial class txtInfo : TextBox
    {
        public txtInfo()
        {
            InitializeComponent();
            this.Location = new System.Drawing.Point(150, 26);
            this.Name = "textBox1";
            this.Size = new System.Drawing.Size(100, 22);
            this.TabIndex = 5;
        }
    }
}
