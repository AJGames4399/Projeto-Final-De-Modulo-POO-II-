using Projeto_Final_De_Modulo__POO_II_.Raças.Abstracoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Final_De_Modulo__POO_II_.Raças
{
    public sealed class Goblim : RacaBase, VisaoEspecial, DeslocamentoEspecial, BonusPericia
    {
        public string VisaoEspecial { get; set; }
        public Dictionary<string, decimal> DeslocamentoEspecial { get; set; }
        public Dictionary<string, int> BonusPericia {get; set; }

        public Goblim()
        {
            TipoDeCriatura = "Humanoide";
            Tamanho = "Pequeno";
            Deslocamento = 9.0m;
            ModificadoresAtributosRaca = new int[6] { 0, 2, 0, 1, 0, -1 };
            HabilidadesRaca = new Dictionary<string, string>
            {
                {"Engenhoso","Você não sofre penalidades em testes de perícia por não usar ferramentas. Se usar a ferramenta necessária, recebe +2 no teste de perícia."}, //Bonus Condicional, não adicionar diretamente na ficha
                {"Espelunqueiro","Você recebe visão no escuro e deslocamento de escalada igual ao seu deslocamento terrestre."},
                {"Peste Esguia","Seu tamanho é Pequeno (veja a página 106), mas seu deslocamento se mantém 9m. Apesar de pequenos, goblins são rápidos."},
                {"Rato das Ruas.","Você recebe +2 em Fortitude e sua recuperação de PV e PM nunca é inferior ao seu nível."}
            };
            VisaoEspecial = "Visão No Escuro";
            DeslocamentoEspecial = new Dictionary<string, decimal> { { "escalada", 9.0m } };
            BonusPericia = new Dictionary<string, int> { { "Fortitude", 2 } };
        }
    }
}
