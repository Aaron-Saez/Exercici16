using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();


        }

        public static void Menu()
        {
            Console.WriteLine("LListat de Jocs");
            Console.WriteLine();
            Console.WriteLine("Tetris           [1]");
            Console.WriteLine("BuscaMinas       [2]");
            Console.WriteLine("LoL              [3]");
            Console.WriteLine("Nostale          [4]");
            Console.WriteLine("Metin2           [5]");
            Console.WriteLine();
            Console.WriteLine("Tria una opció --> ");

            int opcio = Convert.ToInt32(Console.ReadLine());

            if (opcio > 0 && opcio < 5)
            {
                switch(opcio)
                {
                    case 1:
                        Tetris();
                        break;
                    case 2:
                        Buscaminas();
                        break;
                    case 3:
                        LoL();
                        break;
                    case 4:
                        Nostale();
                        break;
                    case 5:
                        Metin2();
                        break;

                }
            }
        }

        public static void Tetris()
        {
            Console.WriteLine("Aixo es el Tetris");
        }

        public static void Buscaminas()
        {
            Console.WriteLine("Aixo es el Buscaminas");
        }

        public static void LoL()
        {
            Console.WriteLine("Aixo es el LoL");
        }

        public static void Nostale()
        {
            Console.WriteLine("Aixo es el Nostale");
	    Console.WriteLine("Aquest joc sera una pasada");
        }

        public static void Metin2()
        {
            Console.WriteLine("Aixo es el Metin2");
        }


    }
}
