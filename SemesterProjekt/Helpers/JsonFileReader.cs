﻿using Microsoft.Extensions.Logging;
using SemesterProjekt.Model;
using System.Text.Json;

namespace SemesterProjekt.Helpers
{
    public class JsonFileReader
    {
        public static List<Boat> ReadJsonBoat(string jsonFileName)
        {
            using (var jsonFileReader = File.OpenText(jsonFileName))
            {
                string indata = jsonFileReader.ReadToEnd();
                return JsonSerializer.Deserialize<List<Boat>>(indata);
            }
        }


    }
}
