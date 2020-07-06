/**********************************************************************************
 * NOME:            FuncGeral
 * CLASSE:          Representação do objeto de funções gerais
 * DT CRIAÇÃO:      25/11/2019
 * DT ALTERAÇÃO:    -
 * ESCRITA POR:     Mfacine (Monstro)
 * OBSERVAÇÕES:     Metodos públicos que serão utilizados por formulários e classes
 * ********************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace AppTatoo
{
    class FuncGeral
    {
        /****************************************************************************
        * Nome           : LimpaTela
        * Procedimento   : Limpa cada componente editável ou modificado no pnl_Detalhe 
        * Parametros     : Nome do Formulário
        * Data Criação   : 25/11/2019
        * Data Alteração : -
        * Escrito por    : Mfacine(Monstro)
        * ***************************************************************************/
        public void LimpaTela(Form aobj_Form)
        {
            foreach (Control pnl in aobj_Form.Controls)
            {
                if (pnl is Panel && pnl.Name == "pnl_Detalhe")
                {
                    foreach (Control ctrl in pnl.Controls)
                    {
                        if (ctrl is TextBox)
                        {
                            ctrl.Text = "";
                        }

                        if (ctrl is CheckBox)
                        {
                            CheckBox ChBox = new CheckBox();
                            ChBox = (CheckBox)ctrl;
                            ChBox.Checked = false;
                        }
                    }
                }
            }
        }

        /****************************************************************************
        * Nome           : HabilitaTela
        * Procedimento   : Habilita cada componente editável no pnl_Detalhe 
        * Parametros     : Nome do Formulário e Bool
        * Data Criação   : 25/11/2019
        * Data Alteração : -
        * Escrito por    : Mfacine(Monstro)
        * ***************************************************************************/
        public void HabilitaTela(Form aobj_Form, bool bHab)
        {
            foreach (Control pnl in aobj_Form.Controls)
            {
                if (pnl is Panel && pnl.Name == "pnl_Detalhe")
                {
                    foreach (Control ctrl in pnl.Controls)
                    {
                       
                        if (ctrl is TextBox && Convert.ToInt16(ctrl.Tag) != 1)
                        {
                            ctrl.Enabled = bHab;
                        }

                        if (ctrl is CheckBox)
                        {
                            ctrl.Enabled = bHab;
                        }
                    }
                }
            }
        }

        /****************************************************************************
        * Nome           : StatusBtn
        * Procedimento   : Define o status dos botões no pnl_Botoes  
        * Parametros     : Nome do Formulário e int
        * Data Criação   : 25/11/2019
        * Data Alteração : -
        * Escrito por    : Mfacine(Monstro)
        * ***************************************************************************/
        public void StatusBtn(Form aobj_Form, int iStatus)
        {
            foreach (Control pnl in aobj_Form.Controls)
            {
                if (pnl is Panel && pnl.Name == "pnl_Botoes")
                {
                    foreach (Control ctrl in pnl.Controls)
                    {
                        switch (iStatus)
                        {
                            case 1:
                                {
                                    if (ctrl.Name == "btn_Novo")
                                    {
                                        ctrl.Enabled = true;
                                    }

                                    if (ctrl.Name == "btn_Alterar")
                                    {
                                        ctrl.Enabled = false;
                                    }

                                    if (ctrl.Name == "btn_Excluir")
                                    {
                                        ctrl.Enabled = false;
                                    }

                                    if (ctrl.Name == "btn_Confirmar")
                                    {
                                        ctrl.Enabled = false;
                                    }

                                    if (ctrl.Name == "btn_Cancelar")
                                    {
                                        ctrl.Enabled = false;
                                    }
                                    break;
                                }

                            case 2:
                                {
                                    if (ctrl.Name == "btn_Novo")
                                    {
                                        ctrl.Enabled = true;
                                    }

                                    if (ctrl.Name == "btn_Alterar")
                                    {
                                        ctrl.Enabled = true;
                                    }

                                    if (ctrl.Name == "btn_Excluir")
                                    {
                                        ctrl.Enabled = true;
                                    }

                                    if (ctrl.Name == "btn_Confirmar")
                                    {
                                        ctrl.Enabled = false;
                                    }

                                    if (ctrl.Name == "btn_Cancelar")
                                    {
                                        ctrl.Enabled = false;
                                    }
                                    break;
                                }

                            case 3:
                                {
                                    if (ctrl.Name == "btn_Novo")
                                    {
                                        ctrl.Enabled = false;
                                    }

                                    if (ctrl.Name == "btn_Alterar")
                                    {
                                        ctrl.Enabled = false;
                                    }

                                    if (ctrl.Name == "btn_Excluir")
                                    {
                                        ctrl.Enabled = false;
                                    }

                                    if (ctrl.Name == "btn_Confirmar")
                                    {
                                        ctrl.Enabled = true;
                                    }

                                    if (ctrl.Name == "btn_Cancelar")
                                    {
                                        ctrl.Enabled = true;
                                    }
                                    break;
                                }
                        }
                    }
                }
            }
        }

       /****************************************************************************
       * Nome           : TrazPeriodo
       * Procedimento   : Traz de forma escrita o conteúdo "numerico" do TB_TURNO 
       * Parametros     : variável sPer
       * Data Criação   : 02/12/2019
       * Data Alteração : -
       * Escrito por    : Mfacine(Monstro)
       * ***************************************************************************/
        public string TrazPeriodo(string sPer)
        {
            string sRetorno = null;

            //(02/12/2019 - Mfacine) - PERIODOS//
            if (sPer.Substring(0, 1) == "1")
            {
                sRetorno = " Manhã ";
            }

            if (sPer.Substring(1, 1) == "1")
            {
                sRetorno = sRetorno + "Tarde ";
            }

            if (sPer.ToString().Substring(2, 1) == "1")
            {
                sRetorno = sRetorno + "Noite ";
            }

            return sRetorno;
        }

        /****************************************************************************
       * Nome           : TrazSemana
       * Procedimento   : Traz de forma escrita o conteúdo "numerico" do TB_TURNO 
       * Parametros     : variável sSem
       * Data Criação   : 02/12/2019
       * Data Alteração : -
       * Escrito por    : Mfacine(Monstro)
       * ***************************************************************************/
        public string TrazSemana(string sSem)
        {
            string sRetorno = null;

            if (sSem.Substring(0, 1) == "1")
            {
                sRetorno = " Seg ";
            }

            if (sSem.Substring(1, 1) == "1")
            {
                sRetorno = sRetorno + "Ter ";
            }

            if (sSem.ToString().Substring(2, 1) == "1")
            {
                sRetorno = sRetorno + "Qua ";
            }

            if (sSem.ToString().Substring(3, 1) == "1")
            {
                sRetorno = sRetorno + "Qui ";
            }

            if (sSem.ToString().Substring(4, 1) == "1")
            {
                sRetorno = sRetorno + "Sex ";
            }

            if (sSem.ToString().Substring(5, 1) == "1")
            {
                sRetorno = sRetorno + "Sáb";
            }


            return sRetorno;
        }


    }
}
