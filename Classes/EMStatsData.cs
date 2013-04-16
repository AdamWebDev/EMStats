using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EMStats.Classes
{
    public class EMStatsData
    {
        // get entries for CTAS dropdown
        public static List<CTASs> GetCTASs()
        {
            using (emsDBDataContext db = new emsDBDataContext())
            {
                var q = from c in db.CTASses
                        where c.Active == true
                        select c;
                return q.ToList();
            }
        }

        // get entries for IV Attempts dropdown
        public static List<IVAttempts> GetIVAttempts()
        {
            using (emsDBDataContext db = new emsDBDataContext())
            {
                var q = from c in db.IVAttempts
                        where c.Active == true
                        select c;
                return q.ToList();
            }
        }

        //get entries for Symptom Relief dropdown
        public static List<SymptomReliefs> GetSymptomReliefs()
        {
            using (emsDBDataContext db = new emsDBDataContext())
            {
                var q = from c in db.SymptomReliefs
                        where c.Active == true
                        select c;
                return q.ToList();
            }
        }

        // get entries for VSA dropdown
        public static List<VSAs> GetVSAs()
        {
            using (emsDBDataContext db = new emsDBDataContext())
            {
                var q = from c in db.VSAs
                        where c.Active == true
                        select c;
                return q.ToList();
            }
        }

        // get entries for Call Types dropdown
        public static List<CallTypes> GetCallTypes()
        {
            using (emsDBDataContext db = new emsDBDataContext())
            {
                var q = from c in db.CallTypes
                        where c.Active == true
                        select c;
                return q.ToList();
            }
        }

        public static Entry GetEntry(int ID)
        {
            using (emsDBDataContext db = new emsDBDataContext())
            {
                var q = (from e in db.Entries
                        where e.ID == ID
                        select e).SingleOrDefault();
                return q;
            }
        }

        // retrieves the username from windows authentication and trims the domain from it, leaving only the bare username
        public static string GetUserName()
        {
            String username = HttpContext.Current.User.Identity.Name.ToString();
            String domain = System.Configuration.ConfigurationManager.AppSettings["YourDomain"] + "\\"; // double backslash as an escape character
            username = username.Replace(domain, "");
            return username;
        }

        
    }
}