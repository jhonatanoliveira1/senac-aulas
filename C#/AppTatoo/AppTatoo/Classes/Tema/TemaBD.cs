/*****************************************************************************
* Nome           : TemaBD
* Classe         : Representação da classe que se conecta com o banco através 
*                  da entidade Tema
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
    class TemaBD
    {
        //05/11/2019 - Mfacine - ToDo: criar uma classe de funções gerais (FuncGeral)

        /*****************************************************************************
        * Nome           : Incluir
        * Procedimento   : Responsável por incluir o Objeto na Base de Dados
        *                  Método para inclui um registro na tabela Tema
        * Parametros     : Objeto da Classe Tema
        * Data  Criação  : 12/11/2019
        * Data Alteração : -
        * Escrito por    : Mfacine (Monstro)
        * Observações    : Utiliza a Classe Connection para acessar o Base de Dados
        * ***************************************************************************/
        public int Incluir(Tema aobj_Tema)
        {
            //12/11/2019 - Mfacine - Criar objeto de conexão com o banco de dados
            SqlConnection objCon = new SqlConnection(Connection.ConnectionPath());

            //12/11/2018 - Mfacine - Criar a variável que contém a instrução SQL
            string varSql = "INSERT INTO TB_TEMA " +
                            "(" +
                            " S_TIT_TEMA,   " +
                            " T_DESC_TEMA  " +
                            ")" +
                            "VALUES " +
                            "(" +
                            " @S_TIT_TEMA,   " +
                            " @T_DESC_TEMA  " +
                            "); " +
                            "SELECT ident_current('TB_TEMA') as 'id'";

            //12/11/2019 - mfacine - Criar objeto para executar o comando
            SqlCommand objCmd = new SqlCommand(varSql, objCon);

            objCmd.Parameters.AddWithValue("@S_TIT_TEMA", aobj_Tema.TIT_TEMA);
            objCmd.Parameters.AddWithValue("@T_DESC_TEMA", aobj_Tema.DESC_TEMA);

            try
            {
                //12/11/2019 - mfacine - Abrir a conexão com o banco de dados
                objCon.Open();

                //12/11/2019 - mfacine - Executar o comando Escalar
                int _id = Convert.ToInt16(objCmd.ExecuteScalar());

                //(12/11/2018-mfacine) fechar a conexão
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
        *                  Método para Alteração de um registro na tabela Tema
        * Parametros     : Objeto da Classe Tema
        * Data  Criação  : 12/11/2018
        * Data Alteração : -
        * Escrito por    : Mfacine (Monstro)
        * Observações    : Utiliza a Classe Connection para acessar o Base de Dados
        * ***************************************************************************/
        public Boolean Alterar(Tema aobj_Tema)
        {


            if (aobj_Tema.COD_TEMA != -1)
            {
                //(12/11/2018-mfacine) Criar objeto de conexão com o banco de dados
                SqlConnection objCon = new SqlConnection(Connection.ConnectionPath());

                //(12/11/2018-mfacine) Criar a variável que contém a instrução SQL
                string varSql = " UPDATE TB SET TB_TEMA" +
                                " S_TIT_TEMA    = @S_TIT_TEMA,    " +
                                " T_DESC_TEMA   = @T_DESC_TEMA   " +
                                " WHERE I_COD_TEMA = @I_COD_TEMA";

                //(12/11/2019-mfacine) Criar objeto para executar o comando
                SqlCommand objCmd = new SqlCommand(varSql, objCon);
                objCmd.Parameters.AddWithValue("@I_COD_TEMA", aobj_Tema.COD_TEMA);
                objCmd.Parameters.AddWithValue("@S_TIT_TEMA", aobj_Tema.TIT_TEMA);
                objCmd.Parameters.AddWithValue("@T_DESC_TEMA", aobj_Tema.DESC_TEMA);

                try
                {
                    //(12/11/2019-mfacine) Abrir a conexão com o banco de dados
                    objCon.Open();

                    //(12/11/2019-mfacine) Executar o comando
                    objCmd.ExecuteNonQuery();

                    //(12/11/2018-mfacine) fechar a conexão
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
        * Parametros     : Objeto da Classe Tema
        * Data  Criação  : 12/11/2018
        * Data Alteração : -
        * Escrito por    : Mfacine (Monstro)
        * Observações    : Utiliza a Classe Connection para acessar o Base de Dados
        * ***************************************************************************/
        public Boolean Excluir(Tema aobj_Tema)
        {
            //(12/11/2018-mfacine) Criar objeto para conexão com o banco de dados
            SqlConnection ObjCon = new SqlConnection(Connection.ConnectionPath());

            //(12/11/2018-mfacine) Criar uma váriavel que contém a instrução SQL
            string varSql = " DELETE FROM TB_TEMA " +
                            " WHERE I_COD_TEMA = @I_COD_TEMA";

            //(12/11/2018-mfacine) Criar objeto para executar o comando
            SqlCommand objCmd = new SqlCommand(varSql, ObjCon);
            objCmd.Parameters.AddWithValue("@I_COD_TEMA", aobj_Tema.COD_TEMA);

            try
            {
                //(12/11/2018-mfacine) Abrir a conexão com o banco de dados
                ObjCon.Open();

                //(12/11/2018-mfacine) Executar o comando para excluir o registro
                objCmd.ExecuteNonQuery();

                //(12/11/2018-mfacine) Fechar a conexão com o banco de dados
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
        * Nome           : FindByCodTema
        * Procedimento   : Responsável por encontrar o Objeto na Base de Dados
        *                  Método para Buscar um registro na tabela TB_TEMA
        * Parametros     : Objeto da Classe Tema
        * Data  Criação  : 12/11/2018
        * Data Alteração : -
        * Escrito por    : Mfacine (Monstro)
        * Observações    : Utiliza a Classe Connection para acessar o Base de Dados
        * ***************************************************************************/
        public Tema FindByCodTema(Tema aobj_Tema)
        {
            //(12/11/2018-Mfacine) Criar objeto para conexão com o banco de dados
            SqlConnection objCon = new SqlConnection(Connection.ConnectionPath());

            //(12/11/2018-Mfacine) Criar uma váriavel que contém a instrução SQL
            string varSql = " SELECT * FROM TB_TEMA " +
                            " WHERE I_COD_TEMA = @I_COD_TEMA ";

            //(12/11/2018-Mfacine) Criar objeto para executar o comando
            SqlCommand objCmd = new SqlCommand(varSql, objCon);
            objCmd.Parameters.AddWithValue("@I_COD_TEMA", aobj_Tema.COD_TEMA);

            try
            {
                //(12/11/2018-Mfacine) Abrir a conexão com o banco de dados
                objCon.Open();

                //(12/11/2018-Mfacine) Criar um objeto DataReader que irá receber os dados
                SqlDataReader objDtr = objCmd.ExecuteReader();

                if (objDtr.HasRows)
                {
                    //Ler os dados que estão no objeto DataReader 
                    objDtr.Read();

                    //(12/11/2018-mfacine) Recupero os valores (Tipo um Popula Objeto)

                    aobj_Tema.COD_TEMA = Convert.ToInt16(objDtr["I_COD_TEMA"]);
                    aobj_Tema.TIT_TEMA = objDtr["S_TIT_TEMA"].ToString();
                    aobj_Tema.DESC_TEMA = objDtr["T_DESC_TEMA"].ToString();

                }

                objCon.Close();
                objDtr.Close();
                return aobj_Tema;
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "ERRO FATAL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return aobj_Tema;
            }
        }


        /****************************************************************************
        * Nome           : FindAllTema
        * Procedimento   : Responsável por encontrar todos os Objetos na Base de Dados
        *                   Método para Buscar uma lista de registros 
        * Parametros     : Objeto da Classe Tema
        * Data Criação   : 12/11/2019
        * Data Alteração : -
        * Escrito por    : Mfacine(Monstro)
        * Observações    : Utiliza a Classe Connection para acessar o Base de Dados
        * ***************************************************************************/
        public List<Tema> FindAllTema()
        {
            SqlConnection objCon = new SqlConnection(Connection.ConnectionPath());
            string varSql = " SELECT * FROM TB_TEMA ";
            SqlCommand objCmd = new SqlCommand(varSql, objCon);
            try
            {
                objCon.Open();
                SqlDataReader objDtr = objCmd.ExecuteReader();

                List<Tema> aLista = new List<Tema>();

                if (objDtr.HasRows)
                {
                    while (objDtr.Read())
                    {
                        Tema aobj_Tema = new Tema();

                        aobj_Tema.COD_TEMA = Convert.ToInt16(objDtr["I_COD_TEMA"]);
                        aobj_Tema.TIT_TEMA = objDtr["S_TIT_TEMA"].ToString();
                        aobj_Tema.DESC_TEMA = objDtr["T_DESC_TEMA"].ToString();

                        aLista.Add(aobj_Tema);

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
