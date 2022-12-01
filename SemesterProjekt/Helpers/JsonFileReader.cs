using Microsoft.Extensions.Logging;
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
        public static List<Event> ReadJsonEvent(string jsonFileName)
        {
            using (var jsonFileReader = File.OpenText(jsonFileName))
            {
                string indata = jsonFileReader.ReadToEnd();
                return JsonSerializer.Deserialize<List<Event>>(indata);
            }
        }

        public static List<RentalPeriod> ReadJsonRentalPeriod(string jsonFileName)
        {
            using (var jsonFileReader = File.OpenText(jsonFileName))
            {
                string indata = jsonFileReader.ReadToEnd();
                return JsonSerializer.Deserialize<List<RentalPeriod>>(indata);
            }
        }

    }
}
