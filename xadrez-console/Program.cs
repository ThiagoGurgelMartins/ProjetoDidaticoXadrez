// See https://aka.ms/new-console-template for more information
using xadrez_console;
using xadrez_console.tabuleiro;
using tabuleiro;
using xadrez;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Tabuleiro tab = new Tabuleiro(8, 8);// chamo a matriz do tabuleiro, crio ele e digo qual tamanho da matriz

            tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));//chamo o tabuleiro, depois chamo metodo colocarPeca(Tabuleiro) que vai pedir uma peca e uma posicao
            tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 7));
            tab.colocarPeca(new Rei(tab, Cor.Preta), new Posicao(0,4));

            tab.colocarPeca(new Torre(tab, Cor.Branca), new Posicao(7, 7));

            Tela.imprimirTabuleiro(tab);// chamou a classe Tela, disse o metodo que será usado e deu a referencia da classe main

        }
        catch (TabuleiroException e)
        {
            Console.WriteLine(e.Message);         
        }
        Console.ReadLine();
    } 
        
}
