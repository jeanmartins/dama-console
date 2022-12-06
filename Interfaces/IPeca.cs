using Tabuleiro;

namespace Interfaces
{
    interface IPeca
    {
        Posicao? Posicao { get; set; }
        Cor Cor { get; set; }
        int qteMovimentos { get;set; }
        Tabuleiro.Tabuleiro Tabuleiro { get; set; }

        public void incrementarQtdMovimentos();
    }
}
