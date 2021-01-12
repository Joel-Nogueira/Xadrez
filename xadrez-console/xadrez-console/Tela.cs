using System;
using tabuleiro;

namespace xadrez_console
{
    class Tela
    {
        public static void imprimirTabuleiro(Tabuleiro tabuleiro)
        {
            for (int i = 0; i < tabuleiro.Linhas; i++)
            {
                Console.Write(8 - i + " ");
                for (int j = 0; j < tabuleiro.Colunas; j++)
                {
                    if (tabuleiro.Peca(i, j) == null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        //Console.Write(tabuleiro.Peca(i, j) + " ");
                        ImprimirPeca(tabuleiro.Peca(i, j));
                        Console.Write(" ");
                    }
                    
                }
                Console.WriteLine();
            }
            Console.WriteLine("  a b c d e f g h");
        }

        public static void ImprimirPeca(Peca peca)
        {
            ConsoleColor aux = Console.ForegroundColor;
            if (peca.Cor != Cor.Branca)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
            }
            Console.Write(peca);
            Console.ForegroundColor = aux;
        }
    }
}
