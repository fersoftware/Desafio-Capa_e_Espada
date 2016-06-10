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

        private List<Poder> poderes = new List<Poder>();
        private List<Armamento> armamentos = new List<Armamento>();
        private List<ItemMagico> itensMagicos = new List<ItemMagico>();
        private List<ItemDefesa> itensDefesas = new List<ItemDefesa>();
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public int Nivel
        {
            get { return nivel; }
            set { nivel = value; }
        }

        public int PontosVida
        {
            get { return pontosVida; }
            set { pontosVida = value; }
        }

        public int PontosExperiencia
        {
            get { return pontosExperiencia; }
            set { pontosExperiencia = value; }
        }

        public string Alinhamento
        {
            get { return alinhamento; }
            set { alinhamento = value; }
        }

        public List<Poder> Poderes
        {
            get { return poderes; }
            set { poderes = value; }
        }

        public List<Armamento> Armamentos
        {
            get { return armamentos; }
            set { armamentos = value; }
        }

        public List<ItemMagico> ItensMagicos
        {
            get { return itensMagicos; }
            set { itensMagicos = value; }
        }

        public List<ItemDefesa> ItensDefesas
        {
            get { return itensDefesas; }
            set { itensDefesas = value; }
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
        }

        public virtual void UsarItem(ItemMagico im)
        {

        }
    }
}
