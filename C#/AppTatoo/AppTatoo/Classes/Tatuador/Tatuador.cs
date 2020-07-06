/**********************************************************************************
 * NOME:            Tatuador
 * CLASSE:          Representação da entidade Tatuador 
 * DT CRIAÇÃO:      04/11/2019
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
    class Tatuador
    {
        //(Mfacine - 04/11/2019) Metodo de Destruição da Classe
        ~Tatuador()
        {
        }

        //(Mfacine - 04/11/2019) Atributos/Propriedades Privadas Encapsuladas
        int VCOD_TATUADOR = -1;
        int VCOD_TURNO = -1;
        int VCOD_ESPECIALIDADE = -1;
        string VNM_TATUADOR = null;
        string VCEL_TATUADOR = null;
        

        //(Mfacine - 04/11/2019) Metodos Públicos

        /***********************************************************************
        * NOME:            COD_TATUADOR     
        * METODO:          Representação do atributo Código Tatuador com os métodos 
        *                  Get e Set          
        * DT CRIAÇÃO:      04/11/2019    
        * DT ALTERAÇÃO:    -
        * ESCRITA POR:     Mfacine
        **********************************************************************/
        public int COD_TATUADOR
        {
            get { return VCOD_TATUADOR; }
            set { VCOD_TATUADOR = value; }
        }

        /***********************************************************************
        * NOME:            COD_TURNO   
        * METODO:          Representação do atributo código do turno com os métodos 
        *                  Get e Set          
        * DT CRIAÇÃO:      04/11/2019    
        * DT ALTERAÇÃO:    -
        * ESCRITA POR:     Mfacine
        **********************************************************************/
        public int COD_TURNO
        {
            get { return VCOD_TURNO; }
            set { VCOD_TURNO = value; }
        }


        /***********************************************************************
        * NOME:            COD_ESPECIALIDADE     
        * METODO:          Representação do atributo código da especialidade com os métodos 
        *                  Get e Set          
        * DT CRIAÇÃO:      04/11/2019    
        * DT ALTERAÇÃO:    -
        * ESCRITA POR:     Mfacine
        **********************************************************************/
        public int COD_ESPECIALIDADE
        {
            get { return VCOD_ESPECIALIDADE; }
            set { VCOD_ESPECIALIDADE = value; }
        }


        /***********************************************************************
        * NOME:            NM_TATUADOR     
        * METODO:          Representação do atributo Nome com os métodos 
        *                  Get e Set          
        * DT CRIAÇÃO:      04/11/2019    
        * DT ALTERAÇÃO:    -
        * ESCRITA POR:     Mfacine
        **********************************************************************/
        public string NM_TATUADOR
        {
            get { return VNM_TATUADOR; }
            set { VNM_TATUADOR = value; }
        }

        /***********************************************************************
        * NOME:            CEL_TATUADOR     
        * METODO:          Representação do atributo celular com os métodos 
        *                  Get e Set          
        * DT CRIAÇÃO:      04/11/2019    
        * DT ALTERAÇÃO:    -
        * ESCRITA POR:     Mfacine
        **********************************************************************/
        public string CEL_TATUADOR
        {
            get { return VCEL_TATUADOR; }
            set { VCEL_TATUADOR = value; }
        }

        
    }
}