using Projeto_Final_De_Modulo__POO_II_.Raças.Abstracoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Final_De_Modulo__POO_II_.Raças
{
    public sealed class Dahllan : RacaBase
    {
        public Dahllan() 
        {
            TipoDeCriatura = "Humanoide";
            Tamanho = "Médio";
            Deslocamento = 9.0m;
            ModificadoresAtributosRaca = new int[6] { 0, 1, 0, -1, 2, 0 };
            HabilidadesRaca = new Dictionary<string, string>
            {
                {"Amiga das Plantas","Você pode lançar a magia Controlar Plantas (atributo-chave Sabedoria). Caso aprenda novamente essa magia, seu custo diminui em –1 PM"},
                {"Armadura de Allihanna","Você pode gastar uma ação de movimento e 1 PM para transformar sua pele em casca de árvore, recebendo +2 na Defesa até o fim da cena."},
                {"Empatia Selvagem","Você pode se comunicar com animais por meio de linguagem corporal e vocalizações. Você pode usar Adestramento para mudar atitude e persuasão com animais (veja Diplomacia, na página 118). Caso receba esta habilidade novamente, recebe +2 em Adestramento."}
            };
        }
    }
}
