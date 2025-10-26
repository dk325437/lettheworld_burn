using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp20;

namespace lettheworld_burn
{
    public class Editor : Person
    {
        public string Department { get; set; }

        public Editor() { }

        public Editor(int personid, string firstsname, string lastname, string email, string phonenumber, DateTime dateoftime, string department)
            : base(personid, firstsname, lastname, email, phonenumber, dateoftime)
        {
            Department = department;
        }

        public string GetRoleInfo()
        {
            return $"Biên tập viên, Bộ phận: {Department}";
        }
    }
}
