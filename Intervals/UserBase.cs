using System;
using System.Collections.Generic;
using System.Text;

namespace Metrics
{
    public class UserBase
    {
        public List<User> Users { get; set; } = new List<User>();

        public void addUsers(List<User> a)
        {
            foreach(User user in a)
            {
                Users.Add(user);
            }

        }
      
    }
}
