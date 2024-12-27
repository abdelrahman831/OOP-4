


using OOP_4;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Threading.Channels;
using System;
using System.Drawing;
using System.Runtime.Intrinsics.X86;

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


            #region Part 02 First Project
            ///Define 3D Point Class and the basic Constructors(use chaining in constructors).
            ///Override the ToString Function to produce this output:
            ///            Point3D P = new Point3D(10, 10, 10);
            ///            Console.WriteLine(P.ToString());
            ///        Output: “Point Coordinates: (10, 10, 10)”.
            /// Read from the User the Coordinates for 2 points P1, P2(Check the input using try Pares, Parse, Convert).

            ///Try to use ==
            ///If(P1 == P2)   Does it work properly? 
            ///Define an array of points and sort this array based on X &Y coordinates.
            ///Implement ICloneable interface to be able to clone the object.
            ///To implement more than one interface.
            ///class Point3D : IComparable, ICloneable 

            //_3DPoint P = new _3DPoint(10, 10, 10);
            //Console.WriteLine(P.ToString());
            //int exit = 0;

            //int _x = 0, _y = 0, _z = 0, _x2 = 0, _y2 = 0, _z2 = 0, _x3 = 0, _y3 = 0, _z3 = 0;
            //do
            //{
            //    #region First POINT
            //    Console.WriteLine("Insert the X coordinate for the first point");

            //    bool x_input = int.TryParse(Console.ReadLine(), out int x);
            //    if (!x_input)
            //    {
            //        break;
            //    }
            //    _x = x;
            //    Console.Clear();

            //    Console.WriteLine("Insert the Y coordinate for the first point");

            //    bool y_input = int.TryParse(Console.ReadLine(), out int y);
            //    if (!y_input)
            //    {
            //        break;
            //    }
            //    _y = y;

            //    Console.Clear();

            //    Console.WriteLine("Insert the Z coordinate for the first point");

            //    bool z_input = int.TryParse(Console.ReadLine(), out int z);
            //    if (!z_input)
            //    {
            //        break;
            //    }
            //    _z = z;

            //    Console.Clear();
            //    #endregion

            //    #region SECOND POINT
            //    Console.WriteLine("Insert the X coordinate for the second point");

            //    bool x2_input = int.TryParse(Console.ReadLine(), out int x2);
            //    if (!x2_input)
            //    {
            //        break;
            //    }
            //    _x2 = x2;

            //    Console.Clear();

            //    Console.WriteLine("Insert the Y coordinate for the second point");

            //    bool y2_input = int.TryParse(Console.ReadLine(), out int y2);
            //    if (!y2_input)
            //    {
            //        break;
            //    }
            //    _y2 = y2;

            //    Console.Clear();

            //    Console.WriteLine("Insert the Z coordinate for the second point");

            //    bool z2_input = int.TryParse(Console.ReadLine(), out int z2);
            //    if (!z2_input)
            //    {
            //        break;
            //    }
            //    _z2 = z2;

            //    Console.Clear();
            //    #endregion

            //    #region Third Point
            //    Console.WriteLine("Insert the X coordinate for the third point");

            //    bool x3_input = int.TryParse(Console.ReadLine(), out int x3);
            //    if (!x3_input)
            //    {
            //        break;
            //    }
            //    _x3 = x3;

            //    Console.Clear();

            //    Console.WriteLine("Insert the Y coordinate for the third point");

            //    bool y3_input = int.TryParse(Console.ReadLine(), out int y3);
            //    if (!y_input)
            //    {
            //        break;
            //    }
            //    _y3 = y3;

            //    Console.Clear();

            //    Console.WriteLine("Insert the Z coordinate for the third point");

            //    bool z3_input = int.TryParse(Console.ReadLine(), out int z3);
            //    if (!z_input)
            //    {
            //        break;
            //    }
            //    _z3 = z3;

            //    Console.Clear();
            //    #endregion

                

            //    exit = 1;
            //} while (exit != 1);


            //_3DPoint P1 = new _3DPoint(_x, _y, _z);


            //_3DPoint P2 = new _3DPoint(_x2,_y2, _z2);
            //_3DPoint P3 = new _3DPoint(_x3,_y3, _z3);


            //if (P1.CompareTo(P2) == 5)
            //{
            //    Console.WriteLine("This is an example of how Icomparable Works");
            //}


            //_3DPoint[] points = { P1, P2, P3 };
            //_3DPoint temp = new _3DPoint();

            //for (int i = 0; i < points.Length; i++) 
            //{
            //    for (int j = 1; j < points.Length; j++) 
            //    {
            //        if (points[i].CompareTo(points[j]) == 1)
            //        {
            //            temp = points[i];
            //            points[i] = points[j];  
            //            points[j] = temp;
            //        }
            //    }

            //}

            //Console.WriteLine("Sorted Array");

            //for (int i = 0; i < points.Length; i++) 
            //{
            //    Console.WriteLine(points[i].ToString());
            //}

            // CLONE INTERFACE

            //_3DPoint P1Clone = (_3DPoint) P1.Clone();

            //Console.WriteLine(P1.ToString() + P1.GetHashCode());

            //Console.WriteLine(P1Clone.ToString() + P1Clone.GetHashCode());










            #endregion




        }
    }
}