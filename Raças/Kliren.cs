using Projeto_Final_De_Modulo__POO_II_.Raças.Abstracoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Final_De_Modulo__POO_II_.Raças
{
    public sealed class Kliren : RacaBase
    {
        public Kliren() 
        {
            TipoDeCriatura = "humanoide";
            Tamanho = "Médio";
            Deslocamento = 9.0m;
            ModificadoresAtributosRaca = new int[6] { 0, 0, 0, 0, 0, 0 };
            HabilidadesRaca = new Dictionary<string, string>
            {
                {"", ""}
            };
        }
    }
}
