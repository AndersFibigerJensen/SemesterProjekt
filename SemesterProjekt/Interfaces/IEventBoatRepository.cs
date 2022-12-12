using SemesterProjekt.Model;

namespace SemesterProjekt.Interfaces
{
    public interface IEventBoatRepository
    {

        List<BoatToEvent> GetAllBoatsToEvent();
        BoatToEvent GetBoatToEvent(int BookingID);
        void AddEventToBoat(BoatToEvent be);
        void RemoveEventToBoat(int BookingID);
        void EditEventTOBoat(BoatToEvent be);

        List<int> GetAllBoatsToEventIds(int boatid);

    }
}
