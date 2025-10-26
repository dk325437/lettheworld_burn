using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp20;

namespace lettheworld_burn
{
    public class ProgramHost : Person
    {
        public string ProgramName { get; set; } 

        public ProgramHost() { }

        public ProgramHost(int personid, string firstsname, string lastname, string email, string phonenumber,
                           DateTime dateoftime, string programname)
            : base(personid, firstsname, lastname, email, phonenumber, dateoftime)
        {
            ProgramName = programname;
        }

        public string GetRoleInfo()
        {
            return $"Người dẫn chương trình, Chương trình: {ProgramName}";
        }
    }
}
