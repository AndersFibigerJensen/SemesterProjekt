using Microsoft.Extensions.Logging;
using SemesterProjekt.Helpers;
using SemesterProjekt.Interfaces;
using SemesterProjekt.Model;

namespace SemesterProjekt.Services
{
    public class JsonIBoatToEventRepository : IEventBoatRepository
    {
        string filepath= @"Data\JsonEventBoat.json";

        public void AddEventToBoat(int BoatId)
        {
            List<BoatToEvent> EventstoBoat = GetAllBoatsToEvent();
            //EventstoBoat.Add()
            JsonFileWriter.WritetoJsonBoatToEvent(EventstoBoat, filepath);
        }

        public void EditEventTOBoat(BoatToEvent be)
        {
            List<BoatToEvent> EventstoBoat = GetAllBoatsToEvent();
            if(be!=null)
            {
                foreach(BoatToEvent item in EventstoBoat)
                {
                    if(item.BookingID==be.BookingID)
                    {
                        item.BookingID=be.BookingID;
                        item.EventID = be.EventID;
                        item.BoatId=be.BoatId;
                    }
                }
                JsonFileWriter.WritetoJsonBoatToEvent(EventstoBoat, filepath);
            }
           
        }

        public List<BoatToEvent> GetAllBoatsToEvent()
        {
            return JsonFileReader.ReadJsonBoatToEvent(filepath);
        }

        public BoatToEvent GetBoatToEvent(int BookingID)
        {
            List<BoatToEvent> EventstoBoat = GetAllBoatsToEvent();
            foreach (BoatToEvent item in EventstoBoat)
                if (item.BookingID == BookingID)
                    return item;
            return new BoatToEvent();
        }

        public void RemoveEventToBoat(int BookingID)
        {
            List<BoatToEvent> EventstoBoat = GetAllBoatsToEvent();
            BoatToEvent boatToEventDelete = GetBoatToEvent(BookingID);
            EventstoBoat.Remove(boatToEventDelete);
            JsonFileWriter.WritetoJsonBoatToEvent(EventstoBoat, filepath);
        }
    }
}
