using Projeto_Final_De_Modulo__POO_II_.Raças.Abstracoes;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Final_De_Modulo__POO_II_.Raças
{
    public sealed class Anao : RacaBase, VisaoEspecial, BonusVidaRaca, ArmasSimples
    {
        public string VisaoEspecial { get; set; }
        public int VidaBonus { get; set; }
        public string[] ArmasSimples { get; set; }
        public Anao() 
        {
            TipoDeCriatura = "Humanoide";
            Tamanho = "Médio";
            Deslocamento = 6.0m;
            ModificadoresAtributosRaca = new int[6] { 0, -1, 2, 0, 1, 0 };
            HabilidadesRaca = new Dictionary<string, string>
            {
                {"Conhecimento Nas Rochas","Você recebe visão no escuro e +2 em testes de Percepção e Sobrevivência realizados no subterrâneo."}, //Bonus De pericia é condicional, não implementar diretamente na ficha
                {"Devagar e Sempre","Seu deslocamento é 6m (em vez de 9m). Porém, seu deslocamento não é reduzido por uso de armadura ou excesso de carga."},
                {"Duro como Pedra","Você recebe +3 pontos de vida no 1º nível e +1 por nível seguinte."},
                {"Tradição de Heredrimm","Você é perito nas armas tradicionais anãs, seja por ter treinado com elas, seja por usá-las como ferramentas de ofício. Para você, todos os machados, martelos, marretas e picaretas são armas simples. Você recebe +2 em ataques com essas armas."}
            };
            VisaoEspecial = "Visão No Escuro";
            VidaBonus = 3;
            ArmasSimples = new string[] {"Machadinha", "Machado De Batalha", "Martelo De Guerra", "Picareta", "Machado De Guerra", "Marreta", "Machado Anão", "Machado Taurico"};
        }
    }
}
