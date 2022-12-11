using SemesterProjekt.Helpers;
using SemesterProjekt.Model;
using SemesterProjekt.Interfaces;
using Microsoft.Extensions.Logging;

namespace SemesterProjekt.Services
{
    public class JsonEventRepository : IEventRepository
    {
        string filepath = @"Data\JsonEvents.json";

        public void AddEvent(Event e)
        {
            List<Event> events = GetAllEvents();
            events.Add(e);
            JsonFileWriter.WritetoJsonEvent(events, filepath);
        }

        public void RemoveEvent(int id)
        {
            Event eventToRemove = GetEvent(id);
            List<Event> events = GetAllEvents();
            events.Remove(eventToRemove);
            JsonFileWriter.WritetoJsonEvent(events, filepath);
        }

        public void EditEvent(Event e)
        {
            if (e != null)
            {
                List<Event> events = GetAllEvents();
                foreach (Event ev in events)
                {
                    if (ev.Id == e.Id)
                    {
                        ev.Name = e.Name;
                        ev.Description = e.Description;
                        ev.FromDate = e.FromDate;
                        ev.ToDate=e.ToDate;
                    }
                }
                JsonFileWriter.WritetoJsonEvent(events, filepath);
            }
        }

        public List<Event> GetAllEvents()
        {
            return JsonFileReader.ReadJsonEvent(filepath);
        }

        public Event GetEvent(int id)
        {
            List<Event> events = GetAllEvents();
            foreach (Event item in events)
                if (item.Id == id)
                    return item;
            return new Event();
        }


        
    }
}
