using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_Capa_e_Espada
{
    abstract class ItemCombate : Item
    {
        private int pontosDano;
        private Armamento armamento;
        private Poder poder;

        public ItemCombate(int pontosDano)
        {
            this.PontosDano = pontosDano;
        }

        public int PontosDano
        {
            get
            {
                return pontosDano;
            }

            set
            {
                pontosDano = value;
            }
        }

        public Armamento Armamento
        {
            get
            {
                return armamento;
            }

            set
            {
                armamento = value;
            }
        }

        public Poder Poder
        {
            get
            {
                return poder;
            }

            set
            {
                poder = value;
            }
        }
    }
}
