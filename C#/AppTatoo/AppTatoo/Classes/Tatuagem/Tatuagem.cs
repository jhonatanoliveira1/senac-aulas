/**********************************************************************************
 * NOME:            Tatuagem
 * CLASSE:          Representação da entidade Tatuagem 
 * DT CRIAÇÃO:      01/11/2019
 * DT ALTERAÇÃO:    -
 * ESCRITA POR:     Mfacine (Monstro)
 * OBSERVAÇÕES:     Atributos privados com métodos Get e Set públicos
 * ********************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTatoo
{
    class Tatuagem
    {
        //(Mfacine - 01/11/2019) Metodo de Destruição da Classe
        ~Tatuagem()
        {
        }

        //(Mfacine - 01/11/2019) Atributos/Propriedades Privadas Encapsuladas
        int VCOD_TATUAGEM = -1;
        int VCOD_TEMA = -1;
        int VTAM_TATUAGEM = 0;
        string VNM_TATUAGEM = null;
        int VCOR_TATUAGEM = 0;

        //(Mfacine - 01/11/2019) Metodos Públicos

        /***********************************************************************
        * NOME:            COD_TATUAGEM     
        * METODO:          Representação do atributo Código com os métodos 
        *                  Get e Set          
        * DT CRIAÇÃO:      01/11/2019    
        * DT ALTERAÇÃO:    -
        * ESCRITA POR:     Mfacine
        **********************************************************************/
        public int COD_TATUAGEM
        {
            get { return VCOD_TATUAGEM; }
            set { VCOD_TATUAGEM = value; }
        }

        /***********************************************************************
        * NOME:            COD_TEMA    
        * METODO:          Representação do atributo Tema com os métodos 
        *                  Get e Set          
        * DT CRIAÇÃO:      01/11/2019    
        * DT ALTERAÇÃO:    -
        * ESCRITA POR:     Mfacine
        **********************************************************************/
        public int COD_TEMA
        {
            get { return VCOD_TEMA; }
            set { VCOD_TEMA = value; }
        }


        /***********************************************************************
        * NOME:            TAM_TATUAGEM     
        * METODO:          Representação do atributo Tamanho com os métodos 
        *                  Get e Set          
        * DT CRIAÇÃO:      01/11/2019    
        * DT ALTERAÇÃO:    -
        * ESCRITA POR:     Mfacine
        **********************************************************************/
        public int TAM_TATUAGEM
        {
            get { return VTAM_TATUAGEM; }
            set { VTAM_TATUAGEM = value; }
        }


        /***********************************************************************
        * NOME:            NM_TATUAGEM     
        * METODO:          Representação do atributo Nome com os métodos 
        *                  Get e Set          
        * DT CRIAÇÃO:      01/11/2019    
        * DT ALTERAÇÃO:    -
        * ESCRITA POR:     Mfacine
        **********************************************************************/
        public string NM_TATUAGEM
        {
            get { return VNM_TATUAGEM; }
            set { VNM_TATUAGEM = value; }
        }


        /***********************************************************************
        * NOME:            COR_TATUAGEM     
        * METODO:          Representação do atributo Tamanho com os métodos 
        *                  Get e Set          
        * DT CRIAÇÃO:      01/11/2019    
        * DT ALTERAÇÃO:    -
        * ESCRITA POR:     Mfacine
        **********************************************************************/
        public int COR_TATUAGEM
        {
            get { return VCOR_TATUAGEM; }
            set { VCOR_TATUAGEM = value; }
        }

    }
}
