using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Demo_project
{
    public class Utility
    {
        public static void AddData()
        {
            int weight = 1000;
            int price = 101010;
            string name = "something dada";

            var result = "{'Name':'" + name + "','Weight':" + weight + ",'Price':" + price + "}";

            string filepath = @"C:\Users\admin\source\repos\Demo project\Demo project\JSON.json";
            var json = File.ReadAllText(filepath);
            var jsonobj = JObject.Parse(json);
            var rocearray = jsonobj.GetValue("rice") as JArray;
            var newrice = JObject.Parse(result);
            rocearray.Add(newrice);
            jsonobj["rice"] = rocearray;
            string newjsonresult = Newtonsoft.Json.JsonConvert.SerializeObject(jsonobj, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(filepath, newjsonresult);
            Console.WriteLine("Invetory Added");
        }
        public static void AddPulses()
        {
            int weight = 10;
            int price = 120;
            string name = "pulses";

            var result = "{'Name':'" + name + "','Weight':" + weight + ",'Price':" + price + "}";

            string filepath = @"C:\Users\admin\source\repos\Demo project\Demo project\JSON.json";
            var json = File.ReadAllText(filepath);
            var jsonobj = JObject.Parse(json);
            var rocearray = jsonobj.GetValue("pulses") as JArray;
            var newrice = JObject.Parse(result);
            rocearray.Add(newrice);
            jsonobj["pulses"] = rocearray;
            string newjsonresult = Newtonsoft.Json.JsonConvert.SerializeObject(jsonobj, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(filepath, newjsonresult);
            Console.WriteLine("Invetory Added");
        }
    }
}
