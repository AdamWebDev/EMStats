using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EMStats.Classes
{
    public class Reports
    {
        public class ReportResults
        {
            public int NumberOfCalls { get; set; }
            public int NumberOnTime { get; set; }
            public decimal PercentageOnTime
            {
                get
                {
                    if (NumberOfCalls > 0)
                        return (decimal)NumberOnTime / (decimal)NumberOfCalls * 100;
                    else
                        return 0;
                }
            }
        }

        public static ReportResults GetSuddenCariacArrest(DateTime start, DateTime end)
        {
            using (emsDBDataContext db = new emsDBDataContext())
            {
                int limit = 6 * 60; // in seconds
                ReportResults results = new ReportResults();
                results.NumberOnTime = db.EntryDetails.Where(c => c.Date >= start && c.Date <= end && c.CTAS_raw == 1 && c.VSA_raw > 1 && c.TDiff <= limit).Count();
                results.NumberOfCalls = db.EntryDetails.Where(c => c.Date >= start && c.Date <= end && c.CTAS_raw == 1 && c.VSA_raw > 1).Count();
                return results;
            }
        }

        public static ReportResults GetCTAS(int CTAS, int minutes, DateTime start, DateTime end)
        {
            using (emsDBDataContext db = new emsDBDataContext())
            {
                int limit = minutes * 60; // in seconds
                ReportResults results = new ReportResults();
                results.NumberOnTime = db.EntryDetails.Where(c => c.Date >= start && c.Date <= end && c.CTAS_raw == CTAS && c.TDiff <= limit).Count();
                results.NumberOfCalls = db.EntryDetails.Where(c => c.Date >= start && c.Date <= end && c.CTAS_raw == CTAS).Count();
                return results;
            }
        }
    }
}