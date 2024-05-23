using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Animals.Menu
{
    internal class Menu
    {
        public static void MenuSystem()
        {

            Console.WriteLine("Witamy w atlasie zwierząt!");

            string[] keys = { "Pokaż zwierzęta", "Dodaj zwierzęta" };
            int number = 1;
            foreach (string key in keys)
            {
                Console.WriteLine($"{number}.{key}");
                number++;
            }

            Console.Write("Wybierz opcję żeby przejść dalej: ");
            string option = Console.ReadLine();
            switch (option)
            {
                case "1":
                    Console.Clear();
                    ShowSubMenu.ShowAnimalsMenu();
                    break;
                case "2":
                    Console.Clear();
                    AddSubMenu.AddAnimalsMenu();
                    break;
                default:
                    break;
            }
        }

    }
}
