using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_Capa_e_Espada
{
    class Poder : ItemCombate
    {
        private int pontosMagia;

        public Poder(int id, string nome, int pontosDano, int pontosMagia) : base(id, nome, pontosDano)
        {
            this.pontosMagia = pontosMagia;
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
