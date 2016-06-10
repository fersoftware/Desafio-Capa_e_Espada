using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_Capa_e_Espada
{
    class Mago : Personagem
    {
        private int pontosMagia;

        public Mago(int id, string nome, int nivel, int pontosVida, int pontosExperiencia, string alinhamento) : base(id, nome, nivel, pontosVida, pontosExperiencia, alinhamento)
        {
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

        public override void Atacar(ItemCombate ic)
        {
            foreach (var item in Poderes )
            {
                if (ic.Poder == item)
                {
                    if (pontosMagia >= ic.Poder.PontosMagia)
                    {
                        pontosMagia -= ic.Poder.PontosMagia;
                    }
                }
            }
            
            Console.WriteLine("O {0} está atacando com seu {1} causando {2} pontos de dano", Nome, ic.Poder, ic.PontosDano);
        }

        public override void UsarItem(ItemMagico im)
        {

        }

        public override void Exibir()
        {

        }
    }
}
