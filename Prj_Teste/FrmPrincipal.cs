using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.Framework.UI;

namespace PrjManut
{
    public partial class Frm_Principal : Form
    {
        public Frm_Principal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bntMenu_Click(object sender, EventArgs e)
        {
        //    if (sidemenu.Width == 50)
        //    {
        //        sidemenu.Visible = false;
        //        sidemenu.Width = 227;
        //        PanelAnimator.ShowSync(sidemenu);
        //        LogoAnimator.ShowSync(logo);
        //    }
        //    else
        //    {
        //        LogoAnimator.Hide(logo);
        //        sidemenu.Visible = false;
        //        sidemenu.Width = 50;
        //        PanelAnimator.ShowSync(sidemenu);
        //    }
        }
    }
}
