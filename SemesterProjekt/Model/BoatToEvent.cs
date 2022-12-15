namespace SemesterProjekt.Model
{
    public class BoatToEvent
    {
        public int BoatId { get; set; }

        public int EventID { get; set; }

        public int BookingID { get; set; }

        public override bool Equals(object? obj)
        {
            if (obj == null)
                return false;
            else
            {
                BoatToEvent other = (BoatToEvent)obj;
                if (other.BookingID == BookingID)
                    return true;
                else
                    return false;
            }
        }
    }
}
