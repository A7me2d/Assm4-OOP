using Assm4_OOP.Class;
using Assm4_OOP.Interfaces;

namespace Assm4_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part01
            //Q1 ======> (b);
            //Q2 ======> (a , b);
            //Q3 ======> (b);
            //Q4 ======> (b);
            //Q5 ======> (d);
            //Q6 ======> (a);
            //Q7 ======> (b);
            //Q8 ======> (a);
            //Q9 ======> (b);
            //Q10 ======> (c);
            #endregion

            #region Part02 Q1
            //ICircle circle = new Circle(5);
            //IRectangle rectangle = new Rectangle(4, 6);

            //circle.DisplayShapeInfo();
            //Console.WriteLine();
            //rectangle.DisplayShapeInfo();

            #endregion

            #region Part02 Q2
            //IAuthenticationService authService = new BasicAuthenticationService();

            //bool isAuthenticated = authService.AuthenticateUser("user1", "password1");
            //Console.WriteLine($"Authentication result for user1: {isAuthenticated}");

            //isAuthenticated = authService.AuthenticateUser("user1", "wrongpassword");
            //Console.WriteLine($"Authentication result for user1 with wrong password: {isAuthenticated}");

            //bool isAuthorized = authService.AuthorizeUser("user1", "admin");
            //Console.WriteLine($"Authorization result for user1 as admin: {isAuthorized}");

            //isAuthorized = authService.AuthorizeUser("user2", "admin");
            //Console.WriteLine($"Authorization result for user2 as admin: {isAuthorized}");

            #endregion

            #region Part02 Q3
            INotificationService emailService = new EmailNotificationService();
            INotificationService smsService = new SmsNotificationService();
            INotificationService pushService = new PushNotificationService();


            emailService.SendNotification("email@example.com", "This is an email message.");
            smsService.SendNotification("123-456-7890", "This is an SMS message.");
            pushService.SendNotification("user123", "This is a push notification message.");

            #endregion
        }
    }
}
