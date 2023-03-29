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

            DisplayBanner();

            bool ExecuteProgram = true;

            while (ExecuteProgram)
            {
                Menus.Menus.MainMenu();
                int input = Int32.Parse(Console.ReadLine());

                switch (input)
                {
                    case 0:
                        Utils.Clear();
                        Menus.Menus.MainMenu();
                        break;
                    case 1:
                        Utils.Clear();
                        Menus.Menus.FacilityMenu();
                        break;
                    case 2:
                        Utils.Clear();
                        Menus.Menus.AnimalPurchaseMenu();
                        break;
                    case 3:
                        Utils.Clear();
                        Menus.Menus.SeedPurchaseMenu();
                        break;
                    case 4:
                        Utils.Clear();
                        Menus.Menus.ProcessingMenu();
                        break;
                    default:
                        Console.WriteLine("Invalid input! Try again...");
                        Menus.Menus.MainMenu();
                        break;
                }
            }
        }
    }
}