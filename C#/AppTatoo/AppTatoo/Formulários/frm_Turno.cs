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
    public partial class frm_Turno : Form
    {

        FuncGeral obj_FuncGeral = new FuncGeral();
        Turno Turno_Principal = new Turno();

        public frm_Turno()
        {
            InitializeComponent();
            PopulaLista();
            obj_FuncGeral.StatusBtn(this, 1);
            obj_FuncGeral.HabilitaTela(this, false);
        }

        /**********************************************************************************
        * NOME:            PopulaLista
        * PROCEDIMENTO:    Preenche o ListBox com os dados que estão na TB_Turno
        * DT CRIAÇÃO:      02/12/2019
        * DT ALTERAÇÃO:    -
        * ESCRITA POR:     Mfacine (Monstro)
        * OBSERVAÇÕES:     
        * ********************************************************************************/
        private void PopulaLista()
        {
            string sPer = null;
            string sSem = null;

            // Instância do objeto TurnoBD
            TurnoBD obj_TurnoBD = new TurnoBD();

            // Instância do objeto Lista
            List<Turno> Lista = new List<Turno>();

            // Limpando o ListBox
            lbox_Turnos.Items.Clear();

            Lista = obj_TurnoBD.FindAllTurno();

            if (Lista != null)
            {
                for (int i = 0; i <= Lista.Count - 1; i++)
                {
                    //(02/12/2019 - Mfacine) - PERIODOS//
                    sPer = obj_FuncGeral.TrazPeriodo(Lista[i].PER_TURNO);

                    //(02/12/2019 - Mfacine) - DIAS SEMANA//
                    sSem = obj_FuncGeral.TrazSemana(Lista[i].SEM_TURNO);

                    lbox_Turnos.Items.Add(Lista[i].COD_TURNO.ToString() + "-" + sPer + "-" + sSem);
                }
            }
        }

        private void lbox_Turnos_Click(object sender, EventArgs e)
        {
            if (lbox_Turnos.SelectedIndex != -1)
            {
                TurnoBD obj_TurnoBD = new TurnoBD();

                string sLinha = lbox_Turnos.Items[lbox_Turnos.SelectedIndex].ToString();

                int ipos = 0;

                for (int t = 0; t <= sLinha.Length; t++)
                {
                    if (sLinha.Substring(t, 1) == "-")
                    {
                        ipos = t;
                        break;
                    }
                }

                Turno_Principal.COD_TURNO = Convert.ToInt16(sLinha.Substring(0, ipos));

                Turno_Principal = obj_TurnoBD.FindByCodTurno(Turno_Principal);

                PopulaTela(Turno_Principal);

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
        private void PopulaTela(Turno aobj_Turno)
        {
            if (aobj_Turno.COD_TURNO != -1)
            {
                tbox_Cod_Turno.Text = aobj_Turno.COD_TURNO.ToString();


                //(02/12/2019 - Mfacine) - PERIODOS//
                if (aobj_Turno.PER_TURNO.ToString().Substring(0,1) == "1")
                {
                    chbox_Man.Checked = true;
                }
                else
                {
                    chbox_Man.Checked = false;
                }

                if (aobj_Turno.PER_TURNO.ToString().Substring(1, 1) == "1")
                {
                    chbox_Tar.Checked = true;
                }
                else
                {
                    chbox_Tar.Checked = false;
                }

                if (aobj_Turno.PER_TURNO.ToString().Substring(2, 1) == "1")
                {
                    chbox_Noi.Checked = true;
                }
                else
                {
                    chbox_Noi.Checked = false;
                }

                //(02/12/2019 - Mfacine) - DIAS SEMANA//
                if (aobj_Turno.SEM_TURNO.ToString().Substring(0, 1) == "1")
                {
                    chbox_Seg.Checked = true;
                }
                else
                {
                    chbox_Seg.Checked = false;
                }

                if (aobj_Turno.SEM_TURNO.ToString().Substring(1, 1) == "1")
                {
                    chbox_Ter.Checked = true;
                }
                else
                {
                    chbox_Ter.Checked = false;
                }

                if (aobj_Turno.SEM_TURNO.ToString().Substring(2, 1) == "1")
                {
                    chbox_Qua.Checked = true;
                }
                else
                {
                    chbox_Qua.Checked = false;
                }

                if (aobj_Turno.SEM_TURNO.ToString().Substring(3, 1) == "1")
                {
                    chbox_Qui.Checked = true;
                }
                else
                {
                    chbox_Qui.Checked = false;
                }

                if (aobj_Turno.SEM_TURNO.ToString().Substring(4, 1) == "1")
                {
                    chbox_Sex.Checked = true;
                }
                else
                {
                    chbox_Sex.Checked = false;
                }

                if (aobj_Turno.SEM_TURNO.ToString().Substring(5, 1) == "1")
                {
                    chbox_Sab.Checked = true;
                }
                else
                {
                    chbox_Sab.Checked = false;
                }

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
        private Turno PopulaObjeto()
        {
            Turno aobj_Turno = new Turno();

            if (tbox_Cod_Turno.Text != "")
            {
                aobj_Turno.COD_TURNO = Convert.ToInt16(tbox_Cod_Turno.Text);
            }

            //(02/12/2019 - Mfacine) - PERIODOS//
            if (chbox_Man.Checked)
            {
                aobj_Turno.PER_TURNO = "1";
            }
            else
            {
                aobj_Turno.PER_TURNO = "0";
            }

            if (chbox_Tar.Checked)
            {
                aobj_Turno.PER_TURNO = aobj_Turno.PER_TURNO + "1";
            }
            else
            {
                aobj_Turno.PER_TURNO = aobj_Turno.PER_TURNO + "0";
            }

            if (chbox_Noi.Checked)
            {
                aobj_Turno.PER_TURNO = aobj_Turno.PER_TURNO + "1";
            }
            else
            {
                aobj_Turno.PER_TURNO = aobj_Turno.PER_TURNO + "0";
            }


            //(02/12/2019 - Mfacine) - DIAS SEMANA//
            if (chbox_Seg.Checked)
            {
                aobj_Turno.SEM_TURNO = "1";
            }
            else
            {
                aobj_Turno.SEM_TURNO = "0";
            }

            if (chbox_Ter.Checked)
            {
                aobj_Turno.SEM_TURNO = aobj_Turno.SEM_TURNO + "1";
            }
            else
            {
                aobj_Turno.SEM_TURNO = aobj_Turno.SEM_TURNO + "0";
            }

            if (chbox_Qua.Checked)
            {
                aobj_Turno.SEM_TURNO = aobj_Turno.SEM_TURNO + "1";
            }
            else
            {
                aobj_Turno.SEM_TURNO = aobj_Turno.SEM_TURNO + "0";
            }

            if (chbox_Qui.Checked)
            {
                aobj_Turno.SEM_TURNO = aobj_Turno.SEM_TURNO + "1";
            }
            else
            {
                aobj_Turno.SEM_TURNO = aobj_Turno.SEM_TURNO + "0";
            }

            if (chbox_Sex.Checked)
            {
                aobj_Turno.SEM_TURNO = aobj_Turno.SEM_TURNO + "1";
            }
            else
            {
                aobj_Turno.SEM_TURNO = aobj_Turno.SEM_TURNO + "0";
            }

            if (chbox_Sab.Checked)
            {
                aobj_Turno.SEM_TURNO = aobj_Turno.SEM_TURNO + "1";
            }
            else
            {
                aobj_Turno.SEM_TURNO = aobj_Turno.SEM_TURNO + "0";
            }


            return aobj_Turno;
        }


        private void btn_Confirmar_Click(object sender, EventArgs e)
        {
            TurnoBD obj_TurnoBD = new TurnoBD();

            Turno_Principal = PopulaObjeto();

            if (Turno_Principal.COD_TURNO != -1)
            {
                obj_TurnoBD.Alterar(Turno_Principal);
                MessageBox.Show("Turno alterada com sucesso. ", "Alteração da Turno", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Turno_Principal.COD_TURNO = obj_TurnoBD.Incluir(Turno_Principal);
                MessageBox.Show("Turno Incluida com sucesso. ", "Inclusão da Turno", MessageBoxButtons.OK, MessageBoxIcon.Information);
                PopulaTela(Turno_Principal);
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
            chbox_Man.Focus();

        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            obj_FuncGeral.HabilitaTela(this, false);

            if (Turno_Principal.COD_TURNO != -1)
            {
                PopulaTela(Turno_Principal);
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
            chbox_Man.Focus();

        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            TurnoBD obj_TurnoBD = new TurnoBD();
            DialogResult varResp = MessageBox.Show("Confirma a Exclusão?", "Exclusão da Turno", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (varResp == DialogResult.Yes)
            {
                if (obj_TurnoBD.Excluir(Turno_Principal))
                {
                    MessageBox.Show("Turno excluida com sucesso. ", "Exclusão da Turno", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                obj_FuncGeral.LimpaTela(this);
                obj_FuncGeral.HabilitaTela(this, false);
                obj_FuncGeral.StatusBtn(this, 1);
                PopulaLista();


            }

        }
    }
}
