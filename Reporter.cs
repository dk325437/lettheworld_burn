using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp20;

namespace lettheworld_burn
{
    public class Reporter : Person
    {
        public string Area { get; set; } 

        public Reporter() { }

        public Reporter(int personid, string firstsname, string lastname, string email, string phonenumber, DateTime dateoftime, string area)
            : base(personid, firstsname, lastname, email, phonenumber, dateoftime)
        {
            Area = area;
        }

        public string GetRoleInfo()
        {
            return $"Phóng viên, Khu vực: {Area}";
        }
    }
}
