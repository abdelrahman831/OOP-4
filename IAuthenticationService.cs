using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_4
{
    interface IAuthenticationService
    {
        public bool AuthenticateUser(User user);
        public bool AuthorizeUser(User user, User.Role role);
    }
}
