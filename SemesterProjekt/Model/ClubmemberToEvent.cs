namespace SemesterProjekt.Model
{
    public class ClubmemberToEvent
    {
        public int ClubMemberID { get; set; }

        public int EventID { get; set; }

        public int BookingID { get; set; }

        public override bool Equals(object? obj)
        {
            if (obj == null)
                return false;
            else
            {
                ClubmemberToEvent other = (ClubmemberToEvent)obj;
                if (other.BookingID == BookingID)
                    return true;
                else
                    return false;
            }
        }
    }
}
