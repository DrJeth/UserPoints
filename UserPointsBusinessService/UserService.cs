using UserPointsDataServices;

namespace UserPointsBusinessService
{
    public class UserService
    {
        public bool VerifyUser(string userNumber)
        {
            UserDataService dataService = new UserDataService();
            var result = dataService.GetStudent(userNumber);

            return result.userName != null ? true : false;
        }
    }
}