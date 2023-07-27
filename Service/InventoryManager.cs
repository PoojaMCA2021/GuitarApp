using GuitarApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace GuitarApp.Service
{
    internal class InventoryManager
    {
       public InventoryManager()
        {
            Inventory inventory = new Inventory();
            AddInventory(inventory);
            DisplayMenu(inventory);
        }

        private void DisplayMenu(Inventory inventory)
        {
            Console.WriteLine("------Welcome to Guitar App------");
            Console.WriteLine("Enter Your Choice:\n" +
                "1. Get Detail of Guitar\n" +
                "2. Search Guitar\n");
            int choice=Convert.ToInt32(Console.ReadLine());
            switch(choice)
            {
                case 1: GetDetail(inventory);
                        break;
                case 2: FindGuitar(inventory);
                        break;
                default: Console.WriteLine("Invalid Choice ");
                        break;
            }
        }

        private void FindGuitar(Inventory inventory)
        {
            List<Guitar> matchGuitar=inventory.Search(new GuitarSpec("ABC", Builder.Fender, Model.Type.Acoustic, Wood.Cocobold, Wood.Cocobold));
            Console.WriteLine("Your search results are here :-");
            if (matchGuitar.Count > 0)
            {
                foreach (Guitar guitar in matchGuitar)
                {
                    Console.WriteLine("-------------------------");
                    Console.WriteLine(guitar.ToString());
                    Console.WriteLine("-------------------------");
                }
            }
            else
            {
                Console.WriteLine("No result found");
            }
        }
        private static void AddInventory(Inventory inventory)
        {
            inventory.AddGuitar("12345", 15000, "ABC", Builder.Fender, Model.Type.Acoustic, Wood.Cocobold, Wood.Cocobold);
            inventory.AddGuitar("67890", 15000, "BCD", Builder.Ryan, Model.Type.Electric, Wood.Maple, Wood.Maple);
            inventory.AddGuitar("76890", 15000, "BCD", Builder.Ryan, Model.Type.Electric, Wood.Maple, Wood.Maple);
            inventory.AddGuitar("6780", 15000, "BCD", Builder.Martin, Model.Type.Electric, Wood.Sitka, Wood.Sitka);


        }
        private void GetDetail(Inventory inventory)
        {
            Console.WriteLine("Enter Seiral Number:");
            string serialNumber=Console.ReadLine();
            Guitar guitar=inventory.GetGuitar(serialNumber);
            
            if(guitar != null) 
            {
                Console.WriteLine("Details of Guitar Are:");
                Console.WriteLine(guitar.ToString());
            }
            else { Console.WriteLine("No such Guitar found"); }

        }
    }
}
