using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace GuitarApp.Model
{
    internal class Inventory
    {
        List<Guitar> guitars;
        public Inventory() 
        {
           guitars = new List<Guitar>();
           
        }
        public void AddGuitar(string serialNumber,double price,string model, Builder builder,Type type, Wood topWood, Wood backWood)
        {
            guitars.Add(new Guitar(serialNumber, price,  builder, model, type, topWood, backWood));
        }
        public Guitar GetGuitar(string serialNumber)
        {
            foreach(Guitar  guitar in guitars)
            {
                if(guitar.SerialNumber == serialNumber)
                    return guitar;
            }
            return null;
        }

        public List<Guitar> Search(GuitarSpec searchguitar)
        {
            List<Guitar> matchGuitar= new List<Guitar>();
            foreach(Guitar guitar in guitars)
            {
                if(guitar.Spec.MatchGuitar(searchguitar))
                {
                    matchGuitar.Add(guitar);
                }
            }
            return matchGuitar;
        }
    }
}
