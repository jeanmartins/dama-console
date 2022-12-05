using System;
using Tabuleiro;

namespace Pecas
{
    public class Peao : Peca
    {
        public Peao(Tabuleiro.Tabuleiro tab, Cor cor) : base(tab, cor)
        {
        }
        public override string ToString()
        {
            return "P";
        }
    }

}