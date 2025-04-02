using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kulinaria_Efimov.Classes
{
    public class User
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Patronomic { get; set; }
        public DateTime DateOfBirthday { get; set; }
        public string Login {  get; set; }
        public string Password { get; set; }
        public string Phone {  get; set; }
        public string Adress { get; set; }
        public string Email { get; set; }
        public string PassportSeries { get; set; }
        public string PassportNumber { get; set; }
        public string PassportKemVidan {  get; set; }
        public DateTime PassportVidanDate { get; set; }
        public int RoleId { get; set; }

        public User(int userId, string firstName, string lastName, string patronomic, DateTime dateOfBirthday, string login, string password, string phone, string adress, string email, string passportSeries, string passportNumber, string passportKemVidan, DateTime passportVidanDate, int roleId)
        {
            UserId = userId;
            FirstName = firstName;
            LastName = lastName;
            Patronomic = patronomic;
            DateOfBirthday = dateOfBirthday;
            Login = login;
            Password = password;
            Phone = phone;
            Adress = adress;
            Email = email;
            PassportSeries = passportSeries;
            PassportNumber = passportNumber;
            PassportKemVidan = passportKemVidan;
            PassportVidanDate = passportVidanDate;
            RoleId = roleId;
        }
    }
}
