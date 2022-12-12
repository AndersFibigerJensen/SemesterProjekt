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

        public static List<ClubMember> ReadJsonClubmember(string jsonFileName)
        {
            using (var jsonFileReader = File.OpenText(jsonFileName))
            {
                string indata = jsonFileReader.ReadToEnd();
                return JsonSerializer.Deserialize<List<ClubMember>>(indata);
            }
        }

        public static List<BlogPost> ReadJsonBlogPost(string jsonFileName)
        {
            using (var jsonFileReader = File.OpenText(jsonFileName))
            {
                string indata = jsonFileReader.ReadToEnd();
                return JsonSerializer.Deserialize<List<BlogPost>>(indata);
            }
        }

        public static List<BoatToEvent> ReadJsonBoatToEvent(string jsonFileName)
        {
            using (var jsonFileReader = File.OpenText(jsonFileName))
            {
                string indata = jsonFileReader.ReadToEnd();
                return JsonSerializer.Deserialize<List<BoatToEvent>>(indata);
            }
        }

        public static List<ClubmemberToEvent> ReadJsonClubmemberToEvent(string jsonFileName)
        {
            using (var jsonFileReader = File.OpenText(jsonFileName))
            {
                string indata = jsonFileReader.ReadToEnd();
                return JsonSerializer.Deserialize<List<ClubmemberToEvent>>(indata);
            }
        }

    }
}
