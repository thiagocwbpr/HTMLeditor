using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTMLeditor {
    public static class Editor {

        public static void Show() { // Responsavel por criar a tela do editor HTML.
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("MODO EDITOR");
            Console.WriteLine("-----------");
            Start();
        }

        public static void Start() { // Responsavel pela criação e edição do editor HTML.
            var file = new StringBuilder();

            do {
                file.Append(Console.ReadLine());
                file.Append(Environment.NewLine);
            } while (Console.ReadKey().Key != ConsoleKey.Escape);

            Console.WriteLine("-----------");
            Console.WriteLine(" Deseja salvar o arquivo?");
            Viewer.Show(file.ToString());
        }
    }
}
