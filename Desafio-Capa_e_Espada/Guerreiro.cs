using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_Capa_e_Espada
{
    class Guerreiro : Personagem
    {
        private int pontosForca;

        public Guerreiro(int id, string nome, int nivel,int pontosVida, int pontosExperiencia, int pontosForca, string alinhamento) : base(id, nome, nivel, pontosVida, pontosExperiencia, alinhamento)
        {
            this.pontosForca = pontosForca;
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

        public override void Atacar(ItemCombate ic)
        {
            
            foreach (var item in Armamentos)
            {
                if (ic.Armamento == item)
                {
                    if (PontosForca >= ic.Armamento.PontosForca)
                    {
                        PontosForca -= ic.Armamento.PontosForca;
                    }
                }
            }

            Console.WriteLine("O {0} está atacando com seu {1} causando {2} pontos de dano", Nome, ic.Armamento, ic.PontosDano);
        }

        public override void Exibir()
        {

        }
    }
}
