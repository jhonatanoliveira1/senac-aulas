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
    public partial class frm_Especialidade : Form
    {

        FuncGeral obj_FuncGeral = new FuncGeral();
        Especialidade Especialidade_Principal = new Especialidade();

        public frm_Especialidade()
        {
            InitializeComponent();
            PopulaLista();
            obj_FuncGeral.StatusBtn(this, 1);
            obj_FuncGeral.HabilitaTela(this, false);
        }

        /**********************************************************************************
        * NOME:            PopulaLista
        * PROCEDIMENTO:    Preenche o ListBox com os dados que estão na TB_Especialidade
        * DT CRIAÇÃO:      22/11/2019
        * DT ALTERAÇÃO:    -
        * ESCRITA POR:     Mfacine (Monstro)
        * OBSERVAÇÕES:     
        * ********************************************************************************/
        private void PopulaLista()
        {
            // Instância do objeto EspecialidadeBD
            EspecialidadeBD obj_EspecialidadeBD = new EspecialidadeBD();

            // Instância do objeto Lista
            List<Especialidade> Lista = new List<Especialidade>();

            // Limpando o ListBox
            lbox_Especialidades.Items.Clear();

            Lista = obj_EspecialidadeBD.FindAllEspecialidade();

            if (Lista != null)
            {
                for (int i = 0; i <= Lista.Count - 1; i++)
                {
                    lbox_Especialidades.Items.Add(Lista[i].COD_ESPECIALIDADE.ToString() + "-" + Lista[i].TIT_ESPECIALIDADE);
                }
            }
        }

        private void lbox_Especialidades_Click(object sender, EventArgs e)
        {
            if (lbox_Especialidades.SelectedIndex != -1)
            {
                EspecialidadeBD obj_EspecialidadeBD = new EspecialidadeBD();

                string sLinha = lbox_Especialidades.Items[lbox_Especialidades.SelectedIndex].ToString();

                int ipos = 0;

                for (int t = 0; t <= sLinha.Length; t++)
                {
                    if (sLinha.Substring(t, 1) == "-")
                    {
                        ipos = t;
                        break;
                    }
                }

                Especialidade_Principal.COD_ESPECIALIDADE = Convert.ToInt16(sLinha.Substring(0, ipos));

                Especialidade_Principal = obj_EspecialidadeBD.FindByCodEspecialidade(Especialidade_Principal);

                PopulaTela(Especialidade_Principal);

                obj_FuncGeral.StatusBtn(this, 2);

            }
        }

        /**********************************************************************************
        * NOME:            PopulaTela
        * PROCEDIMENTO:    Preenche a tela com os dados do Objeto Principal
        * DT CRIAÇÃO:      22/11/2019
        * DT ALTERAÇÃO:    -
        * PARAMETRO:       
        * ESCRITA POR:     Mfacine (Monstro)
        * OBSERVAÇÕES:     
        * ********************************************************************************/
        private void PopulaTela(Especialidade aobj_Especialidade)
        {
            if (aobj_Especialidade.COD_ESPECIALIDADE != -1)
            {
                tbox_Cod_Especialidade.Text = aobj_Especialidade.COD_ESPECIALIDADE.ToString();
                tbox_Tit_Especialidade.Text = aobj_Especialidade.TIT_ESPECIALIDADE;
                tbox_Desc_Especialidade.Text = aobj_Especialidade.DESC_ESPECIALIDADE;
            }
        }


        /**********************************************************************************
        * NOME:            PopulaObjeto
        * PROCEDIMENTO:    Preenche o objeto com os dados da  tela 
        * DT CRIAÇÃO:      22/11/2019
        * DT ALTERAÇÃO:    -
        * PARAMETRO:       
        * ESCRITA POR:     Mfacine (Monstro)
        * OBSERVAÇÕES:     
        * ********************************************************************************/
        private Especialidade PopulaObjeto()
        {
            Especialidade aobj_Especialidade = new Especialidade();

            if (tbox_Cod_Especialidade.Text != "")
            {
                aobj_Especialidade.COD_ESPECIALIDADE = Convert.ToInt16(tbox_Cod_Especialidade.Text);
            }
            aobj_Especialidade.TIT_ESPECIALIDADE = tbox_Tit_Especialidade.Text;
            aobj_Especialidade.DESC_ESPECIALIDADE = tbox_Desc_Especialidade.Text;

            return aobj_Especialidade;
        }


        private void btn_Confirmar_Click(object sender, EventArgs e)
        {
            EspecialidadeBD obj_EspecialidadeBD = new EspecialidadeBD();

            Especialidade_Principal = PopulaObjeto();

            if (Especialidade_Principal.COD_ESPECIALIDADE != -1)
            {
                obj_EspecialidadeBD.Alterar(Especialidade_Principal);
                MessageBox.Show("Especialidade alterada com sucesso. ", "Alteração da Especialidade", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Especialidade_Principal.COD_ESPECIALIDADE = obj_EspecialidadeBD.Incluir(Especialidade_Principal);
                MessageBox.Show("Especialidade Incluida com sucesso. ", "Inclusão da Especialidade", MessageBoxButtons.OK, MessageBoxIcon.Information);
                PopulaTela(Especialidade_Principal);
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
            tbox_Tit_Especialidade.Focus();

        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            obj_FuncGeral.HabilitaTela(this, false);

            if (Especialidade_Principal.COD_ESPECIALIDADE != -1)
            {
                PopulaTela(Especialidade_Principal);
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
            tbox_Tit_Especialidade.Focus();

        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            EspecialidadeBD obj_EspecialidadeBD = new EspecialidadeBD();
            DialogResult varResp = MessageBox.Show("Confirma a Exclusão?", "Exclusão da Especialidade", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (varResp == DialogResult.Yes)
            {
                if (obj_EspecialidadeBD.Excluir(Especialidade_Principal))
                {
                    MessageBox.Show("Especialidade excluida com sucesso. ", "Exclusão da Especialidade", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                obj_FuncGeral.LimpaTela(this);
                obj_FuncGeral.HabilitaTela(this, false);
                obj_FuncGeral.StatusBtn(this, 1);
                PopulaLista();


            }

        }
    }
}
