using System;
using Tabuleiro;

namespace Pecas
{
    public class Peao : Peca
    {
        public Peao(Tabuleiro.Tabuleiro tab, Cor Cor) : base(tab, Cor)
        {
        }
        public override string ToString()
        {
            return "P";
        }
        private bool livre(Posicao pos)
        {
            return Tabuleiro.retornarPeca(pos) == null;
        }
        public override bool[,] movimentosPossiveis()
        {
            bool[,] mat = new bool[Tabuleiro.Linhas, Tabuleiro.Colunas];

            Posicao pos = new Posicao(0, 0);

            if (Cor == Cor.Branca)
            {
                pos.definirValores(Posicao.Linha - 1, Posicao.Coluna - 1);
                if (Tabuleiro.posicaoValida(pos) && livre(pos))
                {
                    mat[pos.Linha, pos.Coluna] = true;
                }
                pos.definirValores(Posicao.Linha - 1, Posicao.Coluna + 1);
                if (Tabuleiro.posicaoValida(pos) && livre(pos))
                {
                    mat[pos.Linha, pos.Coluna] = true;
                }
            }
            else
            {
                pos.definirValores(Posicao.Linha + 1, Posicao.Coluna - 1);
                if (Tabuleiro.posicaoValida(pos) && livre(pos))
                {
                    mat[pos.Linha, pos.Coluna] = true;
                }
                pos.definirValores(Posicao.Linha + 1, Posicao.Coluna + 1);
                if (Tabuleiro.posicaoValida(pos) && livre(pos))
                {
                    mat[pos.Linha, pos.Coluna] = true;
                }
            }

            return mat;
        }
    }
}