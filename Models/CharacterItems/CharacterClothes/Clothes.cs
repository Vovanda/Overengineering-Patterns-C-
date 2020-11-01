using System;
using System.Collections.Generic;
using System.Text;

namespace Models.CharacterItems.CharacterClothes
{
    public class IClothes
    {
        public int Id;
        public int Armor;
        public string Name;
        public string Discription;
        public bool IsDestructible;
        public BodyPartType PartOfBody;
    }

    public class Clothes : IClothes
    {
        public int Id;
        public int Armor;
        public string Name;
        public string Discription;
        public bool IsDestructible;
        public BodyPartType PartOfBody;
    }

    public enum BodyPartType
    {
        Head,
        Body,
        Legs,
        Feet
    }
}
