using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maths_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            int i1 = 3 * 4;
            int i2 = 12 / 4;
            double i3 = 15.0 / 4;
            double i4 = 15.0 % 4;
            int i5 = 2 + 3 * 4;
            int i6 = 2 + (3 * 4) / (2 - 4);
            double d1 = 3.1 * 2.3;
            double d2 = 1.0 / 3.0;
            double d3 = 1 / 3;
            double d4 = Math.Sqrt(49);
            double d5 = Math.Pow(5, 3);
            double d6 = Math.Pow(27, 1.0 / 3.0);

            richTextBox1.AppendText(i1 + "\n" + i2 + "\n" + i3 + "\n" + i4 + "\n" + i5 + "\n" + i6 + "\n");
            richTextBox1.AppendText(d1 + "\n" + d2 + "\n" + d3 + "\n");
            richTextBox1.AppendText(d4 + "\n" + d5 + "\n" + d6 + "\n");
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
