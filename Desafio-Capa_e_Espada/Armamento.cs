using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_Capa_e_Espada
{
    class Armamento : ItemCombate
    {
        private int pontosForca;

        public Armamento(int pontosDano) : base(pontosDano)
        {
        }

        public int PontosForca
        {
            get
            {
                return pontosForca;
            }

            set
            {
                pontosForca = value;
            }
        }
    }
}
