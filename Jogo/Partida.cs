using Pecas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tabuleiro;

namespace Jogo
{
    public class Partida
    {
        public Tabuleiro.Tabuleiro Tabuleiro { get; private set; }
        public int Turno { get; private set; }
        public Cor JogadorAtual { get; private set; }
        public bool Terminada { get; set; }
        private HashSet<Peca> Pecas;

        public Partida()
        {
            Tabuleiro = new Tabuleiro.Tabuleiro(8, 8);
            Turno = 1;
            JogadorAtual = Cor.Branca;
            Terminada = false;
            ColocarPecas();
        }

        public void ExecutaMovimento(Posicao origem, Posicao destino)
        {
            Peca p = Tabuleiro.retirarPeca(origem);
            p.incrementarQtdMovimentos();
            Tabuleiro.retirarPeca(destino);
            Tabuleiro.colocarPeca(p, destino);
        }

        public void realizaJogada(Posicao origem, Posicao destino)
        {
            ExecutaMovimento(origem, destino);

            Peca p = Tabuleiro.retornarPeca(destino);

            if (p is Peao)
            {
                if ((p.Cor == Cor.Branca && destino.Linha == 0) || (p.Cor == Cor.Preta && destino.Linha == 7))
                {
                    p = Tabuleiro.retirarPeca(destino);
                    Pecas.Remove(p);
                    Peca dama = new Dama(Tabuleiro, p.Cor);
                    Tabuleiro.colocarPeca(dama, destino);
                    Pecas.Add(dama);
                }
            }
            Turno++;
            mudaJogador();
        }


        private void mudaJogador()
        {
            if (JogadorAtual == Cor.Branca)
            {
                JogadorAtual = Cor.Preta;
            }
            else
            {
                JogadorAtual = Cor.Branca;
            }
        }
        public void colocarNovaPeca(char coluna, int linha, Peca peca)
        {
            Tabuleiro.colocarPeca(peca, new PosicaoPeca(coluna, linha).toPosicao());
        }
        private void ColocarPecas()
        {
            colocarNovaPeca('a', 1, new Peao(Tabuleiro, Cor.Branca));
            colocarNovaPeca('b', 1, new Peao(Tabuleiro, Cor.Branca));
            colocarNovaPeca('c', 1, new Peao(Tabuleiro, Cor.Branca));
            colocarNovaPeca('d', 1, new Peao(Tabuleiro, Cor.Branca));
            colocarNovaPeca('e', 1, new Peao(Tabuleiro, Cor.Branca));
            colocarNovaPeca('f', 1, new Peao(Tabuleiro, Cor.Branca));
            colocarNovaPeca('g', 1, new Peao(Tabuleiro, Cor.Branca));
            colocarNovaPeca('h', 1, new Peao(Tabuleiro, Cor.Branca));
            colocarNovaPeca('a', 2, new Peao(Tabuleiro, Cor.Branca));
            colocarNovaPeca('b', 2, new Peao(Tabuleiro, Cor.Branca));
            colocarNovaPeca('c', 2, new Peao(Tabuleiro, Cor.Branca));
            colocarNovaPeca('d', 2, new Peao(Tabuleiro, Cor.Branca));
            colocarNovaPeca('e', 2, new Peao(Tabuleiro, Cor.Branca));
            colocarNovaPeca('f', 2, new Peao(Tabuleiro, Cor.Branca));
            colocarNovaPeca('g', 2, new Peao(Tabuleiro, Cor.Branca));
            colocarNovaPeca('h', 2, new Peao(Tabuleiro, Cor.Branca));

            colocarNovaPeca('a', 8, new Peao(Tabuleiro, Cor.Preta));
            colocarNovaPeca('b', 8, new Peao(Tabuleiro, Cor.Preta));
            colocarNovaPeca('c', 8, new Peao(Tabuleiro, Cor.Preta));
            colocarNovaPeca('d', 8, new Peao(Tabuleiro, Cor.Preta));
            colocarNovaPeca('e', 8, new Peao(Tabuleiro, Cor.Preta));
            colocarNovaPeca('f', 8, new Peao(Tabuleiro, Cor.Preta));
            colocarNovaPeca('g', 8, new Peao(Tabuleiro, Cor.Preta));
            colocarNovaPeca('h', 8, new Peao(Tabuleiro, Cor.Preta));
            colocarNovaPeca('a', 7, new Peao(Tabuleiro, Cor.Preta));
            colocarNovaPeca('b', 7, new Peao(Tabuleiro, Cor.Preta));
            colocarNovaPeca('c', 7, new Peao(Tabuleiro, Cor.Preta));
            colocarNovaPeca('d', 7, new Peao(Tabuleiro, Cor.Preta));
            colocarNovaPeca('e', 7, new Peao(Tabuleiro, Cor.Preta));
            colocarNovaPeca('f', 7, new Peao(Tabuleiro, Cor.Preta));
            colocarNovaPeca('g', 7, new Peao(Tabuleiro, Cor.Preta));
            colocarNovaPeca('h', 7, new Peao(Tabuleiro, Cor.Preta));
        }
    }
}
