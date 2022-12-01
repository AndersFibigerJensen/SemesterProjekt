using SemesterProjekt.Helpers;
using SemesterProjekt.Interfaces;
using SemesterProjekt.Model;
using System.Runtime.CompilerServices;

namespace SemesterProjekt.Services
{
    public class JsonRentalSchedule : IRentalSchedule
    {

        string filepath = @"Data\RentalPeriod";

        public void AddRentalPeriod(RentalPeriod re)
        {
            List<RentalPeriod> periods = new List<RentalPeriod>();
            periods.Add(re);
            JsonFileWriter.WritetoJsonRentalPeriod(periods,filepath);
        }

        public void EditRentalPeriod(RentalPeriod re)
        {
            List<RentalPeriod> periods = new List<RentalPeriod>();
            foreach(RentalPeriod period in periods)
            JsonFileWriter.WritetoJsonRentalPeriod(periods, filepath);
        }

        public List<RentalPeriod> GetAllRentalPeriods()
        {
            return JsonFileReader.ReadJsonRentalPeriod(filepath);
        }

        public RentalPeriod GetRentalPeriod(int id)
        {
            List<RentalPeriod> periods = new List<RentalPeriod>();
            foreach(RentalPeriod period in periods)
            {
                if(period.Id == id)
                    return period;
            }
            return new RentalPeriod();
            JsonFileWriter.WritetoJsonRentalPeriod(periods, filepath);
        }

        public void RemoveRentalPeriod(int id)
        {
            List<RentalPeriod> periods = new List<RentalPeriod>();
            throw new NotImplementedException();
            JsonFileWriter.WritetoJsonRentalPeriod(periods, filepath);
        }
    }
}
