﻿using Microsoft.Extensions.Logging;
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

        public void DeleteBoat(int id)
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
                        bo.Name = b.Name;
                        bo.Width = b.Width;
                        bo.Weight = b.Weight;
                        bo.Length = b.Length;
                        bo.MinimumCrew = b.MinimumCrew;
                        bo.TopSpeed = b.TopSpeed;
                    }
                }
            }
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