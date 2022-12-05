namespace dama_console
{
    public class Tela
    {
        public static void imprimirTabuleiro(Tabuleiro.Tabuleiro tab)
        {
            for(int i=0; i<tab.Linhas; i++)
            {
                for(int j=0; j<tab.Colunas; j++)
                {
                    if(tab.retornarPeca(i,j) == null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        Console.Write(tab.retornarPeca(i, j) + " ");
                    }
                   
                }
                Console.WriteLine();
            }

        }
    }
}
