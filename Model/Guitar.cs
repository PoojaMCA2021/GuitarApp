using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarApp.Model
{
    internal class Guitar
    {
       public string SerialNumber { get; }
       public double Price { get; set; }
       public GuitarSpec Spec { get; set; }

       public Guitar(string seralNumber, double price, Builder builder,string model, Type type, Wood topWood, Wood backWood)
       { 
            SerialNumber = seralNumber;
            Price = price;  
            Spec=new GuitarSpec(  model, builder, type, topWood, backWood);
       }
        public override string ToString()
        {
            return $"Serial Number: {this.SerialNumber}\n" +
                 $"Model: {this.Spec.Model}\n" +
                 $"Builder: {this.Spec.Builder}\n" +
                 $"Type: {this.Spec.Type}\n" +
                 $"TopWood: {this.Spec.TopWood}\n" +
                 $"BackWood:{this.Spec.BackWood}\n" +
                 $"Price:{this.Price}\n";
        }
    }
}
