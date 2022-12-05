using System;
using Tabuleiro;

namespace Pecas
{
	public class Dama : Peca
	{
		public Dama(Tabuleiro.Tabuleiro tab, Cor cor) :base(tab,cor)
		{
		}
        public override string ToString()
        {
            return "D";
        }
    }

}