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
    public partial class frm_Tema : Form
    {

        FuncGeral obj_FuncGeral = new FuncGeral();
        Tema Tema_Principal = new Tema();

        public frm_Tema()
        {
            InitializeComponent();
            PopulaLista();
            obj_FuncGeral.StatusBtn(this, 1);
            obj_FuncGeral.HabilitaTela(this, false);
        }

        /**********************************************************************************
        * NOME:            PopulaLista
        * PROCEDIMENTO:    Preenche o ListBox com os dados que estão na TB_Tema
        * DT CRIAÇÃO:      02/12/2019
        * DT ALTERAÇÃO:    -
        * ESCRITA POR:     Mfacine (Monstro)
        * OBSERVAÇÕES:     
        * ********************************************************************************/
        private void PopulaLista()
        {
            // Instância do objeto TemaBD
            TemaBD obj_TemaBD = new TemaBD();

            // Instância do objeto Lista
            List<Tema> Lista = new List<Tema>();

            // Limpando o ListBox
            lbox_Temas.Items.Clear();

            Lista = obj_TemaBD.FindAllTema();

            if (Lista != null)
            {
                for (int i = 0; i <= Lista.Count - 1; i++)
                {
                    lbox_Temas.Items.Add(Lista[i].COD_TEMA.ToString() + "-" + Lista[i].TIT_TEMA);
                }
            }
        }

        private void lbox_Temas_Click(object sender, EventArgs e)
        {
            if (lbox_Temas.SelectedIndex != -1)
            {
                TemaBD obj_TemaBD = new TemaBD();

                string sLinha = lbox_Temas.Items[lbox_Temas.SelectedIndex].ToString();

                int ipos = 0;

                for (int t = 0; t <= sLinha.Length; t++)
                {
                    if (sLinha.Substring(t, 1) == "-")
                    {
                        ipos = t;
                        break;
                    }
                }

                Tema_Principal.COD_TEMA = Convert.ToInt16(sLinha.Substring(0, ipos));

                Tema_Principal = obj_TemaBD.FindByCodTema(Tema_Principal);

                PopulaTela(Tema_Principal);

                obj_FuncGeral.StatusBtn(this, 2);

            }
        }

        /**********************************************************************************
        * NOME:            PopulaTela
        * PROCEDIMENTO:    Preenche a tela com os dados do Objeto Principal
        * DT CRIAÇÃO:      02/12/2019
        * DT ALTERAÇÃO:    -
        * PARAMETRO:       
        * ESCRITA POR:     Mfacine (Monstro)
        * OBSERVAÇÕES:     
        * ********************************************************************************/
        private void PopulaTela(Tema aobj_Tema)
        {
            if (aobj_Tema.COD_TEMA != -1)
            {
                tbox_Cod_Tema.Text = aobj_Tema.COD_TEMA.ToString();
                tbox_Tit_Tema.Text = aobj_Tema.TIT_TEMA;
                tbox_Desc_Tema.Text = aobj_Tema.DESC_TEMA;
            }
        }


        /**********************************************************************************
        * NOME:            PopulaObjeto
        * PROCEDIMENTO:    Preenche o objeto com os dados da  tela 
        * DT CRIAÇÃO:      02/12/2019
        * DT ALTERAÇÃO:    -
        * PARAMETRO:       
        * ESCRITA POR:     Mfacine (Monstro)
        * OBSERVAÇÕES:     
        * ********************************************************************************/
        private Tema PopulaObjeto()
        {
            Tema aobj_Tema = new Tema();

            if (tbox_Cod_Tema.Text != "")
            {
                aobj_Tema.COD_TEMA = Convert.ToInt16(tbox_Cod_Tema.Text);
            }
            aobj_Tema.TIT_TEMA = tbox_Tit_Tema.Text;
            aobj_Tema.DESC_TEMA = tbox_Desc_Tema.Text;

            return aobj_Tema;
        }


        private void btn_Confirmar_Click(object sender, EventArgs e)
        {
            TemaBD obj_TemaBD = new TemaBD();

            Tema_Principal = PopulaObjeto();

            if (Tema_Principal.COD_TEMA != -1)
            {
                obj_TemaBD.Alterar(Tema_Principal);
                MessageBox.Show("Tema alterada com sucesso. ", "Alteração da Tema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Tema_Principal.COD_TEMA = obj_TemaBD.Incluir(Tema_Principal);
                MessageBox.Show("Tema Incluida com sucesso. ", "Inclusão da Tema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                PopulaTela(Tema_Principal);
            }

            obj_FuncGeral.StatusBtn(this, 2);
            obj_FuncGeral.HabilitaTela(this, false);
            PopulaLista();

        }

        private void btn_Novo_Click(object sender, EventArgs e)
        {
            obj_FuncGeral.HabilitaTela(this, true);
            obj_FuncGeral.LimpaTela(this);
            obj_FuncGeral.StatusBtn(this, 3);
            tbox_Tit_Tema.Focus();

        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            obj_FuncGeral.HabilitaTela(this, false);

            if (Tema_Principal.COD_TEMA != -1)
            {
                PopulaTela(Tema_Principal);
                obj_FuncGeral.StatusBtn(this, 2);
            }
            else
            {
                obj_FuncGeral.StatusBtn(this, 1);
            }

        }

        private void btn_Alterar_Click(object sender, EventArgs e)
        {
            obj_FuncGeral.HabilitaTela(this, true);
            obj_FuncGeral.StatusBtn(this, 3);
            tbox_Tit_Tema.Focus();

        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            TemaBD obj_TemaBD = new TemaBD();
            DialogResult varResp = MessageBox.Show("Confirma a Exclusão?", "Exclusão da Tema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (varResp == DialogResult.Yes)
            {
                if (obj_TemaBD.Excluir(Tema_Principal))
                {
                    MessageBox.Show("Tema excluida com sucesso. ", "Exclusão da Tema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                obj_FuncGeral.LimpaTela(this);
                obj_FuncGeral.HabilitaTela(this, false);
                obj_FuncGeral.StatusBtn(this, 1);
                PopulaLista();


            }

        }
    }
}
