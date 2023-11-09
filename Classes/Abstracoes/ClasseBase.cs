using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Final_De_Modulo__POO_II_.Classes.Abstracoes
{
    internal abstract class ClasseBase
    {
        public abstract int PontosVida { get; }
        public abstract int PontosMana { get; }
        public abstract List<string> PericiasClasse { get; }

        internal abstract List<string> PericiasEscolhidas();
    }
}
