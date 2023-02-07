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
        } //  Responsavel pelo gerenciamento do Menu.
        public static void DrawScreen() {
            Moldura();
        } // Responsavel pelo layout da tela.
        public static void Moldura() { 
            Cabecalho();
            Colunas();
            Cabecalho();

            static void Cabecalho() {
                Console.Write("+");
                for (int i = 0; i <= 30; i++)
                    Console.Write("-");

                Console.Write("+");
                Console.Write("\n");
            } //<-- Cria as linhas horizontais da moldura do Menu.
            static void Colunas() {
                for (int lines = 0; lines <= 10; lines++) {
                    Console.Write("|");
                    for (int i = 0; i <= 30; i++)
                        Console.Write(" ");

                    Console.Write("|");
                    Console.Write("\n");
                }

            }   //<-- Cria as colunas verticais da moldura do Menu.
        }   // Responsavel pela criação da moldura do Menu.

    }
}
