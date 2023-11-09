using Projeto_Final_De_Modulo__POO_II_.Raças.Abstracoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Final_De_Modulo__POO_II_.Raças
{
    public sealed class Elfo : RacaBase, BonusManaRaca, VisaoEspecial, BonusPericia
    {
        public int ManaBonus { get; set; }
        public string VisaoEspecial { get; set; }
        public Dictionary<string, int> BonusPericia { get; set; }

        public Elfo() 
        {
            TipoDeCriatura = "Humanoide";
            Tamanho = "Médio";
            Deslocamento = 12.0m;
            ModificadoresAtributosRaca = new int[6] { 0, 1, -1, 2, 0, 0 };
            HabilidadesRaca = new Dictionary<string, string>
            {
                {"Graça de Glórienn","Seu deslocamento é 12m (em vez de 9m)"},
                {"Sangue Mágico","Você recebe +1 ponto de mana por nível"},
                {"Sentidos Élficos","Você recebe visão na penumbra e +2 em Misticismo e Percepção."}
            };
            ManaBonus = 1;
            VisaoEspecial = "Visão Na Penumbra";
            BonusPericia = new Dictionary<string, int>
            {
                {"Misticismo",2},
                {"Percepção",2}
            };

        }
    }
}
