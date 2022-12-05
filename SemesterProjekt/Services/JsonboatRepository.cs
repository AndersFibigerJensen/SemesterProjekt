using Microsoft.Extensions.Logging;
using SemesterProjekt.Helpers;
using SemesterProjekt.Interfaces;
using SemesterProjekt.Model;

namespace SemesterProjekt.Services
{
    public class JsonboatRepository : IBoatRepository
    {
        string filepath =@"Data\JsonBoats.json";

        public void AddBoat(Boat bo)
        {
            List<Boat> boats = GetAllBoats();
            boats.Add(bo);
            JsonFileWriter.WritetoJsonBoat(boats,filepath);
        }

        public void addCrewmembertoBoats(int id,ClubMember member)
        {
            List<Boat> boats=GetAllBoats();
            Boat boat=GetBoat(id);
            boat.Crewlist.Add(member);
            JsonFileWriter.WritetoJsonBoat(boats, filepath);
        }


        public void DeleteBoat(int id)
        {
            Boat boatToDelete = GetBoat(id);
            List<Boat> boats = GetAllBoats();
            boats.Remove(boatToDelete);
            JsonFileWriter.WritetoJsonBoat(boats, filepath);
        }

        public void DeleteCrewmember(int id)
        {
            Boat boatToDelete = GetBoat(id);
            List<Boat> boats = GetAllBoats();
            boats.Remove(boatToDelete);
            JsonFileWriter.WritetoJsonBoat(boats, filepath);
        }



        public void EditBoat(Boat bo)
        {
          if(bo!=null)
            {
                List<Boat> boats = GetAllBoats();
                foreach(Boat b in boats)
                {
                    if(b.Id==bo.Id)
                    {
                        b.Name = bo.Name;
                        b.Width = bo.Width;
                        b.Weight = bo.Weight;
                        b.Length = bo.Length;
                        b.MinimumCrew = bo.MinimumCrew;
                        b.TopSpeed = bo.TopSpeed;
                    }
                }
                JsonFileWriter.WritetoJsonBoat(boats,filepath);
            }
        }

        public List<Boat> FilterBoats(string filter)
        {
            List<Boat> Boatlist = new List<Boat>();
            foreach(var item in GetAllBoats())
            {
                if(item.Name==filter)
                {
                    Boatlist.Add(item);
                }
            }
            return Boatlist;
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
