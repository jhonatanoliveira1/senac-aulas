using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppTatoo
{
    public partial class frm_Principal : Form
    {
        public frm_Principal()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tim_Principal_Tick(object sender, EventArgs e)
        {
            tsslabel_DataSys.Text = DateTime.Now.ToString("dd/MM/yyyy");
            tsslabel_HoraSys.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void especialidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Especialidade obj_frm_Especialidade = new frm_Especialidade();
            obj_frm_Especialidade.ShowDialog();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Cliente obj_frm_Cliente = new frm_Cliente();
            obj_frm_Cliente.ShowDialog();
        }

        private void turnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Turno obj_frm_Turno = new frm_Turno();
            obj_frm_Turno.ShowDialog();
        }

        private void tatuadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Tatuador obj_frm_Tatuador = new frm_Tatuador();
            obj_frm_Tatuador.ShowDialog();
        }

        private void temaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Tema obj_frm_Tema = new frm_Tema();
            obj_frm_Tema.ShowDialog();
        }

        private void tatuagemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Tatuagem obj_frm_Tatuagem = new frm_Tatuagem();
            obj_frm_Tatuagem.ShowDialog();
        }
    }
}
