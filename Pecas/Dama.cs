﻿using System;
using Tabuleiro;

namespace Pecas
{
	public class Dama : Peca
	{
		public Dama(Tabuleiro.Tabuleiro tab, Cor Cor) :base(tab,Cor)
		{
		}
        public override string ToString()
        {
            return "D";
        }
        private bool podeMover(Posicao pos)
        {
            Peca p = Tabuleiro.retornarPeca(pos);
            return p == null || p.Cor != Cor;
        }

        public override bool[,] movimentosPossiveis()
        {
            bool[,] mat = new bool[Tabuleiro.Linhas, Tabuleiro.Colunas];

            Posicao pos = new Posicao(0, 0);

            // esquerda
            pos.definirValores(Posicao.Linha, Posicao.Coluna - 1);
            while (Tabuleiro.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
                if (Tabuleiro.retornarPeca(pos) != null && Tabuleiro.retornarPeca(pos).Cor != Cor)
                {
                    break;
                }
                pos.definirValores(pos.Linha, pos.Coluna - 1);
            }

            // direita
            pos.definirValores(Posicao.Linha, Posicao.Coluna + 1);
            while (Tabuleiro.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
                if (Tabuleiro.retornarPeca(pos) != null && Tabuleiro.retornarPeca(pos).Cor != Cor)
                {
                    break;
                }
                pos.definirValores(pos.Linha, pos.Coluna + 1);
            }

            // acima
            pos.definirValores(Posicao.Linha - 1, Posicao.Coluna);
            while (Tabuleiro.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
                if (Tabuleiro.retornarPeca(pos) != null && Tabuleiro.retornarPeca(pos).Cor != Cor)
                {
                    break;
                }
                pos.definirValores(pos.Linha - 1, pos.Coluna);
            }

            // abaixo
            pos.definirValores(Posicao.Linha + 1, Posicao.Coluna);
            while (Tabuleiro.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
                if (Tabuleiro.retornarPeca(pos) != null && Tabuleiro.retornarPeca(pos).Cor != Cor)
                {
                    break;
                }
                pos.definirValores(pos.Linha + 1, pos.Coluna);
            }

            // NO
            pos.definirValores(Posicao.Linha - 1, Posicao.Coluna - 1);
            while (Tabuleiro.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
                if (Tabuleiro.retornarPeca(pos) != null && Tabuleiro.retornarPeca(pos).Cor != Cor)
                {
                    break;
                }
                pos.definirValores(pos.Linha - 1, pos.Coluna - 1);
            }

            // NE
            pos.definirValores(Posicao.Linha - 1, Posicao.Coluna + 1);
            while (Tabuleiro.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
                if (Tabuleiro.retornarPeca(pos) != null && Tabuleiro.retornarPeca(pos).Cor != Cor)
                {
                    break;
                }
                pos.definirValores(pos.Linha - 1, pos.Coluna + 1);
            }

            // SE
            pos.definirValores(Posicao.Linha + 1, Posicao.Coluna + 1);
            while (Tabuleiro.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
                if (Tabuleiro.retornarPeca(pos) != null && Tabuleiro.retornarPeca(pos).Cor != Cor)
                {
                    break;
                }
                pos.definirValores(pos.Linha + 1, pos.Coluna + 1);
            }

            // SO
            pos.definirValores(Posicao.Linha + 1, Posicao.Coluna - 1);
            while (Tabuleiro.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
                if (Tabuleiro.retornarPeca(pos) != null && Tabuleiro.retornarPeca(pos).Cor != Cor)
                {
                    break;
                }
                pos.definirValores(pos.Linha + 1, pos.Coluna - 1);
            }

            return mat;
        }
    }

}