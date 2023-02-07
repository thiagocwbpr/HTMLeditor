using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace HTMLeditor {
    public static class Menu {

        public static void Show() { //  Responsavel pelo gerenciamento do Menu.
            Console.Clear();
            

            DrawScreen();
            WriteOptions();

            var option = short.Parse(Console.ReadLine());

            HandleMenuOption(option);
        } 
        public static void DrawScreen() { // Responsavel pelo layout da tela.
            Frame();
        } 
        public static void Frame() { // Responsavel pela criação da moldura do Menu.
            LinhaHorizontal();
            LinhaVertical();
            LinhaHorizontal();

            static void LinhaHorizontal() { //<-- Cria as linhas horizontais da moldura do Menu.
                Console.Write("+");
                for (int i = 0; i <= 30; i++)
                    Console.Write("-");

                Console.Write("+");
                Console.Write("\n");
            } 
            static void LinhaVertical() { //<-- Cria as colunas verticais da moldura do Menu.
                for (int lines = 0; lines <= 10; lines++) {
                    Console.Write("|");
                    for (int i = 0; i <= 30; i++)
                        Console.Write(" ");

                    Console.Write("|");
                    Console.Write("\n");
                }

            }   
        }   

        public static void WriteOptions() {
            Console.SetCursorPosition(10,1);
            Console.WriteLine("Editor de HTML");
            Console.SetCursorPosition(10,2);
            Console.WriteLine("==============");
            Console.SetCursorPosition(1,4);
            Console.WriteLine("Selecione uma opção: ");
            Console.SetCursorPosition(1, 6);
            Console.WriteLine("1 - Novo Arquivo: ");
            Console.SetCursorPosition(1, 7);
            Console.WriteLine("2 - Abrir : ");
            Console.SetCursorPosition(1, 9);
            Console.WriteLine("0 - Sair : ");
            Console.SetCursorPosition(1, 11);
            Console.Write("Opção : ");
           
        }

        public static void HandleMenuOption(short option) {

            switch (option) {

                case 1:
                    Console.WriteLine("Editor");
                    break;
                case 2:
                    Console.WriteLine("View");
                    break;
                case 0: {
                        Console.Clear();
                        Environment.Exit(0);
                        break;
                    }
                default:
                    Show();
                    break;

            }
        }

    }
}
