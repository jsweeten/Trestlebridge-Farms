using System;
using System.Collections.Generic;
using System.Linq;
using Trestlebridge.Menus;
using Trestlebridge.Models;

namespace Trestlebridge
{
    class Program
    {
        static void DisplayBanner()
        {
            Utils.Clear();
            Console.WriteLine();
            Console.WriteLine(@"
        +-++-++-++-++-++-++-++-++-++-++-++-++-+
        |T||r||e||s||t||l||e||b||r||i||d||g||e|
        +-++-++-++-++-++-++-++-++-++-++-++-++-+
                    |F||a||r||m||s|
                    +-++-++-++-++-+");
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkCyan;

            Farm Trestlebridge = new Farm();

            bool ExecuteProgram = true;

            while (ExecuteProgram)
            {
                DisplayBanner();
                Menus.Menus.MainMenu(Trestlebridge);
            }
        }
    }
}