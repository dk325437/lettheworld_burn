using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp20
{
    public class Person
    {
        public int PersonID { get; set; }
        public string Firstname { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        private DateTime _dateOfBirth;
        public DateTime DateofBirth
        {
            get { return _dateOfBirth; }
            set
            {
                if (value > DateTime.Today)
                {
                    throw new ArgumentException("Ngày Sinh không được là ngày trong tương lai.");
                }
                _dateOfBirth = value;
            }
        }

        public Person() { }
        public Person(int personid, string firstsname, string lastname, string email, string phonenumber, DateTime dateoftime)
        {
            PersonID = personid;
            Firstname = firstsname;
            LastName = lastname;
            Email = email;
            PhoneNumber = phonenumber;
            DateofBirth = dateoftime;
        }
    }
}