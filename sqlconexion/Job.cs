using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sqlconexion
{
    class Job
    {
        private int jobID;
        private string jobTitle;
        private decimal? minSal;
        private decimal? maxSal;

        public int JobID { get => jobID; set => jobID = value; }
        public string JobTitle { get => jobTitle; set => jobTitle = value; }
        public decimal? MinSal { get => minSal; set => minSal = value; }
        public decimal? MaxSal { get => maxSal; set => maxSal = value; }

        public Job()
        {
            jobID = JobID;
            jobTitle = JobTitle;
            minSal = MinSal;
            maxSal = MaxSal;
        }

        public override string ToString()
        {
                return "Job-Id: " + JobID +
                    ", Job-Title: " + JobTitle +
                    ", Min-Salary: " + (MinSal == null ? "null" : MinSal.ToString()) +
                    ", Max-Salary: " + (MaxSal == null ? "null" : "" + MaxSal) + ".";
            
            
        }
    }
}
