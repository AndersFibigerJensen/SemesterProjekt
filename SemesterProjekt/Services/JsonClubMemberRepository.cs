using SemesterProjekt.Helpers;
using SemesterProjekt.Interfaces;
using SemesterProjekt.Model;

namespace SemesterProjekt.Services
{
    public class JsonClubMemberRepository : IClubMemberRepository
    {
        string filepath = @"Data\JsonClubMembers.json";
        public void AddClubMember(ClubMember clubMember)
        {
            List<ClubMember> clubMembers = GetAllClubMembers();
            clubMembers.Add(clubMember);
            JsonFileWriter.WritetoJsonClubMembers(clubMembers,filepath);
        }
        
        public void DeleteClubMember(int id)
        {
            ClubMember clubMemberToDelete = GetClubMember(id);
            List<ClubMember> clubMembers = GetAllClubMembers();
            clubMembers.Remove(clubMemberToDelete);
            JsonFileWriter.WritetoJsonClubMembers(clubMembers, filepath);
        }

        public void EditClubMember(ClubMember clubMember)
        {
            if (clubMember != null)
            {
                List<ClubMember> clubMembers = GetAllClubMembers();
                foreach(ClubMember member in clubMembers)
                {
                    if (member.Id == clubMember.Id)
                    {
                        member.Name = clubMember.Name;
                        member.Age = clubMember.Age;
                    }
                }
                JsonFileWriter.WritetoJsonClubMembers(clubMembers, filepath);
            }
        }

        public List<ClubMember> GetAllClubMembers()
        {
            return JsonFileReader.ReadJsonClubmember(filepath);
        }

        public ClubMember GetClubMember(int id)
        {
            List<ClubMember> clubMembers = GetAllClubMembers();
            foreach(ClubMember member in clubMembers)
                if(member.Id == id)
                    return member;
            return null;

        }

        public List<ClubMember> SearchForClubMember(string search)
        {
            List<ClubMember> searchResult = new List<ClubMember>();
            foreach (ClubMember member in GetAllClubMembers())
            {

                if (member.Name.ToLower().Contains(search.ToLower()))
                {
                    searchResult.Add(member);
                }
            }
            return searchResult;
        }
    }
}
