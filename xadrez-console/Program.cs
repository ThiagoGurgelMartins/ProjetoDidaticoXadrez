// See https://aka.ms/new-console-template for more information
using xadrez_console;
using xadrez_console.tabuleiro;

class Program
{
    static void Main(string[] args)
    {
        Tabuleiro tab = new Tabuleiro(8, 8);

        Tela.imprimirTabuleiro(tab);// chamou a classe Tela, disse o metodo que será usado e deu a referencia da classe main


        Console.ReadLine();
    } 
        
}
