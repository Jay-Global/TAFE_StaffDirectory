﻿namespace JuusoKoivunen_MobileDev_Project_2_Part_3_App.Model
{
    public class Employee
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }
        public string Role { get; set; }
        public string MobileNumber { get; set; }
        public string Email { get; set; }
    }
}