using UserPointsBusinessService;

namespace UserPointsUI
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter username: ");
            string userNumber = Console.ReadLine();

            UserService userService = new UserService();
            bool result = userService.VerifyUser(userNumber);

            if (result)
            {
                Console.WriteLine("Hello Heres your USERPOINTS");
            }
            else
            {
                Console.WriteLine("ERROR");
            }
        }
    }
}