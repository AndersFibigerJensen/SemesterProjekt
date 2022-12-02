using SemesterProjekt.Helpers;
using SemesterProjekt.Interfaces;
using SemesterProjekt.Model;
using System.Runtime.CompilerServices;

namespace SemesterProjekt.Services
{
    public class JsonIRentalSchedule : IRentalSchedule
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
            
            if(re != null)
            {
                List<RentalPeriod> periods = GetAllRentalPeriods();
                foreach (RentalPeriod period in periods)
                {
                    if(re.Id == period.Id)
                    {
                        re.Verification = period.Verification;
                        re.RentalperiodTo = period.RentalperiodTo;
                    }

                }
            }
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
            RentalPeriod period =GetRentalPeriod(id);
            List<RentalPeriod> periods = new List<RentalPeriod>();
            periods.Remove(period);
            JsonFileWriter.WritetoJsonRentalPeriod(periods, filepath);
        }
    }
}
