﻿using Microsoft.Extensions.Logging;
using SemesterProjekt.Helpers;
using SemesterProjekt.Interfaces;
using SemesterProjekt.Model;
using System.Runtime.CompilerServices;

namespace SemesterProjekt.Services
{
    public class JsonIRentalSchedule : IRentalSchedule
    {

        string filepath = @"Data\RentalPeriod.json";

        public void AddRentalPeriod(RentalPeriod re)
        {
            List<RentalPeriod> periods = GetAllRentalPeriods();
            List<int> RentalID = new List<int>();

            foreach (RentalPeriod ren in periods)
            {
                RentalID.Add(ren.Id);
            }
            if (RentalID.Count != 0)
            {
                int start = RentalID.Max();
                re.Id = start + 1;
            }
            else
            {
                re.Id = 1;
            }
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
                        period.Verification = re.Verification;
                        period.RentalperiodTo = re.RentalperiodTo;
                    }

                }
                JsonFileWriter.WritetoJsonRentalPeriod(periods, filepath);
            }
        }

        public List<RentalPeriod> GetAllRentalPeriods()
        {
            return JsonFileReader.ReadJsonRentalPeriod(filepath);
        }

        public RentalPeriod GetRentalPeriod(int id)
        {
            List<RentalPeriod> periods = GetAllRentalPeriods();
            foreach(RentalPeriod period in periods)
            {
                if(period.Id == id)
                    return period;
            }
            return new RentalPeriod();
        }

        public void RemoveRentalPeriod(int id)
        {
            RentalPeriod period =GetRentalPeriod(id);
            List<RentalPeriod> periods = GetAllRentalPeriods();
            periods.Remove(period);
            JsonFileWriter.WritetoJsonRentalPeriod(periods, filepath);
        }
    }
}
