﻿namespace BarberShop.Models
{
    public class UpdateUserInformationModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Adress { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }
        public string Phone { get; set; }
    }
}