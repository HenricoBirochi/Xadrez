using System;
using XadrezConsole.Entities;
using XadrezConsole.Entities.Enums;
using XadrezConsole.Entities.Exceptions;
using XadrezConsole.Xadrez;

namespace XadrezConsole 
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Tabuleiro tab = new Tabuleiro(8, 8);

                tab.ColocarPeca(new Torre(Cor.Preta, tab), new Posicao(0, 0));
                tab.ColocarPeca(new Torre(Cor.Preta, tab), new Posicao(1, 3));
                tab.ColocarPeca(new Rei(Cor.Preta, tab), new Posicao(2, 4));

                Tela.ImprimirTabuleiro(tab);
            }
            catch (TabuleiroException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}