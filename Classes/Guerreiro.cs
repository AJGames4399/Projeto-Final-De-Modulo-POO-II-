using Projeto_Final_De_Modulo__POO_II_.Classes.Abstracoes;
using Projeto_Final_De_Modulo__POO_II_.Raças;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Final_De_Modulo__POO_II_.Classes
{
    internal class Guerreiro : ClasseBase, ProficienciasClasse
    {
        public override int PontosVida { get; }
        public override int PontosMana { get; }
        public override List<string> PericiasClasse { get; }
        public List<string> ProficienciasClasse { get; }

        internal Guerreiro() 
        {
            this.PontosVida = 20;
            this.PontosMana = 3;
            this.PericiasClasse = new List<string> (PericiasClasse);
            this.ProficienciasClasse = new List<string> {"Armas Marciais","Armaduras Pesadas", "Escudos"};
        }

        internal override List<string> PericiasEscolhidas()
        {
            List<string> pericias = new List<string>();

            return pericias;
        }
    }
}
