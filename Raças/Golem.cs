using Projeto_Final_De_Modulo__POO_II_.Raças.Abstracoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Final_De_Modulo__POO_II_.Raças
{
    public sealed class Golem : RacaBase, DefesaBonusRaca, VisaoEspecial, ImunidadesRaca
    {
        public int DefesaBonus { get; set; }
        public string VisaoEspecial { get; set; }
        public string[] ImunidadesRaca { get; set; }

        public Golem() 
        {
            TipoDeCriatura = "Construto";
            Tamanho = "Médio";
            Deslocamento = 6.0m;
            ModificadoresAtributosRaca = new int[6] { 2, 0, 1, 0, 0, -1 };
            HabilidadesRaca = new Dictionary<string, string>
            {
                {"Chassi","Seu corpo artificial é resistente, mas rígido. Seu deslocamento é 6m, mas não é reduzido por uso de armadura ou excesso de carga. Você recebe +2 na Defesa, mas possui penalidade de armadura –2. Você leva um dia para vestir ou remover uma armadura (pois precisa acoplar as peças dela a seu chassi). Por ser acoplada, sua armadura não conta no limite de itens que você pode usar (mas você continua só podendo usar uma armadura)."},
                {"Criatura Artificial","Você é uma criatura do tipo construto. Recebe visão no escuro e imunidade a efeitos de cansaço, metabólicos e de veneno. Além disso, não precisa respirar, alimentar-se ou dormir, mas não se beneficia de cura mundana e de itens da categoria alimentação. Você precisa ficar inerte por oito horas por dia para recarregar sua fonte de energia. Se fizer isso, recupera PV e PM por descanso em condições normais (golens não são afetados por condições boas ou ruins de descanso). Por fim, a perícia Cura não funciona em você, mas Ofício(artesão) pode ser usada no lugar dela."},
                {"Propósito de Criação","Você foi construído “pronto” para um propósito específico e não teve uma infância. Você não tem direito a escolher uma origem, mas recebe um poder geral a sua escolha"},
                {"Fonte Elemental","Você possui um espírito elemental preso em seu corpo. Escolha entre água (frio), ar (eletricidade), fogo (fogo) e terra (ácido). Você é imune a dano desse tipo. Se fosse sofrer dano mágico desse tipo, em vez disso cura PV em quantidade igual à metade do dano. Por exemplo, se um golem com espírito elemental do fogo é atingido por uma Bola de Fogo que causa 30 pontos de dano, em vez de sofrer esse dano, ele recupera 15 PV."}
            };
            DefesaBonus = 2;
            VisaoEspecial = "Visão No Escuro";
            ImunidadesRaca = new string[] {"Cansaço","Metabolismo","Veneno"};
        }
        protected string selecionarElemento()
        {
            int opcao = 0;
            string elemento = "";
            do
            {
                Console.WriteLine("Selecione o Espirito Elemental em seu corpo (você ganha bonus baseado no elemento)");
                Console.WriteLine("\n1 - Espirito Elemental Da Agua (Frio)\n2 - Espirito Elemental Do Ar (Eletricidade)\n3 - Espirito Elemental Do Fogo (Fogo)\n4 - Espirito Elemental Da Terra (Ácido)\n");
            } while (!int.TryParse(Console.ReadKey().KeyChar.ToString(), out opcao) || (opcao < 1 || opcao > 4));
            switch (opcao)
            {
                case 1:
                    elemento = "Frio";
                    break;
                case 2:
                    elemento = "Eletricidade";
                    break;
                case 3:
                    elemento = "Fogo";
                    break;
                case 4:
                    elemento = "Ácido";
                    break;
                default:
                    elemento = "Erro";
                    break;
            }
            return elemento;
        }
    }
}
