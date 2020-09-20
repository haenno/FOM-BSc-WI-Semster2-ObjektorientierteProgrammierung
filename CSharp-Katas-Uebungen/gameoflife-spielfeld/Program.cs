using System;
using System.Security.Cryptography;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Text;

namespace GameOfLife
{

    

    class Program
    {
        static int feldVeratz = 0;

        static void SpielfeldZeichnen(int[,] SpielfeldZumZeichnen)
        {
            
            Console.SetCursorPosition(Console.CursorLeft+ feldVeratz, Console.CursorTop+ feldVeratz);
            Console.ForegroundColor = ConsoleColor.DarkGray;
            
            for (int iX = 0; iX < SpielfeldZumZeichnen.GetLength(0); iX++)
            {
                for (int iY = 0; iY < SpielfeldZumZeichnen.GetLength(1); iY++)
                {
                    Console.SetCursorPosition(iX+ feldVeratz, iY+ feldVeratz);
                    Console.Write(SpielfeldZumZeichnen[iX,iY]);
                }
            }
        }

        static int[,] SpielfeldNegieren(int[,] SpielfeldZumZeichnen)
        {
            for (int iX = 0; iX < SpielfeldZumZeichnen.GetLength(0); iX++)
            {
                for (int iY = 0; iY < SpielfeldZumZeichnen.GetLength(1); iY++)
                {
                    if (SpielfeldZumZeichnen[iX, iY] == 1)
                    {
                        SpielfeldZumZeichnen[iX, iY] = 0;
                    }
                    else
                    {
                        SpielfeldZumZeichnen[iX, iY] = 1;
                    }
                }
            }
            return SpielfeldZumZeichnen;
        }


        static void Main(string[] args)
        {

            Console.BufferHeight = Console.WindowHeight;



            //Hauptschleife
            while (true)
            {
                Console.Clear();

                Console.WriteLine("The current buffer height is {0} rows.",
                Console.BufferHeight);
                Console.WriteLine("The current buffer width is {0} columns.",
                Console.BufferWidth);


                Console.WriteLine("Game of Life *ding *sing \n");

                Console.Write("Bitte Spielfeldhöhe (X) angeben:     ");
                int SpielfeldBreiteX = Convert.ToInt32(Console.ReadLine());

                Console.Write("Bitte Spielfeldbreite (Y) angeben:   ");
                int SpielfeldHoeheY = Convert.ToInt32(Console.ReadLine());

                Console.Write("Bitte Anzahl Durchläufe angeben:     ");
                int Durchlaeufe = Convert.ToInt32(Console.ReadLine());

                
                Console.Write("Bitte Pause pro Durchlauf in ms:     ");
                int PauseMS = Convert.ToInt32(Console.ReadLine());



                int[,] Spielfeld = new int[SpielfeldBreiteX, SpielfeldHoeheY];

                for (int iX = 0; iX < SpielfeldBreiteX; iX++)
                {
                    for (int iY = 0; iY < SpielfeldHoeheY; iY++)
                    {
                        Spielfeld[iX, iY] = RandomNumberGenerator.GetInt32(2);
                        // Console.WriteLine(Spielfeld[iX, iY]);
                    }
                }

                //Wechsel-Schleife
                Console.Clear();
                for (int i = 0; i < Durchlaeufe; i++)
                {
                   
                    SpielfeldZeichnen(Spielfeld);
                    System.Threading.Thread.Sleep(PauseMS);
                    Spielfeld = SpielfeldNegieren(Spielfeld);
                }


            }
        }
    }
}
