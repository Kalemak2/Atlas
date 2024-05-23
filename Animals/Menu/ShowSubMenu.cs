using Animals.Animals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Animals.Menu
{
    internal class ShowSubMenu
    {
        public static void ShowAnimalsMenu()
        {
            Console.WriteLine("Witamy w atlasie zwierząt!");

            List<Mammals> mammals;
            List<Fish> fish;
            List<Birds> birds;

            string mammals_path = @"mammals.json";
            string json_mammals = File.ReadAllText(mammals_path);
            mammals = JsonSerializer.Deserialize<List<Mammals>>(json_mammals);

            string fish_path = @"fish.json";
            string json_fish = File.ReadAllText(fish_path);
            fish = JsonSerializer.Deserialize<List<Fish>>(json_fish);

            string birds_path = @"birds.json";
            string json_birds = File.ReadAllText(birds_path);
            birds = JsonSerializer.Deserialize<List<Birds>>(json_birds);

            string[] keys = { "Pokaż ssaki", "Pokaż ptaki", "Pokaż ryby" };
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
                    
                    ShowAnimals.ShowMammals(mammals);
                    break;
                case "2":
                    Console.Clear();
                    ShowAnimals.ShowFish(fish);
                    break;
                case "3":
                    Console.Clear();
                    ShowAnimals.ShowBirds(birds);
                    break;
                default:
                    break;
            }
        }
    }
}
