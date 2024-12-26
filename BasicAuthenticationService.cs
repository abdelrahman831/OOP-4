using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_4
{
    class BasicAuthenticationService : IAuthenticationService
    {

        public User[] users =
            {
                new User("admin","admin",User.Role.Admin),
                new User("root","root",User.Role.Admin),
                new User("user","user",User.Role.User)
            };
        public BasicAuthenticationService() { }

        public bool AuthenticateUser(User user) 
        {
            if (user.username is not null && user.password is not null)
            {
                for (int i = 0; i < users.Length; i++)
                {
                    if (user.username == users[i].username && user.password == users[i].password)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            return false;

        }   
        public bool AuthorizeUser(User user, User.Role role) 
        {
            if (user.username is not null)
            {
                for (int i = 0; i < users.Length; i++)
                {
                    if (user.username == users[i].username && user.role == role)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            return false;
        }

    }
}
