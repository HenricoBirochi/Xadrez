using System;
using XadrezConsole.Entities;

namespace XadrezConsole 
{
    public class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro tab = new Tabuleiro(8, 8);

            Tela.ImprimirTabuleiro(tab);
        }
    }
}