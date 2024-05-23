using System.Text.Json;

namespace Animals.Animals
{
    internal class AddAnimals : IAnimals
    {
        public void AddMammals(List<Mammals> mammals) 
        {
            Console.WriteLine("Dodawanie nowych ssaków do atlasu");

            Console.Write("Podaj nazwę ssaka: ");
            string name = Console.ReadLine();

            Console.Write("Podaj krótki opis ssaka: ");
            string description = Console.ReadLine();

            Console.Write("Podaj typ siedliska ssaka: ");
            string habitat = Console.ReadLine();

            Console.Write("Podaj dietę ssaka: ");
            string diet = Console.ReadLine();

            Console.Write("Podaj tryb życia ssaka: ");
            string lifestyle = Console.ReadLine();

            Console.Write("Podaj rodzaj kończyn: ");
            string limbs = Console.ReadLine();

            Console.Write("Podaj sposób poruszania się po lądzie: ");
            string locomotion = Console.ReadLine();

            Console.Write("Podaj sposoby komunikacji: ");
            string communication = Console.ReadLine();

            Mammals newMammal = new Mammals(mammals.Count + 1, name, description, habitat, diet, lifestyle, DateTime.Now, limbs, locomotion, communication);

            mammals.Add(newMammal);

            string json = JsonSerializer.Serialize(mammals);
            string mammalsPath = @"mammals.json";
            File.WriteAllText(mammalsPath, json);

            Console.WriteLine("Zwierzę zostało dodane do atlasu!");
        }


        public void AddFish(List<Fish> fish)
        {
            Console.WriteLine("Dodawanie nowych ryb do atlasu");

            Console.Write("Podaj nazwę ssaka: ");
            string name = Console.ReadLine();

            Console.Write("Podaj krótki opis ssaka: ");
            string description = Console.ReadLine();

            Console.Write("Podaj typ siedliska ssaka: ");
            string habitat = Console.ReadLine();

            Console.Write("Podaj diete ssaka: ");
            string diet = Console.ReadLine();

            Console.Write("Podaj diete ssaka: ");
            string lifestyle = Console.ReadLine();

            Console.Write("Podaj kształt ciała ryby:");
            string shape = Console.ReadLine();

            Console.Write("Podaj rodzaj płetw");
            string fins = Console.ReadLine();

            Console.Write("Podaj pokrycie ciała:");
            string covering = Console.ReadLine();




            Fish newFish = new Fish(fish.Count + 1, name, description, habitat, diet, lifestyle, DateTime.Now, shape, fins, covering);

            fish.Add(newFish);

            string json = JsonSerializer.Serialize(fish);
            string fishPath = @"fish.json";
            File.WriteAllText(fishPath, json);

            Console.WriteLine("Zwierze zostało dodane do atlasu!");
        }

        public  void AddBirds(List<Birds> birds)
        {
            Console.WriteLine("Dodawanie nowych ptaków do atlasu");

            Console.Write("Podaj nazwę ssaka: ");
            string name = Console.ReadLine();

            Console.Write("Podaj krótki opis ssaka: ");
            string description = Console.ReadLine();

            Console.Write("Podaj typ siedliska ssaka: ");
            string habitat = Console.ReadLine();

            Console.Write("Podaj diete ssaka: ");
            string diet = Console.ReadLine();

            Console.Write("Podaj tryb życia ssaka:");
            string lifestyle = Console.ReadLine();

            Console.Write("Podaj sposób budowania gniazd:");
            string nest = Console.ReadLine();

            Console.Write("Podaj kształt dzioba:");
            string beak = Console.ReadLine();

            Console.Write("Podaj rodzaj upierzenia:");
            string plumage = Console.ReadLine();




            Birds newBird = new Birds(birds.Count + 1, name, description, habitat, diet, lifestyle, DateTime.Now, nest, beak, plumage);

            birds.Add(newBird);

            string json = JsonSerializer.Serialize(birds);
            string birdsPath = @"birds.json";
            File.WriteAllText(birdsPath, json);

            Console.WriteLine("Zwierze zostało dodane do atlasu!");
        }
    }
}
