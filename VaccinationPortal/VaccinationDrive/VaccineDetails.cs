using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VaccinationDrive
{
    class VaccineDetails
    {
        public int Dosage { get; set; }
        public DateTime Date1 { get; set; }
        public DateTime Date2 { get; set; }
        public string VaccineType { get; set; }

        public VaccineDetails(int dosage,  string vaccineType, DateTime date1, DateTime date2)
        {
            this.Dosage = dosage;
            this.Date1 = date1;
            this.Date2 = date2;
            this.VaccineType = vaccineType;
        }
    }
    public enum VaccineType
    {
        Covaxine,
        Covishield
    }
}
