


using OOP_4;

namespace OOP4
{
    class Assignment
    {
        static void Main()
        {



            #region Question 01

            ///In this example, we start by defining the IAuthenticationService interface with two methods: AuthenticateUser and AuthorizeUser. 
            ///The BasicAuthenticationService class implements this interface and provides the specific implementation for these methods.

            User admin = new User("admin","admin",User.Role.User);

            IAuthenticationService authService = new BasicAuthenticationService();

            Console.WriteLine(authService.AuthenticateUser(admin));

            Console.WriteLine(authService.AuthorizeUser(admin,User.Role.Admin));


            ///In the BasicAuthenticationService class, the AuthenticateUser method compares the provided username and password with the stored credentials. It returns true if the user is authenticated and false otherwise. The AuthorizeUser method checks if the user with the given username has the specified role. It returns true if the user is authorized and false otherwise.
            ///In the Main method, we create an instance of the BasicAuthenticationService class and assign it to the authService variable of type IAuthenticationService. We then call the AuthenticateUser and AuthorizeUser methods using this interface reference.
            ///This implementation allows you to switch the authentication service implementation easily by creating a new class that implements the IAuthenticationService interface and providing the desired logic for authentication and authorization.

            #endregion


        }
    }
}