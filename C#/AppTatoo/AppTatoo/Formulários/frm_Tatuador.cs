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
    public partial class frm_Tatuador : Form
    {

        FuncGeral obj_FuncGeral = new FuncGeral();
        Tatuador Tatuador_Principal = new Tatuador();

        public frm_Tatuador()
        {
            InitializeComponent();
            PopulaLista();
            obj_FuncGeral.StatusBtn(this, 1);
            obj_FuncGeral.HabilitaTela(this, false);
        }

        /**********************************************************************************
        * NOME:            PopulaLista
        * PROCEDIMENTO:    Preenche o ListBox com os dados que estão na TB_Tatuador
        * DT CRIAÇÃO:      02/12/2019
        * DT ALTERAÇÃO:    -
        * ESCRITA POR:     Mfacine (Monstro)
        * OBSERVAÇÕES:     
        * ********************************************************************************/
        private void PopulaLista()
        {
            // Instância do objeto TatuadorBD
            TatuadorBD obj_TatuadorBD = new TatuadorBD();

            // Instância do objeto Lista
            List<Tatuador> Lista = new List<Tatuador>();

            // Limpando o ListBox
            lbox_Tatuadores.Items.Clear();

            Lista = obj_TatuadorBD.FindAllTatuador();

            if (Lista != null)
            {
                for (int i = 0; i <= Lista.Count - 1; i++)
                {
                    lbox_Tatuadores.Items.Add(Lista[i].COD_TATUADOR.ToString() + "-" + Lista[i].NM_TATUADOR);
                }
            }
        }

        private void lbox_Tatuadores_Click(object sender, EventArgs e)
        {
            if (lbox_Tatuadores.SelectedIndex != -1)
            {
                TatuadorBD obj_TatuadorBD = new TatuadorBD();

                string sLinha = lbox_Tatuadores.Items[lbox_Tatuadores.SelectedIndex].ToString();

                int ipos = 0;

                for (int t = 0; t <= sLinha.Length; t++)
                {
                    if (sLinha.Substring(t, 1) == "-")
                    {
                        ipos = t;
                        break;
                    }
                }

                Tatuador_Principal.COD_TATUADOR = Convert.ToInt16(sLinha.Substring(0, ipos));

                Tatuador_Principal = obj_TatuadorBD.FindByCodTatuador(Tatuador_Principal);

                PopulaTela(Tatuador_Principal);

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
        private void PopulaTela(Tatuador aobj_Tatuador)
        {
            if (aobj_Tatuador.COD_TATUADOR != -1)
            {
                EspecialidadeBD obj_EspecialidadeBD = new EspecialidadeBD();
                Especialidade obj_Especialidade = new Especialidade();

                TurnoBD obj_TurnoBD = new TurnoBD();
                Turno obj_Turno = new Turno();


                tbox_Cod_Tatuador.Text = aobj_Tatuador.COD_TATUADOR.ToString();
                tbox_Nm_Tatuador.Text = aobj_Tatuador.NM_TATUADOR;
                tbox_Cel_Tatuador.Text = aobj_Tatuador.CEL_TATUADOR;
                tbox_Cod_Especialidade.Text = aobj_Tatuador.COD_ESPECIALIDADE.ToString();
                tbox_Cod_Turno.Text = aobj_Tatuador.COD_TURNO.ToString();


                obj_Especialidade.COD_ESPECIALIDADE = aobj_Tatuador.COD_ESPECIALIDADE;
                obj_Especialidade = obj_EspecialidadeBD.FindByCodEspecialidade(obj_Especialidade);
                lb_Tit_Especialidade.Text = obj_Especialidade.TIT_ESPECIALIDADE;

                obj_Turno.COD_TURNO = aobj_Tatuador.COD_TURNO;
                obj_Turno = obj_TurnoBD.FindByCodTurno(obj_Turno);



                lb_Amostra_Turno.Text = obj_FuncGeral.TrazPeriodo(obj_Turno.PER_TURNO) + " - " + obj_FuncGeral.TrazSemana(obj_Turno.SEM_TURNO);

                
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
        private Tatuador PopulaObjeto()
        {
            Tatuador aobj_Tatuador = new Tatuador();

            if (tbox_Cod_Tatuador.Text != "")
            {
                aobj_Tatuador.COD_TATUADOR = Convert.ToInt16(tbox_Cod_Tatuador.Text);
            }
            aobj_Tatuador.NM_TATUADOR = tbox_Nm_Tatuador.Text;
            aobj_Tatuador.CEL_TATUADOR = tbox_Cel_Tatuador.Text;
            aobj_Tatuador.COD_ESPECIALIDADE = Convert.ToInt16(tbox_Cod_Especialidade.Text);
            aobj_Tatuador.COD_TURNO = Convert.ToInt16(tbox_Cod_Turno.Text);
            return aobj_Tatuador;
        }


        private void btn_Confirmar_Click(object sender, EventArgs e)
        {
            TatuadorBD obj_TatuadorBD = new TatuadorBD();

            Tatuador_Principal = PopulaObjeto();

            if (Tatuador_Principal.COD_TATUADOR != -1)
            {
                obj_TatuadorBD.Alterar(Tatuador_Principal);
                MessageBox.Show("Tatuador alterada com sucesso. ", "Alteração da Tatuador", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Tatuador_Principal.COD_TATUADOR = obj_TatuadorBD.Incluir(Tatuador_Principal);
                MessageBox.Show("Tatuador Incluida com sucesso. ", "Inclusão da Tatuador", MessageBoxButtons.OK, MessageBoxIcon.Information);
                PopulaTela(Tatuador_Principal);
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
            tbox_Nm_Tatuador.Focus();

        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            obj_FuncGeral.HabilitaTela(this, false);

            if (Tatuador_Principal.COD_TATUADOR != -1)
            {
                PopulaTela(Tatuador_Principal);
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
            tbox_Nm_Tatuador.Focus();

        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            TatuadorBD obj_TatuadorBD = new TatuadorBD();
            DialogResult varResp = MessageBox.Show("Confirma a Exclusão?", "Exclusão da Tatuador", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (varResp == DialogResult.Yes)
            {
                if (obj_TatuadorBD.Excluir(Tatuador_Principal))
                {
                    MessageBox.Show("Tatuador excluida com sucesso. ", "Exclusão da Tatuador", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                obj_FuncGeral.LimpaTela(this);
                obj_FuncGeral.HabilitaTela(this, false);
                obj_FuncGeral.StatusBtn(this, 1);
                PopulaLista();


            }

        }

        private void tbox_Cod_Especialidade_Leave(object sender, EventArgs e)
        {
            EspecialidadeBD obj_EspecialidadeBD = new EspecialidadeBD();
            Especialidade obj_Especialidade = new Especialidade();

            obj_Especialidade.COD_ESPECIALIDADE = Convert.ToInt16(tbox_Cod_Especialidade.Text);
            obj_Especialidade = obj_EspecialidadeBD.FindByCodEspecialidade(obj_Especialidade);
            lb_Tit_Especialidade.Text = obj_Especialidade.TIT_ESPECIALIDADE;
        }

        private void tbox_Cod_Turno_Leave(object sender, EventArgs e)
        {
            TurnoBD obj_TurnoBD = new TurnoBD();
            Turno obj_Turno = new Turno();

            obj_Turno.COD_TURNO = Convert.ToInt16(tbox_Cod_Turno.Text);
            obj_Turno = obj_TurnoBD.FindByCodTurno(obj_Turno);



            lb_Amostra_Turno.Text = obj_FuncGeral.TrazPeriodo(obj_Turno.PER_TURNO) + " - " + obj_FuncGeral.TrazSemana(obj_Turno.SEM_TURNO);

        }
    }
}
