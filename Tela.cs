﻿using Tabuleiro;

namespace dama_console
{
    public class Tela
    {
        public static void imprimirTabuleiro(Tabuleiro.Tabuleiro tab)
        {
            for(int i=0; i<tab.Linhas; i++)
            {
                Console.Write(8 - i + " ");
                for(int j=0; j<tab.Colunas; j++)
                {
                    if(tab.retornarPeca(i,j) == null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        Tela.imprimirPeca(tab.retornarPeca(i, j));
                        Console.Write(" ");
                    }
                   
                }
                Console.WriteLine();
            }
            Console.WriteLine("  a b c d e f g h");
        }
        public static void imprimirPeca(Peca peca)
        {
            if(peca.Cor == Cor.Branca)
            {
                Console.Write(peca);
            }
            else
            {
                ConsoleColor aux = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(peca);
                Console.ForegroundColor = aux;
            }
        }
    }
}
