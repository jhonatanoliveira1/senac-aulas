/**********************************************************************************
 * NOME:            Turno
 * CLASSE:          Representação da entidade Turno 
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
    class Turno
    {
        //(Mfacine - 04/11/2019) Metodo de Destruição da Classe
        ~Turno()
        {
        }

        //(Mfacine - 04/11/2019) Atributos/Propriedades Privadas Encapsuladas
        int VCOD_TURNO = -1;
        string VSEM_TURNO = null;
        string VPER_TURNO = null;

        //(Mfacine - 04/11/2019) Metodos Públicos

        /***********************************************************************
        * NOME:            COD_TURNO     
        * METODO:          Representação do atributo Código do turno com os métodos 
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
        * NOME:            SEM_TURNO     
        * METODO:          Representação do atributo semana com os métodos 
        *                  Get e Set          
        * DT CRIAÇÃO:      04/11/2019    
        * DT ALTERAÇÃO:    -
        * ESCRITA POR:     Mfacine
        **********************************************************************/
        public string SEM_TURNO
        {
            get { return VSEM_TURNO; }
            set { VSEM_TURNO = value; }
        }


        /***********************************************************************
        * NOME:            PER_TURNO     
        * METODO:          Representação do atributo periodo com os métodos 
        *                  Get e Set          
        * DT CRIAÇÃO:      04/11/2019    
        * DT ALTERAÇÃO:    -
        * ESCRITA POR:     Mfacine
        **********************************************************************/
        public string PER_TURNO
        {
            get { return VPER_TURNO; }
            set { VPER_TURNO = value; }
        }

    }
}
