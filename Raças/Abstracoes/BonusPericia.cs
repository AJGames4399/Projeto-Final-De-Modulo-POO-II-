using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Final_De_Modulo__POO_II_.Raças.Abstracoes
{
    public interface BonusPericia
    {
        public Dictionary<string,int> BonusPericia { get; set; } //Implementar quando a raça dar bonus diretamente em uma ou mais pericias
    }
}
