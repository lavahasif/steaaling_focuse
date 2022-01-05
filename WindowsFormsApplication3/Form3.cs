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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            //ShowWithoutActivation = false;
        }
        protected override bool ShowWithoutActivation
        {
            get { return true; }
        }

        //private const int WS_EX_TOPMOST = 0x00000008;

        internal void ResetText(string toString)
        {
            label2.Text = toString;
        }

        //protected override CreateParams CreateParams
        //{
        //    get
        //    {
        //        CreateParams createParams = base.CreateParams;
        //        createParams.ExStyle |= WS_EX_TOPMOST;
        //        return createParams;
        //    }
        //}
    }
}
