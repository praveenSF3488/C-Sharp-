using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VaccinationDrive
{
    class BenificiaryDetails
    {
        public int RegisterNumber { get; }
        public string Name { get; set; }
        public long MobileNo { get; set; }
        public string City { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }

        public List<VaccineDetails> VaccinedetailList { get; set; }

        public BenificiaryDetails(int registerNumber,string Name, long MobileNo, string City, int Age, string Gender, List<VaccineDetails> Vaccination)
        {
            this.Name = Name;
            this.MobileNo = MobileNo;
            this.City = City;
            this.Age = Age;
            this.Gender = Gender;
            this.VaccinedetailList = Vaccination;
            this.RegisterNumber = registerNumber;
        }
        
    }
    public enum Gender
    {
        Male,
        Female,
        Transgender
    }
}
