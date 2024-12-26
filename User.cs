﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_4
{
    class User
    {
        public enum Role { None,Admin,User }

        public string username { get; set; }
        public string password { get; set; }
        public Role role { get; set; }

        public User(string username,string password, Role role) 
        {
            this.role = role;
            this.username = username;
            this.password = password;
        }


    }
}
