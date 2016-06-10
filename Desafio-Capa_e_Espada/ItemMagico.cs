using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_Capa_e_Espada
{
    class ItemMagico : Item
    {
        private int pontosVida;
        private int pontosForca;
        private int pontosMagia;

        public ItemMagico(int id, string nome) : base(id, nome)
        {
        }

        public int PontosVida
        {
            get
            {
                return pontosVida;
            }

            set
            {
                pontosVida = value;
            }
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
