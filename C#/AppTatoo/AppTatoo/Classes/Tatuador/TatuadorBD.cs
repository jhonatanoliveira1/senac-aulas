/*****************************************************************************
* Nome           : TatuadorBD
* Classe         : Representação da classe que se conecta com o banco através 
*                  da entidade Tatuador
* Data  Criação  : 05/11/2019
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
    class TatuadorBD
    {
        //05/11/2019 - Mfacine - ToDo: criar uma classe de funções gerais (FuncGeral)

        /*****************************************************************************
        * Nome           : Incluir
        * Procedimento   : Responsável por incluir o Objeto na Base de Dados
        *                  Método para inclui um registro na tabela Tatuador
        * Parametros     : Objeto da Classe Tatuador
        * Data  Criação  : 05/11/2019
        * Data Alteração : -
        * Escrito por    : Mfacine (Monstro)
        * Observações    : Utiliza a Classe Connection para acessar o Base de Dados
        * ***************************************************************************/
        public int Incluir(Tatuador aobj_Tatuador)
        {
            //05/11/2019 - Mfacine - Criar objeto de conexão com o banco de dados
            SqlConnection objCon = new SqlConnection(Connection.ConnectionPath());

            //05/11/2018 - Mfacine - Criar a variável que contém a instrução SQL
            string varSql = "INSERT INTO TB_TATUADOR " +
                            "(" +
                            " I_COD_TURNO,         " +
                            " I_COD_ESPECIALIDADE, " +
                            " S_NM_TATUADOR,       " +
                            " S_CEL_TATUADOR       " +
                            ")" +
                            "VALUES " +
                            "(" +
                            " @I_COD_TURNO,         " +
                            " @I_COD_ESPECIALIDADE, " +
                            " @S_NM_TATUADOR,       " +
                            " @S_CEL_TATUADOR       " +
                            "); " +
                            "SELECT ident_current('TB_TATUADOR') as 'id'";

            //05/11/2019 - mfacine - Criar objeto para executar o comando
            SqlCommand objCmd = new SqlCommand(varSql, objCon);

            objCmd.Parameters.AddWithValue("@I_COD_TURNO", aobj_Tatuador.COD_TURNO);
            objCmd.Parameters.AddWithValue("@I_COD_ESPECIALIDADE", aobj_Tatuador.COD_ESPECIALIDADE);
            objCmd.Parameters.AddWithValue("@S_NM_TATUADOR", aobj_Tatuador.NM_TATUADOR);
            objCmd.Parameters.AddWithValue("@S_CEL_TATUADOR", aobj_Tatuador.CEL_TATUADOR);

            try
            {
                //05/11/2019 - mfacine - Abrir a conexão com o banco de dados
                objCon.Open();

                //05/11/2019 - mfacine - Executar o comando Escalar
                int _id = Convert.ToInt16(objCmd.ExecuteScalar());

                //(22/06/2018-mfacine) fechar a conexão
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
        *                  Método para Alteração de um registro na tabela Tatuador
        * Parametros     : Objeto da Classe Tatuador
        * Data  Criação  : 08/11/2018
        * Data Alteração : -
        * Escrito por    : Mfacine (Monstro)
        * Observações    : Utiliza a Classe Connection para acessar o Base de Dados
        * ***************************************************************************/
        public Boolean Alterar(Tatuador aobj_Tatuador)
        {


            if (aobj_Tatuador.COD_TATUADOR != -1)
            {
                //(08/11/2018-mfacine) Criar objeto de conexão com o banco de dados
                SqlConnection objCon = new SqlConnection(Connection.ConnectionPath());

                //(15/06/2018-mfacine) Criar a variável que contém a instrução SQL
                string varSql = " UPDATE TB SET TB_TATUADOR" +
                                " I_COD_TURNO          = @I_COD_TURNO,         " +
                                " I_COD_ESPECIALIDADE  = @I_COD_ESPECIALIDADE, " +
                                " S_NM_TATUADOR        = @S_NM_TATUADOR,       " +
                                " S_CEL_TATUADOR       = @S_CEL_TATUADOR       " +
                                " WHERE I_COD_TATUADOR = @I_COD_TATUADOR";

                //(08/11/2019-mfacine) Criar objeto para executar o comando
                SqlCommand objCmd = new SqlCommand(varSql, objCon);
                objCmd.Parameters.AddWithValue("@I_COD_TATUADOR", aobj_Tatuador.COD_TATUADOR);
                objCmd.Parameters.AddWithValue("@I_COD_TURNO", aobj_Tatuador.COD_TURNO);
                objCmd.Parameters.AddWithValue("@I_COD_ESPECIALIDADE", aobj_Tatuador.COD_ESPECIALIDADE);
                objCmd.Parameters.AddWithValue("@S_NM_TATUADOR", aobj_Tatuador.NM_TATUADOR);
                objCmd.Parameters.AddWithValue("@S_CEL_TATUADOR", aobj_Tatuador.CEL_TATUADOR);
                try
                {
                    //(08/11/2019-mfacine) Abrir a conexão com o banco de dados
                    objCon.Open();

                    //(08/11/2019-mfacine) Executar o comando
                    objCmd.ExecuteNonQuery();

                    //(08/11/2018-mfacine) fechar a conexão
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
        * Parametros     : Objeto da Classe Tatuador
        * Data  Criação  : 08/11/2018
        * Data Alteração : -
        * Escrito por    : Mfacine (Monstro)
        * Observações    : Utiliza a Classe Connection para acessar o Base de Dados
        * ***************************************************************************/
        public Boolean Excluir(Tatuador aobj_Tatuador)
        {
            //(08/11/2018-mfacine) Criar objeto para conexão com o banco de dados
            SqlConnection ObjCon = new SqlConnection(Connection.ConnectionPath());

            //(08/11/2018-mfacine) Criar uma váriavel que contém a instrução SQL
            string varSql = " DELETE FROM TB_TATUADOR " +
                            " WHERE I_COD_TATUADOR = @I_COD_TATUADOR";

            //(15/06/2018-mfacine) Criar objeto para executar o comando
            SqlCommand objCmd = new SqlCommand(varSql, ObjCon);
            objCmd.Parameters.AddWithValue("@I_COD_TATUADOR", aobj_Tatuador.COD_TATUADOR);

            try
            {
                //(15/06/2018-mfacine) Abrir a conexão com o banco de dados
                ObjCon.Open();

                //(15/06/2018-mfacine) Executar o comando para excluir o registro
                objCmd.ExecuteNonQuery();

                //(15/06/2018-mfacine) Fechar a conexão com o banco de dados
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
        * Nome           : FindByCodTatuador
        * Procedimento   : Responsável por encontrar o Objeto na Base de Dados
        *                  Método para Buscar um registro na tabela TB_TATUADOR
        * Parametros     : Objeto da Classe Tatuador
        * Data  Criação  : 08/11/2018
        * Data Alteração : -
        * Escrito por    : Mfacine (Monstro)
        * Observações    : Utiliza a Classe Connection para acessar o Base de Dados
        * ***************************************************************************/
        public Tatuador FindByCodTatuador(Tatuador aobj_Tatuador)
        {
            //(08/11/2018-Mfacine) Criar objeto para conexão com o banco de dados
            SqlConnection objCon = new SqlConnection(Connection.ConnectionPath());

            //(08/11/2018-Mfacine) Criar uma váriavel que contém a instrução SQL
            string varSql = " SELECT * FROM TB_TATUADOR " +
                            " WHERE I_COD_TATUADOR = @I_COD_TATUADOR ";

            //(08/11/2018-Mfacine) Criar objeto para executar o comando
            SqlCommand objCmd = new SqlCommand(varSql, objCon);
            objCmd.Parameters.AddWithValue("@I_COD_TATUADOR", aobj_Tatuador.COD_TATUADOR);

            try
            {
                //(08/11/2018-Mfacine) Abrir a conexão com o banco de dados
                objCon.Open();

                //(08/11/2018-Mfacine) Criar um objeto DataReader que irá receber os dados
                SqlDataReader objDtr = objCmd.ExecuteReader();

                if (objDtr.HasRows)
                {
                    //Ler os dados que estão no objeto DataReader 
                    objDtr.Read();

                    //(08/11/2018-mfacine) Recupero os valores (Tipo um Popula Objeto)
                    aobj_Tatuador.COD_TATUADOR = Convert.ToInt16(objDtr["I_COD_TATUADOR"]);
                    aobj_Tatuador.COD_TURNO = Convert.ToInt16(objDtr["I_COD_TURNO"]);
                    aobj_Tatuador.COD_ESPECIALIDADE = Convert.ToInt16(objDtr["I_COD_ESPECIALIDADE"]);
                    aobj_Tatuador.NM_TATUADOR = objDtr["S_NM_TATUADOR"].ToString();
                    aobj_Tatuador.CEL_TATUADOR = objDtr["S_CEL_TATUADOR"].ToString();

                }

                objCon.Close();
                objDtr.Close();
                return aobj_Tatuador;
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "ERRO FATAL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return aobj_Tatuador;
            }
        }


        /****************************************************************************
        * Nome           : FindAllTatuador
        * Procedimento   : Responsável por encontrar todos os Objetos na Base de Dados
        *                   Método para Buscar uma lista de registros 
        * Parametros     : Objeto da Classe Tatuador
        * Data Criação   : 11/11/2019
        * Data Alteração : -
        * Escrito por    : Mfacine(Monstro)
        * Observações    : Utiliza a Classe Connection para acessar o Base de Dados
        * ***************************************************************************/
        public List<Tatuador> FindAllTatuador()
        {
            SqlConnection objCon = new SqlConnection(Connection.ConnectionPath());
            string varSql = " SELECT * FROM TB_TATUADOR ";
            SqlCommand objCmd = new SqlCommand(varSql, objCon);
            try
            {
                objCon.Open();
                SqlDataReader objDtr = objCmd.ExecuteReader();

                List<Tatuador> aLista = new List<Tatuador>();

                if (objDtr.HasRows)
                {
                    while (objDtr.Read())
                    {
                        Tatuador aobj_Tatuador = new Tatuador();

                        aobj_Tatuador.COD_TATUADOR = Convert.ToInt16(objDtr["I_COD_TATUADOR"]);
                        aobj_Tatuador.COD_TURNO = Convert.ToInt16(objDtr["I_COD_TURNO"]);
                        aobj_Tatuador.COD_ESPECIALIDADE = Convert.ToInt16(objDtr["I_COD_ESPECIALIDADE"]);
                        aobj_Tatuador.NM_TATUADOR = objDtr["S_NM_TATUADOR"].ToString();
                        aobj_Tatuador.CEL_TATUADOR = objDtr["S_CEL_TATUADOR"].ToString();

                        aLista.Add(aobj_Tatuador);

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
