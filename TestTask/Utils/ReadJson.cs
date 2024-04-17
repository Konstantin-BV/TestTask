using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTask.Utils
{
    static class ReadJson
    {
        const string fileName = "data.json";
        static public Pallets[] ReadPallets()
        {
            string json = File.ReadAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fileName));

            Pallets[] parents = JsonConvert.DeserializeObject<Pallets[]>(json);
            return parents;
        }
    }
}
