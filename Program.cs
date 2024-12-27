


using OOP_4;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Threading.Channels;
using System;

namespace OOP4
{
    class Assignment
    {
        static void Main()
        {



            #region Question 01

            ///In this example, we start by defining the IAuthenticationService interface with two methods: AuthenticateUser and AuthorizeUser. 
            ///The BasicAuthenticationService class implements this interface and provides the specific implementation for these methods.

            //User admin = new User("admin","admin",User.Role.User);

            //IAuthenticationService authService = new BasicAuthenticationService();

            //Console.WriteLine(authService.AuthenticateUser(admin));

            //Console.WriteLine(authService.AuthorizeUser(admin,User.Role.Admin));


            ///In the BasicAuthenticationService class, the AuthenticateUser method compares the provided username and password with the stored credentials. It returns true if the user is authenticated and false otherwise. The AuthorizeUser method checks if the user with the given username has the specified role. It returns true if the user is authorized and false otherwise.
            ///In the Main method, we create an instance of the BasicAuthenticationService class and assign it to the authService variable of type IAuthenticationService. We then call the AuthenticateUser and AuthorizeUser methods using this interface reference.
            ///This implementation allows you to switch the authentication service implementation easily by creating a new class that implements the IAuthenticationService interface and providing the desired logic for authentication and authorization.

            #endregion


            #region Question 02
            //Question 02:
            //we define the INotificationService interface with a method SendNotification that takes a recipient and a message as parameters.
            //We then create three classes: EmailNotificationService, SmsNotificationService, and PushNotificationService, which implement the INotificationService interface.
            //In each implementation, we provide the logic to send notifications through the respective communication channel:
            //The EmailNotificationService class simulates sending an email by outputting a message to the console.
            //        The SmsNotificationService class simulates sending an SMS by outputting a message to the console.
            //The PushNotificationService class simulates sending a push notification by outputting a message to the console.
            //In the Main method, we create instances of each notification service class and call the SendNotification method with sample recipient and message values.
            //This implementation allows you to easily switch between different notification channels by creating new classes that implement the INotificationService interface and provide the specific logic for each channel.

            //INotificationService email = new EmailNotificationService();
            //INotificationService sms = new SmsNotificationService();
            //INotificationService push = new PushNotificationService();

            //email.SendNotification("Abdelrahman@gmail.com","Where are you");
            //sms.SendNotification("3515995081", "Where are you");
            //push.SendNotification("Abdelrahman", "Where are you");


            #endregion      


        }
}
}