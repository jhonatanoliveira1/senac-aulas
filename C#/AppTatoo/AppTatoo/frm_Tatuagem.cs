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
    public partial class frm_Tatuagem : Form
    {

        FuncGeral obj_FuncGeral = new FuncGeral();
        Tatuagem Tatuagem_Principal = new Tatuagem();

        public frm_Tatuagem()
        {
            InitializeComponent();
            PopulaLista();
            obj_FuncGeral.StatusBtn(this, 1);
            obj_FuncGeral.HabilitaTela(this, false);
        }

        /**********************************************************************************
        * NOME:            PopulaLista
        * PROCEDIMENTO:    Preenche o ListBox com os dados que estão na TB_Tatuagem
        * DT CRIAÇÃO:      22/11/2019
        * DT ALTERAÇÃO:    -
        * ESCRITA POR:     Mfacine (Monstro)
        * OBSERVAÇÕES:     
        * ********************************************************************************/
        private void PopulaLista()
        {
            // Instância do objeto TatuagemBD
            TatuagemBD obj_TatuagemBD = new TatuagemBD();

            // Instância do objeto Lista
            List<Tatuagem> Lista = new List<Tatuagem>();

            // Limpando o ListBox
            lbox_Tatuagens.Items.Clear();

            Lista = obj_TatuagemBD.FindAllTatuagem();

            if (Lista != null)
            {
                for (int i = 0; i <= Lista.Count - 1; i++)
                {
                    lbox_Tatuagens.Items.Add(Lista[i].COD_TATUAGEM.ToString() + "-" + Lista[i].NM_TATUAGEM);
                }
            }
        }

        private void lbox_Tatuagens_Click(object sender, EventArgs e)
        {
            if (lbox_Tatuagens.SelectedIndex != -1)
            {
                TatuagemBD obj_TatuagemBD = new TatuagemBD();

                string sLinha = lbox_Tatuagens.Items[lbox_Tatuagens.SelectedIndex].ToString();

                int ipos = 0;

                for (int t = 0; t <= sLinha.Length; t++)
                {
                    if (sLinha.Substring(t, 1) == "-")
                    {
                        ipos = t;
                        break;
                    }
                }

                Tatuagem_Principal.COD_TATUAGEM = Convert.ToInt16(sLinha.Substring(0, ipos));

                Tatuagem_Principal = obj_TatuagemBD.FindByCodTatuagem(Tatuagem_Principal);

                PopulaTela(Tatuagem_Principal);

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
        private void PopulaTela(Tatuagem aobj_Tatuagem)
        {
            if (aobj_Tatuagem.COD_TATUAGEM != -1)
            {
                TemaBD obj_TemaBD = new TemaBD();
                Tema obj_Tema = new Tema();

                tbox_Cod_Tatuagem.Text = aobj_Tatuagem.COD_TATUAGEM.ToString();
                tbox_Nm_Tatuagem.Text = aobj_Tatuagem.NM_TATUAGEM;
                cbox_Cor_Tatuagem.SelectedIndex = aobj_Tatuagem.COR_TATUAGEM;
                cbox_Tam_Tatuagem.SelectedIndex = aobj_Tatuagem.TAM_TATUAGEM;

                obj_Tema.COD_TEMA = aobj_Tatuagem.COD_TEMA;

                lb_Tit_Tema.Text = obj_TemaBD.FindByCodTema(obj_Tema).TIT_TEMA;
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
        private Tatuagem PopulaObjeto()
        {
            Tatuagem aobj_Tatuagem = new Tatuagem();

            if (tbox_Cod_Tatuagem.Text != "")
            {
                aobj_Tatuagem.COD_TATUAGEM = Convert.ToInt16(tbox_Cod_Tatuagem.Text);
            }
            
            aobj_Tatuagem.COD_TEMA = Convert.ToInt16(tbox_Cod_Tema.Text);
            aobj_Tatuagem.NM_TATUAGEM = tbox_Nm_Tatuagem.Text;
            aobj_Tatuagem.COR_TATUAGEM = cbox_Cor_Tatuagem.SelectedIndex;
            aobj_Tatuagem.TAM_TATUAGEM = cbox_Tam_Tatuagem.SelectedIndex;
            
            return aobj_Tatuagem;
        }


        private void btn_Confirmar_Click(object sender, EventArgs e)
        {
            TatuagemBD obj_TatuagemBD = new TatuagemBD();

            Tatuagem_Principal = PopulaObjeto();

            if (Tatuagem_Principal.COD_TATUAGEM != -1)
            {
                obj_TatuagemBD.Alterar(Tatuagem_Principal);
                MessageBox.Show("Tatuagem alterada com sucesso. ", "Alteração da Tatuagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Tatuagem_Principal.COD_TATUAGEM = obj_TatuagemBD.Incluir(Tatuagem_Principal);
                MessageBox.Show("Tatuagem Incluida com sucesso. ", "Inclusão da Tatuagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                PopulaTela(Tatuagem_Principal);
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
            tbox_Nm_Tatuagem.Focus();

        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            obj_FuncGeral.HabilitaTela(this, false);

            if (Tatuagem_Principal.COD_TATUAGEM != -1)
            {
                PopulaTela(Tatuagem_Principal);
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
            tbox_Nm_Tatuagem.Focus();

        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            TatuagemBD obj_TatuagemBD = new TatuagemBD();
            DialogResult varResp = MessageBox.Show("Confirma a Exclusão?", "Exclusão da Tatuagem", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (varResp == DialogResult.Yes)
            {
                if (obj_TatuagemBD.Excluir(Tatuagem_Principal))
                {
                    MessageBox.Show("Tatuagem excluida com sucesso. ", "Exclusão da Tatuagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                obj_FuncGeral.LimpaTela(this);
                obj_FuncGeral.HabilitaTela(this, false);
                obj_FuncGeral.StatusBtn(this, 1);
                PopulaLista();


            }

        }

        private void btn_Tema_Click(object sender, EventArgs e)
        {
            frm_Tema obj_frm_Tema = new frm_Tema();
            obj_frm_Tema.ShowDialog();
        }
    }
}
