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



    }
}
