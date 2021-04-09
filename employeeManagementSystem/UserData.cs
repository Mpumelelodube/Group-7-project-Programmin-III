using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employeeManagementSystem
{
    class UserData
    {
        private String id;
        private String firstName;
        private String lastName;
        private String dob;
        private String gender;
        private int salary;
        private String brachID;
        private int PhoneNumber;
        private String Email;
        private String Adress;
        private String desegnation;

        public UserData(string id, string firstName, string lastName, string dob, string gender, int salary, string brachID, int phoneNumber, string email, string adress, string desegnation)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Dob = dob;
            this.Gender = gender;
            this.Salary = salary;
            this.BrachID = brachID;
            PhoneNumber1 = phoneNumber;
            Email1 = email;
            Adress1 = adress;
            this.Desegnation = desegnation;
        }

        public string Id { get => id; set => id = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Dob { get => dob; set => dob = value; }
        public string Gender { get => gender; set => gender = value; }
        public int Salary { get => salary; set => salary = value; }
        public string BrachID { get => brachID; set => brachID = value; }
        public int PhoneNumber1 { get => PhoneNumber; set => PhoneNumber = value; }
        public string Email1 { get => Email; set => Email = value; }
        public string Adress1 { get => Adress; set => Adress = value; }
        public string Desegnation { get => desegnation; set => desegnation = value; }
    }
}
