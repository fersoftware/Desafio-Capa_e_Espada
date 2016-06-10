using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_Capa_e_Espada
{
    class Poder
    {
        private int pontosMagia;

        public Poder(int pontosMagia)
        {
            this.PontosMagia = pontosMagia;
        }

        public int PontosMagia
        {
            get
            {
                return pontosMagia;
            }

            set
            {
                pontosMagia = value;
            }
        }
    }
}
