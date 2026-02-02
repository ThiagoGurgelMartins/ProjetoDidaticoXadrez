using System;
using System.Collections.Generic;
using System.Text;
using tabuleiro;

namespace xadrez_console.tabuleiro
{
    internal class Tabuleiro
    {
        public int linhas {  get; set; }
        public int colunas { get; set; }
        private Peca[,] pecas; // cria matriz do tabuleiro e bloqueio ela de ser usada em outras classes

        public Tabuleiro(int linhas, int colunas)
        {
            this.linhas = linhas;
            this.colunas = colunas;
            pecas = new Peca[linhas, colunas];// recebe uma matriz de pecas com n linhas e ne colunas. O tabuleiro é ligado as PECAS, onde não tem pecas tem null 
        }
        public Peca peca (int linha, int coluna)// metodo publico que pode acessar uma peça. A matriz peca so pode ser acessada atraves daqui
        {
            return pecas[linha, coluna];
        }

        public void colocarPeca(Peca p, Posicao pos)//metodo para casar peca com posicao
        {
            pecas[pos.linha, pos.coluna] = p;// acessa a matriz da classe e coloca p em uma posicao da matriz
            p.posicao = pos;//'p' de peca é igual 'pos' de posição
        }
    }
}
