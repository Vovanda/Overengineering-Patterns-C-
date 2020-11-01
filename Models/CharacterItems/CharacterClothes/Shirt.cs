using System;
using System.Collections.Generic;
using System.Text;

namespace Models.CharacterItems.CharacterClothes
{
    public class Shirt : Clothes
    {
        public Shirt()
        {
            Name = nameof(Shirt);
            PartOfBody = BodyPartType.Legs;
        }
    }
}
