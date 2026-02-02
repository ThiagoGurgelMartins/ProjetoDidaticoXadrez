using System;
using System.Collections.Generic;
using System.Text;
using xadrez_console.tabuleiro;

namespace xadrez
{
    internal class Tela
    {
        public static void imprimirTabuleiro(Tabuleiro tab)
        {
            for (int i = 0; i < tab.linhas; i++)// cria linhas
            {
                Console.Write(8 - i + "  ");// diz como mostrar as linhas
                for (int j = 0; j < tab.colunas; j++)// cria coluna
                {
                    if (tab.peca(i, j) == null)// se no tabuleiro a posicao for nula, então vai CW
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        imprimirPeca(tab.peca(i, j));// se não for nula, ele vai imprimir a peca conforme o metodo imprimirPeca
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("   a b c d e f g h");
        }
        public static void imprimirPeca(Peca peca)// a Tela so precisa saber que aquilo eh uma Peca, nao qual peca
        {
            if (peca.cor == Cor.Branca)
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
