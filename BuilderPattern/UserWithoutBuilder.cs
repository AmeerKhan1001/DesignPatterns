using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class UserWithoutBuilder
    {
        public string? Username { get; set; }
        public string? Password { get; set; }
        public string? Email { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Address { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? ZipCode { get; set; }
        public string? PhoneNumber { get; set; }

        // Constructor with all 10 parameters
        public UserWithoutBuilder(string username, string password, string email, string firstName, string lastName, string address, string city, string state, string zipCode, string phoneNumber)
        {
            Username = username;
            Password = password;
            Email = email;
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            City = city;
            State = state;
            ZipCode = zipCode;
            PhoneNumber = phoneNumber;
        }

        // Constructor with some parameters
        public UserWithoutBuilder(string username, string password, string email, string address)
        {
            Username = username;
            Password = password;
            Email = email;
            Address = address;
        }

        // Constructor with minimal parameters
        public UserWithoutBuilder(string username, string password)
        {
            Username = username;
            Password = password;
        }

        // Additional constructors with different parameter combinations can be added as needed.

        public override string ToString()
        {
            return $"UserWithoutBuilder: Username - {Username}, Email - {Email}, Name - {FirstName} {LastName}, Address - {Address}, City - {City}, State - {State}, ZipCode - {ZipCode}, Phone - {PhoneNumber}";
        }
    }
}
