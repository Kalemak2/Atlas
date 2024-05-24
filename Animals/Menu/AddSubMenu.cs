using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Animals.Animals;

namespace Animals.Menu
{
    internal class AddSubMenu
    {
        public static void AddAnimalsMenu()
        {
            AddAnimals animals = new AddAnimals();

            Console.WriteLine("Witamy w atlasie zwierząt!");

            List<Mammals> mammals;
            List<Fish> fish;
            List<Birds> birds;

            string[] keys = { "Dodaj ssaki", "Dodaj ptaki", "Dodaj ryby" };
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

                    string mammalspath = @"mammals.json";
                    string json_mammals = File.ReadAllText(mammalspath);
                    mammals = JsonSerializer.Deserialize<List<Mammals>>(json_mammals);

                    Console.Clear();
                    animals.AddMammals(mammals);
                    break;
                case "2":

                    string fishpath = "fish.json";
                    string json_fish = File.ReadAllText(fishpath);
                    fish = JsonSerializer.Deserialize<List<Fish>>(json_fish);

                    Console.Clear();
                    animals.AddFish(fish);
                    break;
                case "3":

                    string birds_path = "birds.json";
                    string json_birds = File.ReadAllText(birds_path);
                    birds = JsonSerializer.Deserialize<List<Birds>>(json_birds);

                    Console.Clear();
                    animals.AddBirds(birds);
                    break;
                default:
                    break;
            }
        }
    }
}
