using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Final_De_Modulo__POO_II_.Raças.Abstracoes
{
    public abstract class RacaBase
    {
        public string TipoDeCriatura { get; protected set;  } //Default -> Humanoide
        public string Tamanho { get; protected set; } //Default -> Medio
        public decimal Deslocamento { get; protected set; } //Default -> 9.0
        public int[] ModificadoresAtributosRaca { get; protected set; } // Seguem sempre este formato { FORÇA , DESTREZA , CONSTITUIÇÃO , INTELIGENCIA , SABEDORIA , CARISMA}
        public Dictionary<string,string> HabilidadesRaca { get; protected set; } // Habilidades separadas por nome e descrição
    }
}
