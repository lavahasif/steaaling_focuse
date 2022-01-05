using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form2 : Form
    {
        Form3 c;
        public Form2()
        {
            InitializeComponent();
             c = new Form3();
        }

        private void textchanged(object sender, EventArgs e)
        {
            //c = new Form3();
            //c.MdiParent = this.MdiParent;
            c.ResetText(textBox1.Text.ToString());
            c.Location = new Point(this.Location.X+150, this.Location.Y);
            c .Show();
            //this.Focus();
        }


       
    }
}
