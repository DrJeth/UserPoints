using UserPointsModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserPointsDataServices
{
    public class UserDataService
    {
        List<User> dummyUsers = new List<User>();

        public UserDataService()
        {
            CreateDummyData();
        }

        private void CreateDummyData()
        {
            Point defaultPoints = new Point
            {
                value = 100,
                category = "new member rewards"
            };

            User user1 = new User
            {
                userName = "Taylor Swift",
                points = defaultPoints
            };

            User user2 = new User
            {
                userName = "Harry Styles",
                points = defaultPoints
            };

            User user3 = new User
            {
                userName = "Ed Sheeran",
                points = defaultPoints
            };

            dummyUsers.Add(user1);
            dummyUsers.Add(user2);
            dummyUsers.Add(user3);
        }

        public User GetStudent(string userName)
        {
            User foundUser = new User();

            foreach (var dummy in dummyUsers)
            {
                if (userName == dummy.userName)
                {
                    foundUser = dummy;
                }
            }

            return foundUser;
        }

    }
}