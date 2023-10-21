// User class

class User {

    constructor(username, password, email, firstName, lastName, address, city, state, zipCode, phoneNumber) {
        this.Username = username;
        this.Password = password;
        this.Email = email;
        this.FirstName = firstName;
        this.LastName = lastName;
        this.Address = address;
        this.City = city;
        this.State = state;
        this.ZipCode = zipCode;
        this.PhoneNumber = phoneNumber;
    }

    toString() {
        return `User: Username - ${this.Username}, Email - ${this.Email}, Name - ${this.FirstName} ${this.LastName}, Address - ${this.Address}, City - ${this.City}, State - ${this.State}, ZipCode - ${this.ZipCode}, Phone - ${this.PhoneNumber}`;
    }
}

// UserBuilder class
class UserBuilder {
    constructor() {
        this.user = new User();
    }

    withUsername(username) {
        this.user.Username = username;
        return this;
    }

    withPassword(password) {
        this.user.Password = password;
        return this;
    }

    withEmail(email) {
        this.user.Email = email;
        return this;
    }

    withFirstName(firstName) {
        this.user.FirstName = firstName;
        return this;
    }

    withLastName(lastName) {
        this.user.LastName = lastName;
        return this;
    }

    withAddress(address) {
        this.user.Address = address;
        return this;
    }

    withCity(city) {
        this.user.City = city;
        return this;
    }

    withState(state) {
        this.user.State = state;
        return this;
    }

    withZipCode(zipCode) {
        this.user.ZipCode = zipCode;
        return this;
    }

    withPhoneNumber(phoneNumber) {
        this.user.PhoneNumber = phoneNumber;
        return this;
    }

    build() {
        return this.user;
    }
}

// Main function
function main() {

    // Without Using Builder Pattern
    const user1 = new User(
        "davisdoe",
        undefined,
        undefined,
        undefined,
        undefined,
        "address",
        "city",
        "state",
        "12345",
        "123-456-7890"
    );

    console.log("User created without using Builder Pattern:");
    console.log(user1.toString());

    // Using Builder Pattern
    const user2 = new UserBuilder()
        .withUsername("davisdoe")
        .withPassword("secure123")
        .withEmail("john.doe@example.com")
        .withFirstName("John")
        .withLastName("Doe")
        .withAddress("address")
        .withCity("city")
        .withState("state")
        .withZipCode("12345")
        .withPhoneNumber("123-456-7890")
        .build();

    console.log("User created using Builder Pattern:");
    console.log(user2.toString());
}

// Run the main function
main();
