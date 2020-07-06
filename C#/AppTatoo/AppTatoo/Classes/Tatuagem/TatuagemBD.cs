/*****************************************************************************
* Nome           : TatuagemBD
* Classe         : Representação da classe que se conecta com o banco através 
*                  da entidade Tatuagem
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
    class TatuagemBD
    {
        //05/11/2019 - Mfacine - ToDo: criar uma classe de funções gerais (FuncGeral)
        
        /*****************************************************************************
        * Nome           : Incluir
        * Procedimento   : Responsável por incluir o Objeto na Base de Dados
        *                  Método para inclui um registro na tabela Tatuagem
        * Parametros     : Objeto da Classe Tatuagem
        * Data  Criação  : 05/11/2019
        * Data Alteração : -
        * Escrito por    : Mfacine (Monstro)
        * Observações    : Utiliza a Classe Connection para acessar o Base de Dados
        * ***************************************************************************/
        public int Incluir(Tatuagem aobj_Tatuagem)
        {
            //05/11/2019 - Mfacine - Criar objeto de conexão com o banco de dados
            SqlConnection objCon = new SqlConnection(Connection.ConnectionPath());

            //05/11/2018 - Mfacine - Criar a variável que contém a instrução SQL
            string varSql = "INSERT INTO TB_TATUAGEM " +
                            "(" +
                            " I_COD_TEMA,     " +
                            " I_TAM_TATUAGEM, " +
                            " S_NM_TATUAGEM,  " +
                            " I_COR_TATUAGEM  " +
                            ")" +
                            "VALUES " +
                            "(" +
                            " @I_COD_TEMA,     " +
                            " @I_TAM_TATUAGEM, " +
                            " @S_NM_TATUAGEM,  " +
                            " @I_COR_TATUAGEM  " +
                            "); " +
                            "SELECT ident_current('TB_TATUAGEM') as 'id'";

            //05/11/2019 - mfacine - Criar objeto para executar o comando
            SqlCommand objCmd = new SqlCommand(varSql, objCon);

            objCmd.Parameters.AddWithValue("@I_COD_TEMA", aobj_Tatuagem.COD_TEMA);
            objCmd.Parameters.AddWithValue("@I_TAM_TATUAGEM", aobj_Tatuagem.TAM_TATUAGEM);
            objCmd.Parameters.AddWithValue("@S_NM_TATUAGEM", aobj_Tatuagem.NM_TATUAGEM);
            objCmd.Parameters.AddWithValue("@I_COR_TATUAGEM", aobj_Tatuagem.COR_TATUAGEM);

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
        *                  Método para Alteração de um registro na tabela Tatuagem
        * Parametros     : Objeto da Classe Tatuagem
        * Data  Criação  : 08/11/2018
        * Data Alteração : -
        * Escrito por    : Mfacine (Monstro)
        * Observações    : Utiliza a Classe Connection para acessar o Base de Dados
        * ***************************************************************************/
        public Boolean Alterar(Tatuagem aobj_Tatuagem)
        {


            if (aobj_Tatuagem.COD_TATUAGEM != -1)
            {
                //(08/11/2018-mfacine) Criar objeto de conexão com o banco de dados
                SqlConnection objCon = new SqlConnection(Connection.ConnectionPath());

                //(15/06/2018-mfacine) Criar a variável que contém a instrução SQL
                string varSql = " UPDATE TB SET TB_TATUAGEM" +
                                " I_COD_TEMA     = @I_COD_TEMA, " +
                                " I_TAM_TATUAGEM = @I_TAM_TATUAGEM, " +
                                " S_NM_TATUAGEM  = @S_NM_TATUAGEM, " +
                                " I_COR_TATUAGEM = @I_COR_TATUAGEM " +
                                " WHERE I_COD_TATUAGEM = @I_COD_TATUAGEM";

                //(08/11/2019-mfacine) Criar objeto para executar o comando
                SqlCommand objCmd = new SqlCommand(varSql, objCon);
                objCmd.Parameters.AddWithValue("@I_COD_TATUAGEM", aobj_Tatuagem.COD_TATUAGEM);
                objCmd.Parameters.AddWithValue("@I_COD_TEMA", aobj_Tatuagem.COD_TEMA);
                objCmd.Parameters.AddWithValue("@I_TAM_TATUAGEM", aobj_Tatuagem.TAM_TATUAGEM);
                objCmd.Parameters.AddWithValue("@S_NM_TATUAGEM", aobj_Tatuagem.NM_TATUAGEM);
                objCmd.Parameters.AddWithValue("@I_COR_TATUAGEM", aobj_Tatuagem.COR_TATUAGEM);
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
        * Parametros     : Objeto da Classe Tatuagem
        * Data  Criação  : 08/11/2018
        * Data Alteração : -
        * Escrito por    : Mfacine (Monstro)
        * Observações    : Utiliza a Classe Connection para acessar o Base de Dados
        * ***************************************************************************/
        public Boolean Excluir(Tatuagem aobj_Tatuagem)
        {
            //(08/11/2018-mfacine) Criar objeto para conexão com o banco de dados
            SqlConnection ObjCon = new SqlConnection(Connection.ConnectionPath());

            //(08/11/2018-mfacine) Criar uma váriavel que contém a instrução SQL
            string varSql = " DELETE FROM TB_TATUAGEM "+
                            " WHERE I_COD_TATUAGEM = @I_COD_TATUAGEM";

            //(15/06/2018-mfacine) Criar objeto para executar o comando
             SqlCommand objCmd = new SqlCommand(varSql, ObjCon);
            objCmd.Parameters.AddWithValue("@I_COD_TATUAGEM", aobj_Tatuagem.COD_TATUAGEM);

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
        * Nome           : FindByCodTatuagem
        * Procedimento   : Responsável por encontrar o Objeto na Base de Dados
        *                  Método para Buscar um registro na tabela TB_TATUAGEM
        * Parametros     : Objeto da Classe Tatuagem
        * Data  Criação  : 08/11/2018
        * Data Alteração : -
        * Escrito por    : Mfacine (Monstro)
        * Observações    : Utiliza a Classe Connection para acessar o Base de Dados
        * ***************************************************************************/
        public Tatuagem FindByCodTatuagem(Tatuagem aobj_Tatuagem)
        {
            //(08/11/2018-Mfacine) Criar objeto para conexão com o banco de dados
            SqlConnection objCon = new SqlConnection(Connection.ConnectionPath());

            //(08/11/2018-Mfacine) Criar uma váriavel que contém a instrução SQL
            string varSql = " SELECT * FROM TB_TATUAGEM " +
                            " WHERE I_COD_TATUAGEM = @I_COD_TATUAGEM ";

            //(08/11/2018-Mfacine) Criar objeto para executar o comando
            SqlCommand objCmd = new SqlCommand(varSql, objCon);
            objCmd.Parameters.AddWithValue("@I_COD_TATUAGEM", aobj_Tatuagem.COD_TATUAGEM);

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
                    aobj_Tatuagem.COD_TATUAGEM = Convert.ToInt16(objDtr["I_COD_TATUAGEM"]);
                    aobj_Tatuagem.COD_TEMA = Convert.ToInt16(objDtr["I_COD_TEMA"]);
                    aobj_Tatuagem.TAM_TATUAGEM = Convert.ToInt16(objDtr["I_TAM_TATUAGEM"]);
                    aobj_Tatuagem.NM_TATUAGEM = objDtr["S_NM_TATUAGEM"].ToString();
                    aobj_Tatuagem.COR_TATUAGEM = Convert.ToInt16(objDtr["I_COR_TATUAGEM"]);

                }

                objCon.Close();
                objDtr.Close();
                return aobj_Tatuagem;
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "ERRO FATAL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return aobj_Tatuagem;
            }
        }


        /****************************************************************************
        * Nome           : FindAllTatuagem
        * Procedimento   : Responsável por encontrar todos os Objetos na Base de Dados
        *                   Método para Buscar uma lista de registros 
        * Parametros     : Objeto da Classe Tatuagem
        * Data Criação   : 11/11/2019
        * Data Alteração : -
        * Escrito por    : Mfacine(Monstro)
        * Observações    : Utiliza a Classe Connection para acessar o Base de Dados
        * ***************************************************************************/
        public List<Tatuagem> FindAllTatuagem()
        {
            SqlConnection objCon = new SqlConnection(Connection.ConnectionPath());
            string varSql = " SELECT * FROM TB_TATUAGEM ";
            SqlCommand objCmd = new SqlCommand(varSql, objCon);
            try
            {
                objCon.Open();
                SqlDataReader objDtr = objCmd.ExecuteReader();

                List<Tatuagem> aLista = new List<Tatuagem>();

                if (objDtr.HasRows)
                {
                    while (objDtr.Read())
                    {
                        Tatuagem aobj_Tatuagem = new Tatuagem();

                        aobj_Tatuagem.COD_TATUAGEM = Convert.ToInt16(objDtr["I_COD_TATUAGEM"]);
                        aobj_Tatuagem.COD_TEMA = Convert.ToInt16(objDtr["I_COD_TEMA"]);
                        aobj_Tatuagem.TAM_TATUAGEM = Convert.ToInt16(objDtr["I_TAM_TATUAGEM"]);
                        aobj_Tatuagem.NM_TATUAGEM = objDtr["S_NM_TATUAGEM"].ToString();
                        aobj_Tatuagem.COR_TATUAGEM = Convert.ToInt16(objDtr["I_COR_TATUAGEM"]);

                        aLista.Add(aobj_Tatuagem);

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
