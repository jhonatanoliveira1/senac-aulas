/**********************************************************************************
 * NOME:            Tema
 * CLASSE:          Representação da entidade Tema 
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
    class Tema
    {
        //(Mfacine - 01/11/2019) Metodo de Destruição da Classe
        ~Tema()
        {
        }

        //(Mfacine - 01/11/2019) Atributos/Propriedades Privadas Encapsuladas
        int VCOD_TEMA = -1;
        string VTIT_TEMA = null;
        string VDESC_TEMA = null;

        //(Mfacine - 01/11/2019) Metodos Públicos

        /***********************************************************************
        * NOME:            COD_TEMA     
        * METODO:          Representação do atributo Código com os métodos 
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
        * NOME:            TIT_TEMA     
        * METODO:          Representação do atributo Título com os métodos 
        *                  Get e Set          
        * DT CRIAÇÃO:      01/11/2019    
        * DT ALTERAÇÃO:    -
        * ESCRITA POR:     Mfacine
        **********************************************************************/
        public string TIT_TEMA
        {
            get { return VTIT_TEMA; }
            set { VTIT_TEMA = value; }
        }


        /***********************************************************************
        * NOME:            DESC_TEMA     
        * METODO:          Representação do atributo Descrição com os métodos 
        *                  Get e Set          
        * DT CRIAÇÃO:      01/11/2019    
        * DT ALTERAÇÃO:    -
        * ESCRITA POR:     Mfacine
        **********************************************************************/
        public string DESC_TEMA
        {
            get { return VDESC_TEMA; }
            set { VDESC_TEMA = value; }
        }


    }
}
