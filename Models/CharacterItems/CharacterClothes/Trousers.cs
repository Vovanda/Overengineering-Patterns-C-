using System;
using System.Collections.Generic;
using System.Text;

namespace Models.CharacterItems.CharacterClothes
{
    public class Trousers : Clothes
    {
        public Trousers()
        {
            Name = nameof(Trousers);
            PartOfBody = BodyPartType.Feet;
        }
    }
}
