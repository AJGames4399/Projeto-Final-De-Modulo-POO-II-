using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Final_De_Modulo__POO_II_.Origens.Abstracoes
{
    internal abstract class OrigemBase
    {
        public abstract Dictionary<string, string> BeneficiosOrigem { get; }
        public abstract Dictionary<string, float> EquipamentosOrigem { get; }
    }
}
