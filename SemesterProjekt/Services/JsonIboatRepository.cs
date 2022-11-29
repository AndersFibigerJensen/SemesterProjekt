using SemesterProjekt.Helpers;
using SemesterProjekt.Interfaces;
using SemesterProjekt.Model;

namespace SemesterProjekt.Services
{
    public class JsonIboatRepository : IBoatRepository
    {
        string filepath =@"Data\JsonBoats";

        public void AddBoat(Boat bo)
        {
            List<Boat> boats = GetAllBoats();
            boats.Add(bo);
            JsonFileWriter.WritetoJsonBoat(boats,filepath);
        }

        public void DeleteBoat()
        {
            throw new NotImplementedException();
        }

        public void EditBoat()
        {
            List<Boat> boats = GetAllBoats();
        }

        public List<Boat> GetAllBoats()
        {
            return JsonFileReader.ReadJsonBoat(filepath);
        }

        public Boat GetBoat(int id)
        {
            List<Boat> boats=GetAllBoats();
            foreach (Boat item in boats)
                if (item.Id == id)
                    return item;
            return new Boat();
        }
    }
}
