using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_Capa_e_Espada
{
    class ItemDefesa : Item
    {
        private int pontosDefesa;

        public ItemDefesa(int id, string nome) : base(id, nome)
        {
        }
    }
}
