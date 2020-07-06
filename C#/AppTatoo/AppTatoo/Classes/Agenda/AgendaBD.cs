/*****************************************************************************
* Nome           : AgendaBD
* Classe         : Representação da classe que se conecta com o banco através 
*                  da entidade Agenda
* Data  Criação  : 12/11/2019
* Data Alteração : -
* Escrito por    : Mfacine (Monstro)
* Observações    : 
* ***************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
using System.Dynamic;

namespace AppTatoo
{
    class AgendaBD
    {
        //12/11/2019 - Mfacine - ToDo: criar uma classe de funções gerais (FuncGeral)

        /*****************************************************************************
        * Nome           : Incluir
        * Procedimento   : Responsável por incluir o Objeto na Base de Dados
        *                  Método para inclui um registro na tabela Agenda
        * Parametros     : Objeto da Classe Agenda
        * Data  Criação  : 05/11/2019
        * Data Alteração : -
        * Escrito por    : Mfacine (Monstro)
        * Observações    : Utiliza a Classe Connection para acessar o Base de Dados
        * ***************************************************************************/
        public int Incluir(Agenda aobj_Agenda)
        {
            //12/11/2019 - Mfacine - Criar objeto de conexão com o banco de dados
            SqlConnection objCon = new SqlConnection(Connection.ConnectionPath());

            //12/11/2019 - Mfacine - Criar a variável que contém a instrução SQL
            string varSql = "INSERT INTO TB_AGENDA " +
                            "(" +
                            " I_COD_TATUADOR, " +
                            " I_COD_CLIENTE,  " +
                            " DT_DH_AGENDA,   " +
                            " T_OBS_AGENDA   " +
                            ")" +
                            "VALUES " +
                            "(" +
                            " @I_COD_TATUADOR," +
                            " @I_COD_CLIENTE, " +
                            " @DT_DH_AGENDA,  " +
                            " @T_OBS_AGENDA   " +
                            "); " +
                            "SELECT ident_current('TB_AGENDA') as 'id'";

            //12/11/2019 - mfacine - Criar objeto para executar o comando
            SqlCommand objCmd = new SqlCommand(varSql, objCon);

            objCmd.Parameters.AddWithValue("@I_COD_TATUADOR", aobj_Agenda.COD_TATUADOR);
            objCmd.Parameters.AddWithValue("@I_COD_CLIENTE", aobj_Agenda.COD_CLIENTE);
            objCmd.Parameters.AddWithValue("@DT_DH_AGENDA", aobj_Agenda.DH_AGENDA);
            objCmd.Parameters.AddWithValue("@T_OBS_AGENDA", aobj_Agenda.OBS_AGENDA);
            try
            {
                //12/11/2019 - mfacine - Abrir a conexão com o banco de dados
                objCon.Open();

                //12/11/2019 - mfacine - Executar o comando Escalar
                int _id = Convert.ToInt16(objCmd.ExecuteScalar());

                //(12/11/2019-mfacine) fechar a conexão
                objCon.Close();

                return _id;
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "ERRO FATAL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
        }


        /*****************************************************************************
        * Nome           : Alterar
        * Procedimento   : Responsável por editar o Objeto na Base de Dados
        *                  Método para Alteração de um registro na tabela Agenda
        * Parametros     : Objeto da Classe Agenda
        * Data  Criação  : 12/11/2019
        * Data Alteração : -
        * Escrito por    : Mfacine (Monstro)
        * Observações    : Utiliza a Classe Connection para acessar o Base de Dados
        * ***************************************************************************/
        public Boolean Alterar(Agenda aobj_Agenda)
        {


            if (aobj_Agenda.COD_AGENDA != -1)
            {
                //(08/11/2018-mfacine) Criar objeto de conexão com o banco de dados
                SqlConnection objCon = new SqlConnection(Connection.ConnectionPath());

                //(15/06/2018-mfacine) Criar a variável que contém a instrução SQL
                string varSql = " UPDATE TB SET TB_AGENDA" +
                                " I_COD_TATUADOR = @I_COD_TATUADOR,"+
                                " I_COD_CLIENTE  = @I_COD_CLIENTE, "+
                                " DT_DH_AGENDA   = @DT_DH_AGENDA,  "+
                                " T_OBS_AGENDA   = @T_OBS_AGENDA  "+
                                " WHERE I_COD_AGENDA = @I_COD_AGENDA";

                //(08/11/2019-mfacine) Criar objeto para executar o comando
                SqlCommand objCmd = new SqlCommand(varSql, objCon);
                objCmd.Parameters.AddWithValue("@I_COD_AGENDA", aobj_Agenda.COD_AGENDA);
                objCmd.Parameters.AddWithValue("@I_COD_TATUADOR", aobj_Agenda.COD_TATUADOR);
                objCmd.Parameters.AddWithValue("@I_COD_CLIENTE", aobj_Agenda.COD_CLIENTE);
                objCmd.Parameters.AddWithValue("@DT_DH_AGENDA", aobj_Agenda.DH_AGENDA);
                objCmd.Parameters.AddWithValue("@T_OBS_AGENDA", aobj_Agenda.OBS_AGENDA);
                try
                {
                    //(12/11/2019-mfacine) Abrir a conexão com o banco de dados
                    objCon.Open();

                    //(12/11/2019-mfacine) Executar o comando
                    objCmd.ExecuteNonQuery();

                    //(12/11/2019-mfacine) fechar a conexão
                    objCon.Close();

                    return true;
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message, "ERRO FATAL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            else
            {
                return false;
            }

        }


        /*****************************************************************************
        * Nome           : Excluir
        * Procedimento   : Responsável por Apagar o Objeto na Base de Dados
        *                  Método para deletar um registro na tabela Receita
        * Parametros     : Objeto da Classe Agenda
        * Data  Criação  : 12/11/2019
        * Data Alteração : -
        * Escrito por    : Mfacine (Monstro)
        * Observações    : Utiliza a Classe Connection para acessar o Base de Dados
        * ***************************************************************************/
        public Boolean Excluir(Agenda aobj_Agenda)
        {
            //(12/11/2019-mfacine) Criar objeto para conexão com o banco de dados
            SqlConnection ObjCon = new SqlConnection(Connection.ConnectionPath());

            //(12/11/2019-mfacine) Criar uma váriavel que contém a instrução SQL
            string varSql = " DELETE FROM TB_AGENDA " +
                            " WHERE I_COD_AGENDA = @I_COD_AGENDA";

            //(12/11/2019-mfacine) Criar objeto para executar o comando
            SqlCommand objCmd = new SqlCommand(varSql, ObjCon);
            objCmd.Parameters.AddWithValue("@I_COD_AGENDA", aobj_Agenda.COD_AGENDA);

            try
            {
                //(12/11/2019-mfacine) Abrir a conexão com o banco de dados
                ObjCon.Open();

                //(12/11/2019-mfacine) Executar o comando para excluir o registro
                objCmd.ExecuteNonQuery();

                //(12/11/2019-mfacine) Fechar a conexão com o banco de dados
                ObjCon.Close();

                return true;
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "ERRO FATAL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }


        /*****************************************************************************
        * Nome           : FindByCodAgenda
        * Procedimento   : Responsável por encontrar o Objeto na Base de Dados
        *                  Método para Buscar um registro na tabela TB_AGENDA
        * Parametros     : Objeto da Classe Agenda
        * Data  Criação  : 12/11/2019
        * Data Alteração : -
        * Escrito por    : Mfacine (Monstro)
        * Observações    : Utiliza a Classe Connection para acessar o Base de Dados
        * ***************************************************************************/
        public Agenda FindByCodAgenda(Agenda aobj_Agenda)
        {
            //(12/11/2019-Mfacine) Criar objeto para conexão com o banco de dados
            SqlConnection objCon = new SqlConnection(Connection.ConnectionPath());

            //(12/11/2019-Mfacine) Criar uma váriavel que contém a instrução SQL
            string varSql = " SELECT * FROM TB_AGENDA " +
                            " WHERE I_COD_AGENDA = @I_COD_AGENDA ";

            //(12/11/2019-Mfacine) Criar objeto para executar o comando
            SqlCommand objCmd = new SqlCommand(varSql, objCon);
            objCmd.Parameters.AddWithValue("@I_COD_AGENDA", aobj_Agenda.COD_AGENDA);

            try
            {
                //(12/11/2019-Mfacine) Abrir a conexão com o banco de dados
                objCon.Open();

                //(12/11/2019-Mfacine) Criar um objeto DataReader que irá receber os dados
                SqlDataReader objDtr = objCmd.ExecuteReader();

                if (objDtr.HasRows)
                {
                    //Ler os dados que estão no objeto DataReader 
                    objDtr.Read();

                    //(12/11/2019-mfacine) Recupero os valores (Tipo um Popula Objeto)
                    aobj_Agenda.COD_AGENDA = Convert.ToInt16(objDtr["I_COD_AGENDA"]);
                    aobj_Agenda.COD_TATUADOR = Convert.ToInt16(objDtr["I_COD_TATUADOR"]);
                    aobj_Agenda.COD_CLIENTE = Convert.ToInt16(objDtr["I_COD_CLIENTE"]);
                    aobj_Agenda.DH_AGENDA = Convert.ToDateTime(objDtr["DT_DH_AGENDA"]);
                    aobj_Agenda.OBS_AGENDA = objDtr["T_OBS_AGENDA"].ToString();
                }

                objCon.Close();
                objDtr.Close();
                return aobj_Agenda;
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "ERRO FATAL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return aobj_Agenda;
            }
        }


        /****************************************************************************
        * Nome           : FindAllAgenda
        * Procedimento   : Responsável por encontrar todos os Objetos na Base de Dados
        *                   Método para Buscar uma lista de registros 
        * Parametros     : Objeto da Classe Agenda
        * Data Criação   : 12/11/2019
        * Data Alteração : -
        * Escrito por    : Mfacine(Monstro)
        * Observações    : Utiliza a Classe Connection para acessar o Base de Dados
        * ***************************************************************************/
        public List<Agenda> FindAllAgenda()
        {
            SqlConnection objCon = new SqlConnection(Connection.ConnectionPath());
            string varSql = " SELECT * FROM TB_AGENDA ";
            SqlCommand objCmd = new SqlCommand(varSql, objCon);
            try
            {
                objCon.Open();
                SqlDataReader objDtr = objCmd.ExecuteReader();

                List<Agenda> aLista = new List<Agenda>();

                if (objDtr.HasRows)
                {
                    while (objDtr.Read())
                    {
                        Agenda aobj_Agenda = new Agenda();

                        aobj_Agenda.COD_AGENDA = Convert.ToInt16(objDtr["I_COD_AGENDA"]);
                        aobj_Agenda.COD_TATUADOR = Convert.ToInt16(objDtr["I_COD_TATUADOR"]);
                        aobj_Agenda.COD_CLIENTE = Convert.ToInt16(objDtr["I_COD_CLIENTE"]);
                        aobj_Agenda.DH_AGENDA = Convert.ToDateTime(objDtr["DT_DH_AGENDA"]);
                        aobj_Agenda.OBS_AGENDA = objDtr["T_OBS_AGENDA"].ToString();

                        aLista.Add(aobj_Agenda);

                    }

                    objCon.Close();
                    objDtr.Close();
                    return aLista;

                }
                else
                {
                    objCon.Close();
                    objDtr.Close();
                    return null;
                }

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "ERRO FATAL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}
