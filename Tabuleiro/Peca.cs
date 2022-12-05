using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabuleiro
{
    public class Peca
    {
        public Posicao? Posicao { get; set; }
        public Cor Cor { get; protected set; }
        public int qteMovimentos{ get; protected set; }
        public Tabuleiro Tabuleiro { get; protected set; }

        public Peca(Tabuleiro tabuleiro, Cor cor)
        {
            Posicao = null;
            Cor = cor;
            this.qteMovimentos = 0;
            Tabuleiro = tabuleiro;
        }
    }
}
