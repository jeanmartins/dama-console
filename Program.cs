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
            while (!partida.Terminada)
            {
                Console.Clear();
                Tela.imprimirTabuleiro(partida.Tabuleiro);
                Console.WriteLine();
                Console.WriteLine("Turno: " + partida.Turno);
                Console.WriteLine("Aguardando jogada: " + partida.JogadorAtual);

                Console.Write("Origem: ");
                Posicao origem = Tela.LerPosicaoXadrez().toPosicao();

                bool[,] posicoesPossiveis = partida.Tabuleiro.retornarPeca(origem).movimentosPossiveis();

                Console.Clear();

                Tela.imprimirTabuleiro(partida.Tabuleiro, posicoesPossiveis);

                Console.Write("Destino: ");
                Posicao destino = Tela.LerPosicaoXadrez().toPosicao();

                partida.realizaJogada(origem, destino);
            }
        

        }
    }
}