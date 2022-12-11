using SemesterProjekt.Model;

namespace SemesterProjekt.Interfaces
{
    public interface IEventBoatRepository
    {

        List<BoatToEvent> GetAllBoatsToEvent();
        BoatToEvent GetBoatToEvent(int BookingID);
        void AddEventToBoat( int BookingID);
        void RemoveEventToBoat(int BookingID);
        void EditEventTOBoat(BoatToEvent be);
    }
}
