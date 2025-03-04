﻿using System;
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
                PartidaDeXadrez partida = new PartidaDeXadrez();

                while (!partida.Terminada)
                {
                    Console.Clear();
                    Tela.ImprimirTabuleiro(partida.Tab);

                    Console.Write("Origem: ");
                    Posicao origem = Tela.LerPosicaoXadrez().ToPosicao();

                    bool[,] posicoesPossiveis = partida.Tab.AcessarPeca(origem).MovimentosPossiveis();

                    Console.Clear();
                    Tela.ImprimirTabuleiro(partida.Tab, posicoesPossiveis);

                    Console.Write("Destino: ");
                    Posicao destino = Tela.LerPosicaoXadrez().ToPosicao();

                    partida.ExecutaMovimento(origem, destino);
                }
                

                Tela.ImprimirTabuleiro(partida.Tab);

            }
            catch (TabuleiroException ex) 
            {
                Console.WriteLine(ex.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}