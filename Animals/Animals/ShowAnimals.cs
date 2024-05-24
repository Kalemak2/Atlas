using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals.Animals
{
    internal class ShowAnimals
    {
        public static void ShowMammals(List<Mammals> mammals)
        {
            if (mammals.Count == 0)
            {
                Console.WriteLine("Brak ssaków w atlasie!");
            }
            else
            {
                foreach (var mammal in mammals)
                {
                    Console.WriteLine("-----------------------");
                    Console.WriteLine($"ID: {mammal.Id}");
                    Console.WriteLine($"Nazwa: {mammal.Name}");
                    Console.WriteLine($"Opis: {mammal.Description}");
                    Console.WriteLine($"Siedlisko: {mammal.Habitat}");
                    Console.WriteLine($"Dieta: {mammal.Diet}");
                    Console.WriteLine($"Tryb życia: {mammal.Lifestyle}");
                    Console.WriteLine($"Rodzaj kończyn: {mammal.TypeofLimbs}");
                    Console.WriteLine($"Sposób poruszania się po lądzie: {mammal.LocomotionOnLand}");
                    Console.WriteLine($"Sposoby komunikacji: {mammal.CommunicationMethods}");
                    Console.WriteLine($"Data utworzenia: {mammal.CreationDate}");
                    Console.WriteLine("-----------------------");
                }
            }
        }
        public static void ShowFish(List<Fish> fish)
        {
            if (fish.Count == 0)
            {
                Console.WriteLine("Brak ryb w atlasie!");
            }
            else
            {
                foreach (var fis in fish)
                {
                    Console.WriteLine("-----------------------");
                    Console.WriteLine($"ID: {fis.Id}");
                    Console.WriteLine($"Nazwa: {fis.Name}");
                    Console.WriteLine($"Opis: {fis.Description}");
                    Console.WriteLine($"Siedlisko: {fis.Habitat}");
                    Console.WriteLine($"Dieta: {fis.Diet}");
                    Console.WriteLine($"Tryb życia: {fis.Lifestyle}");
                    Console.WriteLine($"Kształt ciała: {fis.Body_Shape}");
                    Console.WriteLine($"Rodzaj płetw: {fis.Type_Of_Fins}");
                    Console.WriteLine($"Pokrycie ciała: {fis.Body_covering}");
                    Console.WriteLine($"Data utworzenia: {fis.CreationDate}");
                    Console.WriteLine("-----------------------");
                }
            }
        }
        public static void ShowBirds(List<Birds> birds)
        {
            if (birds.Count == 0)
            {
                Console.WriteLine("Brak ptaków w atlasie!");
            }
            else
            {
                foreach (var bird in birds)
                {
                    Console.WriteLine("-----------------------");
                    Console.WriteLine($"ID: {bird.Id}");
                    Console.WriteLine($"Nazwa: {bird.Name}");
                    Console.WriteLine($"Opis: {bird.Description}");
                    Console.WriteLine($"Siedlisko: {bird.Habitat}");
                    Console.WriteLine($"Dieta: {bird.Diet}");
                    Console.WriteLine($"Tryb życia: {bird.Lifestyle}");
                    Console.WriteLine($"Rodzaj kończyn: {bird.Nest_Building_Methods}");
                    Console.WriteLine($"Sposób poruszania się po lądzie: {bird.Beak_Shape}");
                    Console.WriteLine($"Sposoby komunikacji: {bird.Plumage_Type}");
                    Console.WriteLine($"Data utworzenia: {bird.CreationDate}");
                    Console.WriteLine("-----------------------");
                }
            }
        }
    }
}

