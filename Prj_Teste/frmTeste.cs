using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using prjManut.Entidades;
using prjManut.Model;

namespace PrjManut
{
    public partial class frmTeste : Form
    {
        private NitgenUtils nUtils;
        private AlunoMODEL alunoMODEL;

        public frmTeste()
        {
            InitializeComponent();
            nUtils = new NitgenUtils();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            nUtils.CadastrarDigital();
          
        }
    }
}
