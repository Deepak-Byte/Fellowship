using Nancy.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DEEPAKKPASI
{
    class InventoryManagement
    {
        List<Inventory> listInventory;

        internal List<Inventory> ListInventory { get => listInventory; set => listInventory = value; }

        public void writeFile(String filename)
        {
            JavaScriptSerializer jss = new JavaScriptSerializer();
            string jsonformatoutput = jss.Serialize(listInventory);
            File.WriteAllText(filename, jsonformatoutput);
            Console.WriteLine("Succesfully added");
        }

        public List<Inventory> readFile(String filename)
        {
            JavaScriptSerializer jss = new JavaScriptSerializer();
            List<Inventory> list;

            string path = File.ReadAllText(filename);
            list = jss.Deserialize<List<Inventory>>(path);
            Console.WriteLine(list);
            return list;
        }
    }
}
