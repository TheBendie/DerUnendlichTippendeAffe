﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordGenerator
{
    class Program
    {
        static int tries;
        static int sectries;
        static string searchedword;
        static bool beenden = false;
        static void Main(string[] args)
        {
            do
            {
                // Damit das Programm immer von vorne beginnt.
                beenden = false;
                // Setzt Versuche wieder auf 0
                tries = 0;
                Random rnd = new Random();
                // Alle Buchstaben, Zahlen und Sonderzeichen von einer QWERTZ-Tastatur
                char[] letters = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', ' ','0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'ü', 'ä', 'ö', '.', ',', '-', '_', '°', '^', '!', '"', '§', '$', '%', '&', '/', '(', ')', '=', '`', '?', '}', '{', '[', ']', '´', '#', '~', '*', '²', '³', 'ß', '>', '<', '|', ':', ';' };
                // Leert den letzendlichen Output 
                string output = "";
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("WICHTIG! Das Programm wird über die Zeit immer CPU lastiger. Man sollte es nicht zu lange laufen lassen.");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("INFO: Desto länger der Satz/das Wort, desto länger dauert es.");
                Console.WriteLine("Der Affe soll tippen: ");
                Console.ForegroundColor = ConsoleColor.Cyan;

                searchedword = Console.ReadLine();
                Console.ResetColor();
                // Main-Aktivität
                do
                {
                    // Sucht sich ein Random Buchstaben aus der Länge von letters
                    int r = rnd.Next(letters.Length);
                    // Konvertiert die Zahl wieder in einen Buchstaben und fügt sie an den Output an
                    output += (char)letters[r];
                    // Added einen Try
                    tries++;
                    sectries++;
                    // Schreibt den geschriebenen Buchstaben in die Konsole
                    Console.Write((char)letters[r]);
                    // Cleart die Konsole um LAG zu vermeiden
                    if(sectries >= 50000)
                    {
                        Console.Clear();
                        sectries = 0;
                    }
                    // Solange bis das gesuchte Wort im Output enthalten ist.                    
                } while (!output.Contains(searchedword));

                //Statistiken
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Gesuchtes Wort:" + searchedword);
                Console.WriteLine("Tastenanschäge: " + tries);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Drücke einen beliebigen Knopf, um das Endwort anzuzeigen:");
                Console.ResetColor();
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine(output);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Drücke einen beliebigen Knopf, um Fortzufahren.");
                Console.ReadLine();
                Console.Clear();
                Console.ResetColor();
            } while (beenden == false);
        }

    }
}