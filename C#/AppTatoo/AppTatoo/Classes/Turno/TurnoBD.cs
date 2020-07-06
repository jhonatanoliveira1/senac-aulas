/*****************************************************************************
* Nome           : TurnoBD
* Classe         : Representação da classe que se conecta com o banco através 
*                  da entidade Turno
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
    class TurnoBD
    {
        //05/11/2019 - Mfacine - ToDo: criar uma classe de funções gerais (FuncGeral)

        /*****************************************************************************
        * Nome           : Incluir
        * Procedimento   : Responsável por incluir o Objeto na Base de Dados
        *                  Método para inclui um registro na tabela Turno
        * Parametros     : Objeto da Classe Turno
        * Data  Criação  : 12/11/2019
        * Data Alteração : -
        * Escrito por    : Mfacine (Monstro)
        * Observações    : Utiliza a Classe Connection para acessar o Base de Dados
        * ***************************************************************************/
        public int Incluir(Turno aobj_Turno)
        {
            //12/11/2019 - Mfacine - Criar objeto de conexão com o banco de dados
            SqlConnection objCon = new SqlConnection(Connection.ConnectionPath());

            //12/11/2018 - Mfacine - Criar a variável que contém a instrução SQL
            string varSql = "INSERT INTO TB_TURNO " +
                            "(" +
                            " S_SEM_TURNO,   " +
                            " S_PER_TURNO  " +
                            ")" +
                            "VALUES " +
                            "(" +
                            " @S_SEM_TURNO,   " +
                            " @S_PER_TURNO  " +
                            "); " +
                            "SELECT ident_current('TB_TURNO') as 'id'";

            //12/11/2019 - mfacine - Criar objeto para executar o comando
            SqlCommand objCmd = new SqlCommand(varSql, objCon);

            objCmd.Parameters.AddWithValue("@S_SEM_TURNO", aobj_Turno.SEM_TURNO);
            objCmd.Parameters.AddWithValue("@S_PER_TURNO", aobj_Turno.PER_TURNO);

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
        *                  Método para Alteração de um registro na tabela Turno
        * Parametros     : Objeto da Classe Turno
        * Data  Criação  : 12/11/2018
        * Data Alteração : -
        * Escrito por    : Mfacine (Monstro)
        * Observações    : Utiliza a Classe Connection para acessar o Base de Dados
        * ***************************************************************************/
        public Boolean Alterar(Turno aobj_Turno)
        {


            if (aobj_Turno.COD_TURNO != -1)
            {
                //(12/11/2018-mfacine) Criar objeto de conexão com o banco de dados
                SqlConnection objCon = new SqlConnection(Connection.ConnectionPath());

                //(12/11/2018-mfacine) Criar a variável que contém a instrução SQL
                string varSql = " UPDATE TB_TURNO SET " +
                                " S_SEM_TURNO    = @S_SEM_TURNO,    " +
                                " S_PER_TURNO    = @S_PER_TURNO   " +
                                " WHERE I_COD_TURNO = @I_COD_TURNO";

                //(12/11/2019-mfacine) Criar objeto para executar o comando
                SqlCommand objCmd = new SqlCommand(varSql, objCon);
                objCmd.Parameters.AddWithValue("@I_COD_TURNO", aobj_Turno.COD_TURNO);
                objCmd.Parameters.AddWithValue("@S_SEM_TURNO", aobj_Turno.SEM_TURNO);
                objCmd.Parameters.AddWithValue("@S_PER_TURNO", aobj_Turno.PER_TURNO);

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
        * Parametros     : Objeto da Classe Turno
        * Data  Criação  : 12/11/2018
        * Data Alteração : -
        * Escrito por    : Mfacine (Monstro)
        * Observações    : Utiliza a Classe Connection para acessar o Base de Dados
        * ***************************************************************************/
        public Boolean Excluir(Turno aobj_Turno)
        {
            //(12/11/2018-mfacine) Criar objeto para conexão com o banco de dados
            SqlConnection ObjCon = new SqlConnection(Connection.ConnectionPath());

            //(12/11/2018-mfacine) Criar uma váriavel que contém a instrução SQL
            string varSql = " DELETE FROM TB_TURNO " +
                            " WHERE I_COD_TURNO = @I_COD_TURNO";

            //(12/11/2018-mfacine) Criar objeto para executar o comando
            SqlCommand objCmd = new SqlCommand(varSql, ObjCon);
            objCmd.Parameters.AddWithValue("@I_COD_TURNO", aobj_Turno.COD_TURNO);

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
        * Nome           : FindByCodTurno
        * Procedimento   : Responsável por encontrar o Objeto na Base de Dados
        *                  Método para Buscar um registro na tabela TB_TURNO
        * Parametros     : Objeto da Classe Turno
        * Data  Criação  : 12/11/2018
        * Data Alteração : -
        * Escrito por    : Mfacine (Monstro)
        * Observações    : Utiliza a Classe Connection para acessar o Base de Dados
        * ***************************************************************************/
        public Turno FindByCodTurno(Turno aobj_Turno)
        {
            //(12/11/2018-Mfacine) Criar objeto para conexão com o banco de dados
            SqlConnection objCon = new SqlConnection(Connection.ConnectionPath());

            //(12/11/2018-Mfacine) Criar uma váriavel que contém a instrução SQL
            string varSql = " SELECT * FROM TB_TURNO " +
                            " WHERE I_COD_TURNO = @I_COD_TURNO ";

            //(12/11/2018-Mfacine) Criar objeto para executar o comando
            SqlCommand objCmd = new SqlCommand(varSql, objCon);
            objCmd.Parameters.AddWithValue("@I_COD_TURNO", aobj_Turno.COD_TURNO);

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

                    aobj_Turno.COD_TURNO = Convert.ToInt16(objDtr["I_COD_TURNO"]);
                    aobj_Turno.SEM_TURNO = objDtr["S_SEM_TURNO"].ToString();
                    aobj_Turno.PER_TURNO = objDtr["S_PER_TURNO"].ToString();

                }

                objCon.Close();
                objDtr.Close();
                return aobj_Turno;
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "ERRO FATAL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return aobj_Turno;
            }
        }


        /****************************************************************************
        * Nome           : FindAllTurno
        * Procedimento   : Responsável por encontrar todos os Objetos na Base de Dados
        *                   Método para Buscar uma lista de registros 
        * Parametros     : Objeto da Classe Turno
        * Data Criação   : 12/11/2019
        * Data Alteração : -
        * Escrito por    : Mfacine(Monstro)
        * Observações    : Utiliza a Classe Connection para acessar o Base de Dados
        * ***************************************************************************/
        public List<Turno> FindAllTurno()
        {
            SqlConnection objCon = new SqlConnection(Connection.ConnectionPath());
            string varSql = " SELECT * FROM TB_TURNO ";
            SqlCommand objCmd = new SqlCommand(varSql, objCon);
            try
            {
                objCon.Open();
                SqlDataReader objDtr = objCmd.ExecuteReader();

                List<Turno> aLista = new List<Turno>();

                if (objDtr.HasRows)
                {
                    while (objDtr.Read())
                    {
                        Turno aobj_Turno = new Turno();

                        aobj_Turno.COD_TURNO = Convert.ToInt16(objDtr["I_COD_TURNO"]);
                        aobj_Turno.SEM_TURNO = objDtr["S_SEM_TURNO"].ToString();
                        aobj_Turno.PER_TURNO = objDtr["S_PER_TURNO"].ToString();

                        aLista.Add(aobj_Turno);

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
