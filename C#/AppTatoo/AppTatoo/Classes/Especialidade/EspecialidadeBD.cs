/*****************************************************************************
* Nome           : EspecialidadeBD
* Classe         : Representação da classe que se conecta com o banco através 
*                  da entidade Especialidade
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
    class EspecialidadeBD
    {
        //05/11/2019 - Mfacine - ToDo: criar uma classe de funções gerais (FuncGeral)

        /*****************************************************************************
        * Nome           : Incluir
        * Procedimento   : Responsável por incluir o Objeto na Base de Dados
        *                  Método para inclui um registro na tabela Especialidade
        * Parametros     : Objeto da Classe Especialidade
        * Data  Criação  : 12/11/2019
        * Data Alteração : -
        * Escrito por    : Mfacine (Monstro)
        * Observações    : Utiliza a Classe Connection para acessar o Base de Dados
        * ***************************************************************************/
        public int Incluir(Especialidade aobj_Especialidade)
        {
            //12/11/2019 - Mfacine - Criar objeto de conexão com o banco de dados
            SqlConnection objCon = new SqlConnection(Connection.ConnectionPath());

            //12/11/2018 - Mfacine - Criar a variável que contém a instrução SQL
            string varSql = "INSERT INTO TB_ESPECIALIDADE " +
                            "(" +
                            " S_TIT_ESPECIALIDADE,   " +
                            " T_DESC_ESPECIALIDADE  " +
                            ")" +
                            "VALUES " +
                            "(" +
                            " @S_TIT_ESPECIALIDADE,   " +
                            " @T_DESC_ESPECIALIDADE  " +
                            "); " +
                            "SELECT ident_current('TB_ESPECIALIDADE') as 'id'";

            //12/11/2019 - mfacine - Criar objeto para executar o comando
            SqlCommand objCmd = new SqlCommand(varSql, objCon);

            objCmd.Parameters.AddWithValue("@S_TIT_ESPECIALIDADE", aobj_Especialidade.TIT_ESPECIALIDADE);
            objCmd.Parameters.AddWithValue("@T_DESC_ESPECIALIDADE", aobj_Especialidade.DESC_ESPECIALIDADE);

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
        *                  Método para Alteração de um registro na tabela Especialidade
        * Parametros     : Objeto da Classe Especialidade
        * Data  Criação  : 12/11/2018
        * Data Alteração : -
        * Escrito por    : Mfacine (Monstro)
        * Observações    : Utiliza a Classe Connection para acessar o Base de Dados
        * ***************************************************************************/
        public Boolean Alterar(Especialidade aobj_Especialidade)
        {


            if (aobj_Especialidade.COD_ESPECIALIDADE != -1)
            {
                //(12/11/2018-mfacine) Criar objeto de conexão com o banco de dados
                SqlConnection objCon = new SqlConnection(Connection.ConnectionPath());

                //(12/11/2018-mfacine) Criar a variável que contém a instrução SQL
                string varSql = " UPDATE TB_ESPECIALIDADE SET " +
                                " S_TIT_ESPECIALIDADE    = @S_TIT_ESPECIALIDADE,    " +
                                " T_DESC_ESPECIALIDADE   = @T_DESC_ESPECIALIDADE   " +
                                " WHERE I_COD_ESPECIALIDADE = @I_COD_ESPECIALIDADE";

                //(12/11/2019-mfacine) Criar objeto para executar o comando
                SqlCommand objCmd = new SqlCommand(varSql, objCon);
                objCmd.Parameters.AddWithValue("@I_COD_ESPECIALIDADE", aobj_Especialidade.COD_ESPECIALIDADE);
                objCmd.Parameters.AddWithValue("@S_TIT_ESPECIALIDADE", aobj_Especialidade.TIT_ESPECIALIDADE);
                objCmd.Parameters.AddWithValue("@T_DESC_ESPECIALIDADE", aobj_Especialidade.DESC_ESPECIALIDADE);

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
        * Parametros     : Objeto da Classe Especialidade
        * Data  Criação  : 12/11/2018
        * Data Alteração : -
        * Escrito por    : Mfacine (Monstro)
        * Observações    : Utiliza a Classe Connection para acessar o Base de Dados
        * ***************************************************************************/
        public Boolean Excluir(Especialidade aobj_Especialidade)
        {
            //(12/11/2018-mfacine) Criar objeto para conexão com o banco de dados
            SqlConnection ObjCon = new SqlConnection(Connection.ConnectionPath());

            //(12/11/2018-mfacine) Criar uma váriavel que contém a instrução SQL
            string varSql = " DELETE FROM TB_ESPECIALIDADE " +
                            " WHERE I_COD_ESPECIALIDADE = @I_COD_ESPECIALIDADE";

            //(12/11/2018-mfacine) Criar objeto para executar o comando
            SqlCommand objCmd = new SqlCommand(varSql, ObjCon);
            objCmd.Parameters.AddWithValue("@I_COD_ESPECIALIDADE", aobj_Especialidade.COD_ESPECIALIDADE);

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
        * Nome           : FindByCodEspecialidade
        * Procedimento   : Responsável por encontrar o Objeto na Base de Dados
        *                  Método para Buscar um registro na tabela TB_ESPECIALIDADE
        * Parametros     : Objeto da Classe Especialidade
        * Data  Criação  : 12/11/2018
        * Data Alteração : -
        * Escrito por    : Mfacine (Monstro)
        * Observações    : Utiliza a Classe Connection para acessar o Base de Dados
        * ***************************************************************************/
        public Especialidade FindByCodEspecialidade(Especialidade aobj_Especialidade)
        {
            //(12/11/2018-Mfacine) Criar objeto para conexão com o banco de dados
            SqlConnection objCon = new SqlConnection(Connection.ConnectionPath());

            //(12/11/2018-Mfacine) Criar uma váriavel que contém a instrução SQL
            string varSql = " SELECT * FROM TB_ESPECIALIDADE " +
                            " WHERE I_COD_ESPECIALIDADE = @I_COD_ESPECIALIDADE ";

            //(12/11/2018-Mfacine) Criar objeto para executar o comando
            SqlCommand objCmd = new SqlCommand(varSql, objCon);
            objCmd.Parameters.AddWithValue("@I_COD_ESPECIALIDADE", aobj_Especialidade.COD_ESPECIALIDADE);

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

                    aobj_Especialidade.COD_ESPECIALIDADE = Convert.ToInt16(objDtr["I_COD_ESPECIALIDADE"]);
                    aobj_Especialidade.TIT_ESPECIALIDADE = objDtr["S_TIT_ESPECIALIDADE"].ToString();
                    aobj_Especialidade.DESC_ESPECIALIDADE = objDtr["T_DESC_ESPECIALIDADE"].ToString();

                }

                objCon.Close();
                objDtr.Close();
                return aobj_Especialidade;
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "ERRO FATAL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return aobj_Especialidade;
            }
        }


        /****************************************************************************
        * Nome           : FindAllEspecialidade
        * Procedimento   : Responsável por encontrar todos os Objetos na Base de Dados
        *                   Método para Buscar uma lista de registros 
        * Parametros     : Objeto da Classe Especialidade
        * Data Criação   : 12/11/2019
        * Data Alteração : -
        * Escrito por    : Mfacine(Monstro)
        * Observações    : Utiliza a Classe Connection para acessar o Base de Dados
        * ***************************************************************************/
        public List<Especialidade> FindAllEspecialidade()
        {
            SqlConnection objCon = new SqlConnection(Connection.ConnectionPath());
            string varSql = " SELECT * FROM TB_ESPECIALIDADE ";
            SqlCommand objCmd = new SqlCommand(varSql, objCon);
            try
            {
                objCon.Open();
                SqlDataReader objDtr = objCmd.ExecuteReader();

                List<Especialidade> aLista = new List<Especialidade>();

                if (objDtr.HasRows)
                {
                    while (objDtr.Read())
                    {
                        Especialidade aobj_Especialidade = new Especialidade();

                        aobj_Especialidade.COD_ESPECIALIDADE = Convert.ToInt16(objDtr["I_COD_ESPECIALIDADE"]);
                        aobj_Especialidade.TIT_ESPECIALIDADE = objDtr["S_TIT_ESPECIALIDADE"].ToString();
                        aobj_Especialidade.DESC_ESPECIALIDADE = objDtr["T_DESC_ESPECIALIDADE"].ToString();

                        aLista.Add(aobj_Especialidade);

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
