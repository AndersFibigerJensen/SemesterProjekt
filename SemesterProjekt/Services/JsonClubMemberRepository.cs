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
            List<ClubMember> members = GetAllClubMembers();
            List<int> clubmembersID = new List<int>();

            foreach (ClubMember member in members)
            {
                clubmembersID.Add(member.Id);
            }
            if (clubmembersID.Count != 0)
            {
                int start = clubmembersID.Max();
                clubMember.Id = start + 1;
            }
            else
            {
                clubMember.Id = 1;
            }
            members.Add(clubMember);

            JsonFileWriter.WritetoJsonClubMembers(members,filepath);
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

        public List<ClubMember> ClubmemberList(List<int> ids)
        {
            List<ClubMember> members = new List<ClubMember>();
            foreach (int item in ids)
            {
                ClubMember clubMember=GetClubMember(item);
                members.Add((clubMember));
            }
            return members;
        }


    }
}
