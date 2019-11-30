using System;
using System.Collections;
using System.Collections.Generic;

namespace DEEPAKKPASI
{
    class Program
    {
        static void Main(string[] args)
        {
            InventoryManagement im = new InventoryManagement();

            List<Inventory> list = new List<Inventory>();

            Console.WriteLine("how many inventory you want to create  ...");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter " + (i + 1) +"Inventory...");
                String type = Console.ReadLine();

                Console.WriteLine("Enter how many inventory you want to add...of type " + type);
                int xx = int.Parse(Console.ReadLine());
                for(int j=0;j<xx;j++)
                {
                    Console.WriteLine("Enter Inventory type : "+type);
                    String nameofItem = Console.ReadLine();

                    Console.WriteLine("Enter Weight: ");
                    int w = int.Parse( Console.ReadLine());

                    Console.WriteLine("Enter Price : ");
                    int p = int.Parse(Console.ReadLine());

                    Inventory inventory = new Inventory();
                    inventory.Type = type;
                    inventory.NameofItem = nameofItem;
                    inventory.Weight = w;
                    inventory.Price = p;
                    list.Add(inventory);
                }

            }
            

            im.ListInventory = list;
            String filename = @"C:\Users\admin\source\repos\DEEPAKKPASI\DEEPAKKPASI\inventory.json";
            im.writeFile(filename);
            list = im.readFile(filename);

            foreach(Inventory inventory1 in list)
            {
                Console.WriteLine("Type :" + inventory1.Type);
                Console.WriteLine("Name of Item :" + inventory1.NameofItem);
                Console.WriteLine("Weight :" + inventory1.Weight);
                Console.WriteLine("Price :" + inventory1.Price);
            }

            Console.ReadKey();

        }
    }
}
