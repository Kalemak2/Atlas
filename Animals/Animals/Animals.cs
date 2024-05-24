using System.Diagnostics;
using System.Text.Json.Serialization;

namespace Animals.Animals
{
    internal class Animals
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Habitat { get; set; }
        public string Diet { get; set; }
        public string Lifestyle { get; set; }
        public DateTime CreationDate { get; set; }

    }


    internal class Mammals : Animals
    {
        public string TypeofLimbs { get; set; }
        public string LocomotionOnLand { get; set; }
        public string CommunicationMethods { get; set; }

        public Mammals() { }
        public Mammals(int id, string name, string description, string habitat, string diet, string lifestyle, DateTime datecreated, string limbs, string locomotion, string communication)
        {
            Id = id;
            Name = name;
            Description = description;
            Habitat = habitat;
            Diet = diet;
            Lifestyle = lifestyle;
            CreationDate = datecreated;
            TypeofLimbs = limbs;
            LocomotionOnLand = locomotion;
            CommunicationMethods = communication;

        }
    }
    
    internal class Fish : Animals
    {
        public string Body_Shape { get; set; }
        public string Type_Of_Fins { get; set; }
        public string Body_covering { get; set; }

        public Fish() { }
        public Fish(int id, string name, string description, string habitat, string diet, string lifestyle, DateTime datecreated, string shape, string fins, string covering)
        {
            Id = id;
            Name = name;
            Description = description;
            Habitat = habitat;
            Diet = diet;
            Lifestyle = lifestyle;
            CreationDate = datecreated;
            Body_Shape = shape;
            Type_Of_Fins = fins;
            Body_covering = covering;

        }
    }

    internal class Birds : Animals
    {
        
        public string Nest_Building_Methods { get; set; }
        public string Beak_Shape { get; set; }
        public string Plumage_Type { get; set; }

        public Birds() { }
        public Birds(int id, string name, string description, string habitat, string diet, string lifestyle, DateTime datecreated, string nest, string beak, string plumage)
        {
            Id = id;
            Name = name;
            Description = description;
            Habitat = habitat;
            Diet = diet;
            Lifestyle = lifestyle;
            CreationDate = datecreated;
            Nest_Building_Methods = nest;
            Beak_Shape = beak;
            Plumage_Type = plumage;

        }
    }
}
