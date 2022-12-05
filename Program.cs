using Pecas;
using Tabuleiro;

namespace dama_console
{
    class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro.Tabuleiro tab = new Tabuleiro.Tabuleiro(8, 8);
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 8; j++)
                {

                    tab.colocarPeca(new Peao(tab, Cor.Branca), new Posicao(i, j));
                }
            }
            Tela.imprimirTabuleiro(tab);

        }
    }
}