using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals.Animals
{
    internal interface IAnimals
    {
        void AddMammals(List<Mammals> mammals);
        void AddFish(List<Fish> fish);
        void AddBirds(List<Birds> birds);
    }
}
