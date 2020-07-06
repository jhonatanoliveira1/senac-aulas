/**********************************************************************************
 * NOME:            Especialidade
 * CLASSE:          Representação da entidade Especialidade 
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
    class Especialidade
    {
        //(Mfacine - 01/11/2019) Metodo de Destruição da Classe
        ~Especialidade()
        {
        }

        //(Mfacine - 01/11/2019) Atributos/Propriedades Privadas Encapsuladas
        int VCOD_ESPECIALIDADE = -1;
        string VTIT_ESPECIALIDADE = null;
        string VDESC_ESPECIALIDADE = null;

        //(Mfacine - 01/11/2019) Metodos Públicos

        /***********************************************************************
        * NOME:            COD_ESPECIALIDADE     
        * METODO:          Representação do atributo Código com os métodos 
        *                  Get e Set          
        * DT CRIAÇÃO:      01/11/2019    
        * DT ALTERAÇÃO:    -
        * ESCRITA POR:     Mfacine
        **********************************************************************/
        public int COD_ESPECIALIDADE
        {
            get { return VCOD_ESPECIALIDADE; }
            set { VCOD_ESPECIALIDADE = value; }
        }

        /***********************************************************************
        * NOME:            TIT_ESPECIALIDADE     
        * METODO:          Representação do atributo Titulo com os métodos 
        *                  Get e Set          
        * DT CRIAÇÃO:      04/11/2019    
        * DT ALTERAÇÃO:    -
        * ESCRITA POR:     Mfacine
        **********************************************************************/
        public string TIT_ESPECIALIDADE
        {
            get { return VTIT_ESPECIALIDADE; }
            set { VTIT_ESPECIALIDADE = value; }
        }


        /***********************************************************************
        * NOME:            DESC_ESPECIALIDADE     
        * METODO:          Representação do atributo descrição com os métodos 
        *                  Get e Set          
        * DT CRIAÇÃO:      04/11/2019    
        * DT ALTERAÇÃO:    -
        * ESCRITA POR:     Mfacine
        **********************************************************************/
        public string DESC_ESPECIALIDADE
        {
            get { return VDESC_ESPECIALIDADE; }
            set { VDESC_ESPECIALIDADE = value; }
        }

    }
}
