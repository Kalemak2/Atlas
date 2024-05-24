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

        public Animals(int id, string name, string description, string habitat, string diet, string lifestyle,  DateTime datecreated)
        {
            Id = id;
            Name = name;
            Description = description;
            Habitat = habitat;
            Diet = diet;
            Lifestyle = lifestyle;
            CreationDate = datecreated;
        }

    }

    internal class Mammals : Animals
    {
        public string Type_of_Limbs { get; set; }
        public string Locomotion_On_Land { get; set; }
        public string Communication_Methods { get; set; }

        public Mammals(int id, string name, string description, string habitat, string diet, string lifestyle, DateTime datecreated, string limbs, string locomotion, string communication)
            : base(id, name , description, habitat, diet, lifestyle, datecreated)
        {
            Type_of_Limbs = limbs;
            Locomotion_On_Land = locomotion;
            Communication_Methods = communication;

        }
    }
    
    internal class Fish : Animals
    {
        public string Body_Shape { get; set; }
        public string Type_Of_Fins { get; set; }
        public string Body_covering { get; set; }


        public Fish(int id, string name, string description, string habitat, string diet, string lifestyle, DateTime datecreated, string shape, string fins, string covering)
           : base(id, name, description, habitat, diet, lifestyle, datecreated)
        {
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

        public Birds(int id, string name, string description, string habitat, string diet, string lifestyle, DateTime datecreated, string nest, string beak, string plumage)
           : base(id, name, description, habitat, diet, lifestyle, datecreated)
        {
            Nest_Building_Methods = nest;
            Beak_Shape = beak;
            Plumage_Type = plumage;

        }
    }


}
