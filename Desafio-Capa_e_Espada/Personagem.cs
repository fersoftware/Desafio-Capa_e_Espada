using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_Capa_e_Espada
{
    abstract class Personagem
    {
        private int id;
        private string nome;
        private int nivel;
        private int pontosVida;
        private int pontosExperiencia;
        private string alinhamento;

        private ItemMagico itemMagico;
        private ItemDefesa itemDefesa;


        List<Poder> poderes = new List<Poder>();
        List<Armamento> armamentos = new List<Armamento>();
        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string Nome
        {
            get
            {
                return nome;
            }

            set
            {
                nome = value;
            }
        }

        public int Nivel
        {
            get
            {
                return nivel;
            }

            set
            {
                nivel = value;
            }
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

        public int PontosExperiencia
        {
            get
            {
                return pontosExperiencia;
            }

            set
            {
                pontosExperiencia = value;
            }
        }

        public string Alinhamento
        {
            get
            {
                return alinhamento;
            }

            set
            {
                alinhamento = value;
            }
        }

        public List<Poder> Poderes
        {
            get
            {
                return poderes;
            }

            set
            {
                poderes = value;
            }
        }

        public List<Armamento> Armamentos
        {
            get
            {
                return armamentos;
            }

            set
            {
                armamentos = value;
            }
        }

        public Personagem(int id, string nome, int nivel, int pontosVida, int pontosExperiencia, string alinhamento)
        {
            this.Id = id;
            this.Nome = nome;
            this.Nivel = nivel;
            this.PontosVida = pontosVida;
            this.PontosExperiencia = pontosExperiencia;
            this.Alinhamento = alinhamento;
        }

        public virtual void Exibir()
        {
        }
        
        public virtual void Atacar(ItemCombate ic)
        {
            if (ic.GetType().ToString().IndexOf("Guerreiro") >= 0)
            {
                foreach (var item in Armamentos)
                {
                    if (ic.Armamento == item)
                    {
                        if (guerreiro.PontosForca >= ic.Armamento.PontosForca)
                        {
                            guerreiro.PontosForca -= ic.Armamento.PontosForca;
                        }
                    }
                }
            }
            else
            {
                foreach (var item in Poderes)
                {
                    if (ic.Poder == item)
                    {
                        if (mago.PontosMagia >= ic.Poder.PontosMagia)
                        {
                            mago.PontosMagia -= ic.Poder.PontosMagia;
                        }
                    }
                }
            }

            Console.WriteLine("O {0} está atacando com seu {1} causando {2} pontos de dano", this.nome, ic.Armamento, ic.PontosDano);
        }

        public virtual void UsarItem(ItemMagico im)
        {

        }
    }
}
