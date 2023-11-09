using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Final_De_Modulo__POO_II_.Raças.Abstracoes
{
    public interface DeslocamentoEspecial
    {
        public Dictionary<string,decimal> DeslocamentoEspecial { get; set; } // Implementar quando a raça tiver um tipo de deslocamento especial (Voo, Nado, Escalada, Escavar)
    }
}
