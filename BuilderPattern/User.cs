namespace BuilderPattern
{
    class User
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

        public override string ToString()
        {
            return $"User: Username - {Username}, Email - {Email}, Name - {FirstName} {LastName}, Address - {Address}, City - {City}, State - {State}, ZipCode - {ZipCode}, Phone - {PhoneNumber}";
        }
    }

    // UserBuilder class
    class UserBuilder
    {
        private User user = new User();

        public UserBuilder WithUsername(string username)
        {
            user.Username = username;
            return this;
        }

        public UserBuilder WithPassword(string password)
        {
            user.Password = password;
            return this;
        }

        public UserBuilder WithEmail(string email)
        {
            user.Email = email;
            return this;
        }

        public UserBuilder WithFirstName(string firstName)
        {
            user.FirstName = firstName;
            return this;
        }

        public UserBuilder WithLastName(string lastName)
        {
            user.LastName = lastName;
            return this;
        }

        public UserBuilder WithAddress(string address)
        {
            user.Address = address;
            return this;
        }

        public UserBuilder WithCity(string city)
        {
            user.City = city;
            return this;
        }

        public UserBuilder WithState(string state)
        {
            user.State = state;
            return this;
        }

        public UserBuilder WithZipCode(string zipCode)
        {
            user.ZipCode = zipCode;
            return this;
        }

        public UserBuilder WithPhoneNumber(string phoneNumber)
        {
            user.PhoneNumber = phoneNumber;
            return this;
        }

        public User Build()
        {
            return user;
        }
    }
}
