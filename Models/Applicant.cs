using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HDDesicions.Models
{
    public class Applicant
    {
        public string FirstName
        { get; set; }

        public string LastName
        { get; set; }

        public string DOB
        { get; set; }

        public string Income
        { get; set; }

        public int CalculateAge (string applicationDOB)
        {

            int now = int.Parse(DateTime.Now.ToString("yyyyMMdd"));
            int dob = int.Parse(applicationDOB);

            return int.Parse(((now - dob) / 10000).ToString().Substring(0,1));
        }

        public int ValidateApplication(string applicationDOB, string income)
        {
            if(CalculateAge(applicationDOB) > 18)
            {
                if (int.Parse(income) > 30000)
                    return 1;
                else
                    return 2;
            }
            else
            {
                return 0;
            }
        }
    }
}