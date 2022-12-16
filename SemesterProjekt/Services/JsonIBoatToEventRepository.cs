using Microsoft.Extensions.Logging;
using SemesterProjekt.Helpers;
using SemesterProjekt.Interfaces;
using SemesterProjekt.Model;

namespace SemesterProjekt.Services
{
    public class JsonIBoatToEventRepository : IEventBoatRepository
    {
        string filepath= @"Data\JsonEventBoat.json";

        public void AddEventToBoat(BoatToEvent be)
        {
            List<BoatToEvent> EventstoBoat = GetAllBoatsToEvent();
            List<int> EventID = new List<int>();

            foreach (BoatToEvent bo in EventstoBoat)
            {
                EventID.Add(bo.BookingID);
            }
            if (EventID.Count != 0)
            {
                int start = EventID.Max();
                be.BookingID = start + 1;
            }
            else
            {
                be.BookingID = 1;
            }
            EventstoBoat.Add(be);
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

        public List<int> GetAllBoatsToEventIds(int eventid)
        {
            List<BoatToEvent> boatToEvent = GetAllBoatsToEvent();
            List<int> boatToEventIds = new List<int>();
            foreach(BoatToEvent item in boatToEvent)
            {
                if(item.EventID==eventid)
                {
                    boatToEventIds.Add(item.BoatId);
                }
            }
            return boatToEventIds;
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
