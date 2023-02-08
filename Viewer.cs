﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HTMLeditor {
    public class Viewer {

        public static void Show(string text) { // Responsavel por criar a tela de visualização do editor.
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("MODO VISUALIZAÇÃO");
            Console.WriteLine("-----------");
            Replace(text);
            Console.WriteLine("-----------");
            Console.ReadKey();
            Menu.Show();
        }

        public static void Replace(string text) { // Responsável pela modificação do texto em HTML e visualização.

            var strong = new Regex(@"<\s*strong[^>]*>(.*?)<\s*/\s*strong>");
            var words = text.Split(' ');
            for(var i = 0; i < words.Length; i++) {
                if (strong.IsMatch(words[i])) {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(
                        words[i].Substring(
                            words[i].IndexOf('>') +1,
                            (words[i].LastIndexOf('<') -1) - words[i].IndexOf('>'))
                        );
                    Console.Write(" ");
                }
                else {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write(words[i]);
                    Console.Write(" ");
                }
                
            }
        }
    }
}
