using Tabuleiro;

namespace dama_console {
    class Program
{
    static void Main(string[] args) {
            Tabuleiro.Tabuleiro tab = new Tabuleiro.Tabuleiro(8, 8);
            Tela.imprimirTabuleiro(tab);
        
        }
}   
    }