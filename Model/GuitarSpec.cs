using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarApp.Model
{
    internal class GuitarSpec
    {
       public Builder Builder { get; }
       public string Model { get; }
       public Type Type { get; }
       public Wood BackWood { get; }
       public Wood TopWood { get; }

       public GuitarSpec(string model, Builder builder, Type type, Wood topWood,Wood backWood)
        {
            Builder = builder;
            Model = model;
            Type = type;
            BackWood = backWood;
            TopWood = topWood;
        }
        public bool MatchGuitar(GuitarSpec otherSpec)
        {
            if (Builder != otherSpec.Builder)
                return false;
            if (Model != otherSpec.Model && (Model.Equals("") )&& (!Model.Equals(otherSpec.Model)))
                return false;
            if(Type != otherSpec.Type)
                return false;
            if(BackWood!= otherSpec.BackWood) 
                return false;
            if (TopWood != otherSpec.TopWood)
                return false;
            return true;
        }

    }
}
