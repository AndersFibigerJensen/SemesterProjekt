using SemesterProjekt.Model;

namespace SemesterProjekt.Interfaces
{
    public interface IBoatRepository
    {
        List<Boat> GetAllBoats();

        Boat GetBoat(int id);

        void AddBoat(Boat bo);

        void EditBoat(Boat bo);

        void DeleteBoat(int id);

        List<Boat> FilterBoats(string filter);


    }
}
