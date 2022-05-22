using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrvníOkenníAplikace
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        private void btnRnd_Click(object sender, EventArgs e)
        {
            this.BackColor = this.generateColor();
        }

        private void btnDef_Click(object sender, EventArgs e)
        {
            this.BackColor = DefaultBackColor;
            //this.BackColor = SystemColors.Control;
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private Color generateColor()
        {
            Random rnd = new Random();

            int r = rnd.Next(255);
            int g = rnd.Next(255);
            int b = rnd.Next(255);

            return Color.FromArgb(r, g, b);
        }

        private void Form_Load(object sender, EventArgs e)
        {
            btnRnd.Select();
        }
    }
}
