using SemesterProjekt.Model;

namespace SemesterProjekt.Interfaces
{
    public interface IClubmemberEvent
    {
        List<ClubmemberToEvent> GetAllClubmemberToEvent();

        ClubmemberToEvent GetClubmemberToEvent(int id);

        void AddClubmemberToEvent(ClubmemberToEvent ce);

        void EditClubmemberToEvent(ClubmemberToEvent ce);

        void DeleteClubmemberToEvent(int id);
    }
}
