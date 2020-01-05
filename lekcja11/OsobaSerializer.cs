﻿using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.IO;

namespace lekcja11
{
    public static class OsobaSerializer
    {
        public static void SerializeOsoby(IEnumerable<Osoba> osoby, string filename)
        {
            string serialized = JsonConvert.SerializeObject(osoby);
            Console.WriteLine($"zserializowane osoby:{serialized}");
            File.WriteAllText(@filename, serialized);
        }

        public static List<Osoba> DeserializeOsoby(string filename)
        {
            List<Osoba> osoby = new List<Osoba>();
            var json = System.IO.File.ReadAllText(@filename);
            Console.WriteLine($"Odczytany json: {json}");
            osoby = JsonConvert.DeserializeObject<List<Osoba>>(json);
            
            return osoby;
        }
    }
}
