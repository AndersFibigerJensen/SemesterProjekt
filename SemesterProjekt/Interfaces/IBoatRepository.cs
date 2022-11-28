using SemesterProjekt.Model;

namespace SemesterProjekt.Interfaces
{
    public interface IBoatRepository
    {
        List<Boat> GetAllBoats();

        Boat GetBoat(int id);

        void AddBoat();

        void EditBoat();

        void DeleteBoat();

        


    }
}
