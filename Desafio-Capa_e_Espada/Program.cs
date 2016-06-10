using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_Capa_e_Espada
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        static void Personagem(string personagem)
        {
            if (personagem == "Hank")
            {                
                Guerreiro guerreiro = new Guerreiro(1, "Hank", 1, 40, 150,20, "Cruzado");               
                Armamento armamento = new Armamento(1, "Arco Mágico",5,5);
                guerreiro.Armamentos.Add(armamento);
                ItemDefesa itemdefesa = new ItemDefesa(1, "Armadura Couro", 15);

            }
            else if (personagem == "Presto")
            {
                Mago mago = new Mago(1, "Presto", 1, 20, 200, 40, "Cruzado");
                Poder poder = new Poder(1, "Ataque Luminoso", 3, 3);
                mago.Poderes.Add(poder);
                ItemDefesa itemdefesa = new ItemDefesa(1, "Manto", 12);
            }
            else if (personagem == "Saruman")
            {
                Mago mago = new Mago(1, "Saruman", 1, 100, 5000, 400, "Malfeitor");
                Poder poder = new Poder(1, "Bolas de Fogo", 20, 40);
                mago.Poderes.Add(poder);
                poder = new Poder(1, "Lingua de cobra", 5, 10);
                mago.Poderes.Add(poder);
                ItemDefesa itemdefesa = new ItemDefesa(1, "Manto", 12);
            }
            else if (personagem == "Hank")
            {
                Guerreiro guerreiro = new Guerreiro(1, "Hank", 1, 40, 150, 20, "Cruzado");
                Armamento armamento = new Armamento(1, "Arco Mágico", 5, 5);
                guerreiro.Armamentos.Add(armamento);
                ItemDefesa itemdefesa = new ItemDefesa(1, "Armadura Couro", 15);

            }
        }
    }


}
