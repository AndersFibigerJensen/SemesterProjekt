using SemesterProjekt.Helpers;
using SemesterProjekt.Interfaces;
using SemesterProjekt.Model;

namespace SemesterProjekt.Services
{
    public class JsonClubmemberToEvent : IClubmemberEvent
    {
        string filepath = @"Data\JsonClubmemberEvent.json";

        public void AddClubmemberToEvent(ClubmemberToEvent ce)
        {
            List<ClubmemberToEvent> clubMembers = GetAllClubmemberToEvent();
            clubMembers.Add(ce);
            JsonFileWriter.WritetoJsonClubmemberToEvent(clubMembers, filepath);
        }

        public void DeleteClubmemberToEvent(int id)
        {
            List<ClubmemberToEvent> clubmembers = GetAllClubmemberToEvent();
            ClubmemberToEvent clubmemberToDelete = GetClubmemberToEvent(id);
            clubmembers.Remove(clubmemberToDelete);
            JsonFileWriter.WritetoJsonClubmemberToEvent(clubmembers, filepath);
        }

        public void EditClubmemberToEvent(ClubmemberToEvent ce)
        {
            List<ClubmemberToEvent> clubmembers = GetAllClubmemberToEvent();
            if (ce != null)
            {
                foreach (ClubmemberToEvent item in clubmembers )
                {
                    if (item.BookingID == ce.BookingID)
                    {
                        item.BookingID = ce.BookingID;
                        item.EventID = ce.EventID;
                        item.ClubMemberID = ce.ClubMemberID;
                    }
                }
                JsonFileWriter.WritetoJsonClubmemberToEvent(clubmembers, filepath);
            }
        }

        public List<ClubmemberToEvent> GetAllClubmemberToEvent()
        {
            return JsonFileReader.ReadJsonClubmemberToEvent(filepath);
        }

        public ClubmemberToEvent GetClubmemberToEvent(int id)
        {
            List<ClubmemberToEvent> clubmembers=GetAllClubmemberToEvent();
            foreach (ClubmemberToEvent item in clubmembers)
                if (item.BookingID == id)
                    return item;
            return new ClubmemberToEvent();
        }
    }
}
