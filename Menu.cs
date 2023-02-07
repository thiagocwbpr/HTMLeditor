using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTMLeditor {
    public static class Menu {

        public static void Show() {

            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Black;

            DrawScreen();
        }
        public static void DrawScreen() {

            Cabecalho();
            Colunas();
            Cabecalho();
            
        }

        public static void Cabecalho() {
            Console.Write("+");
            for (int i = 0; i <= 30; i++)
                Console.Write("-");

            Console.Write("+");
            Console.Write("\n");
        }

        public static void Colunas() {
            for (int lines = 0; lines <= 10; lines++) {
                Console.Write("|");
                for (int i = 0; i <= 30; i++)
                    Console.Write(" ");

                Console.Write("|");
                Console.Write("\n");
            }
        }

    }
}
