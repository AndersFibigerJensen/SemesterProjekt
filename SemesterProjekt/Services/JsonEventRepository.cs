using SemesterProjekt.Helpers;
using SemesterProjekt.Model;

namespace SemesterProjekt.Services
{
    public class JsonEventRepository : IEventRepository
    {
        string filepath = @"Data\JsonEvents";

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
            JsonFileWriter.WritetoJsonBoat(events, filepath);
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
                        e.Name = ev.Name;
                        e.Description = ev.Description;
                        e.Date = ev.Date;
                    }
                }
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
