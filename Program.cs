using Jogo;
using Pecas;
using Tabuleiro;

namespace dama_console
{
    class Program
    {
        static void Main(string[] args)
        {
            Partida partida = new Partida();
            Tela.imprimirTabuleiro(partida.Tabuleiro);

        }
    }
}