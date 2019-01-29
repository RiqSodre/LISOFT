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
            pnlCad.Visible = false;
        }

        //Botão - Fecha o Programa.
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Botão Menu - Início.
        private void btnHome_Click(object sender, EventArgs e)
        {
            pnlInicio.Visible = true;
            pnlCad.Visible = false;
            //pnlCon.Visible = false;
            //pnlHis.Visible = false;
        }

        //Botão Home - Cadastrar Aluno.
        private void btnCadAluno_Click(object sender, EventArgs e)
        {
            pnlInicio.Visible = false;
            pnlCad.Visible = true;
            //pnlCon.Visible = false;
            //pnlHis.Visible = false;
        }

        //Botão Home - Consultar Aluno.
        private void btnConsulta_Click(object sender, EventArgs e)
        {
            pnlInicio.Visible = false;
            pnlCad.Visible = true;
            //pnlCon.Visible = false;
            //pnlHis.Visible = false;
        }

        //Botão Home - Histórico de Empréstimos.
        private void btnHistorico_Click(object sender, EventArgs e)
        {
            pnlInicio.Visible = false;
            pnlCad.Visible = true;
            //pnlCon.Visible = false;
            //pnlHis.Visible = false;
        }
    }
}
