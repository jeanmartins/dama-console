using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabuleiro
{
    public class Peca: IPeca
    {
        public Posicao? Posicao { get; set; }
        public Cor Cor { get; set; }
        public int qteMovimentos{ get; set; }
        public Tabuleiro Tabuleiro { get; set; }

        public Peca(Tabuleiro tabuleiro, Cor cor)
        {
            Posicao = null;
            Cor = cor;
            this.qteMovimentos = 0;
            Tabuleiro = tabuleiro;
        }

        public void incrementarQtdMovimentos()
        {
            qteMovimentos++;
        }
    }
}
