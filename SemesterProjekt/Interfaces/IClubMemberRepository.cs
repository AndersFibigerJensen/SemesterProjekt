using SemesterProjekt.Model;

namespace SemesterProjekt.Interfaces
{
    public interface IClubMemberRepository
    {
        List<ClubMember> GetAllClubMembers();
        ClubMember GetClubMember(int id);
        void AddClubMember(ClubMember clubMember);
        void EditClubMember(ClubMember clubMember);
        void DeleteClubMember(int id);
        List<ClubMember> SearchForClubMember(string search);
        List<ClubMember> ClubmemberList(List<int> ids);
    }
}
