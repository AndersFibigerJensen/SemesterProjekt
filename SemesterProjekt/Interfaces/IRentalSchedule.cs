using SemesterProjekt.Model;

namespace SemesterProjekt.Interfaces
{
    public interface IRentalSchedule
    {
        List<RentalPeriod> GetAllEvents();
        Event GetRentalPeriod(int id);
        void AddRentalPeriod(RentalPeriod re);
        void RemoveRentalPeriod(int id);
        void EditRentalPeriod(RentalPeriod re);

    }
}
