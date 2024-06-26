﻿using Newtonsoft.Json;
using System;
using System.IO;
namespace TestTask.Utils
{
    static class ReadJson
    {
        const string fileName = "Pallets.json";
        static public Pallets[] ReadPallets()
        {
            string json = File.ReadAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fileName));

            Pallets[] parents = JsonConvert.DeserializeObject<Pallets[]>(json);
            return parents;
        }
    }
}
