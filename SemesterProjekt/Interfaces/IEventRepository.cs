using SemesterProjekt.Model;
namespace SemesterProjekt
{
    public interface IEventRepository
    {
        List<Event> GetAllEvents();
        Event GetEvent(int id);
        void AddEvent(Event e);
        void RemoveEvent(int id);
        void EditEvent(Event e);
    }
}
