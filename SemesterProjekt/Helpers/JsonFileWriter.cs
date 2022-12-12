using Microsoft.Extensions.Logging;
using SemesterProjekt.Model;
using System.Text.Json;

namespace SemesterProjekt.Helpers
{
    public class JsonFileWriter
    {
        public static void WritetoJsonBoat(List<Boat> Boats, string jsonFileName)
        {
            //using(FileStream outputStream =File.OpenWrite(jsonFileName))
            using (FileStream outputStream = File.Create(jsonFileName))
            {
                var writter = new Utf8JsonWriter(outputStream, new JsonWriterOptions
                {
                    SkipValidation = false,
                    Indented = true,
                });
                JsonSerializer.Serialize<Boat[]>(writter, Boats.ToArray());
            }
        }
        public static void WritetoJsonEvent(List<Event> Events, string jsonFileName)
        {
            //using(FileStream outputStream =File.OpenWrite(jsonFileName))
            using (FileStream outputStream = File.Create(jsonFileName))
            {
                var writter = new Utf8JsonWriter(outputStream, new JsonWriterOptions
                {
                    SkipValidation = false,
                    Indented = true,
                });
                JsonSerializer.Serialize<Event[]>(writter, Events.ToArray());
            }
        }

        public static void WritetoJsonRentalPeriod(List<RentalPeriod> rentalPeriods, string jsonFileName)
        {
            //using(FileStream outputStream =File.OpenWrite(jsonFileName))
            using (FileStream outputStream = File.Create(jsonFileName))
            {
                var writter = new Utf8JsonWriter(outputStream, new JsonWriterOptions
                {
                    SkipValidation = false,
                    Indented = true,
                });
                JsonSerializer.Serialize<RentalPeriod[]>(writter, rentalPeriods.ToArray());
            }
        }

        public static void WritetoJsonClubMembers(List<ClubMember> clubMembers, string jsonFileName)
        {
            //using(FileStream outputStream =File.OpenWrite(jsonFileName))
            using (FileStream outputStream = File.Create(jsonFileName))
            {
                var writter = new Utf8JsonWriter(outputStream, new JsonWriterOptions
                {
                    SkipValidation = false,
                    Indented = true,
                });
                JsonSerializer.Serialize<ClubMember[]>(writter, clubMembers.ToArray());
            }
        }

        public static void WritetoJsonBoatToEvent(List<BoatToEvent> boatToEvents, string jsonFileName)
        {
            //using(FileStream outputStream =File.OpenWrite(jsonFileName))
            using (FileStream outputStream = File.Create(jsonFileName))
            {
                var writter = new Utf8JsonWriter(outputStream, new JsonWriterOptions
                {
                    SkipValidation = false,
                    Indented = true,
                });
                JsonSerializer.Serialize<BoatToEvent[]>(writter, boatToEvents.ToArray());
            }
        }
        public static void WritetoJsonClubmemberToEvent(List<ClubmemberToEvent> ClubmemberToEvents, string jsonFileName)
        {
            //using(FileStream outputStream =File.OpenWrite(jsonFileName))
            using (FileStream outputStream = File.Create(jsonFileName))
            {
                var writter = new Utf8JsonWriter(outputStream, new JsonWriterOptions
                {
                    SkipValidation = false,
                    Indented = true,
                });
                JsonSerializer.Serialize<ClubmemberToEvent[]>(writter, ClubmemberToEvents.ToArray());
            }
        }
    }
}
