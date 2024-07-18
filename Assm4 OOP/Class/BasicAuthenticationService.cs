using Assm4_OOP.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assm4_OOP.Class
{
    internal class BasicAuthenticationService : IAuthenticationService

    {
        private Dictionary<string, string> _users;
        private Dictionary<string, List<string>> _userRoles;

        public BasicAuthenticationService()
        {
            _users = new Dictionary<string, string>
        {
            { "user1", "password1" },
            { "user2", "password2" }
        };

            _userRoles = new Dictionary<string, List<string>>
        {
            { "user1", new List<string> { "admin", "user" } },
            { "user2", new List<string> { "user" } }
        };
        }

        public bool AuthenticateUser(string username, string password)
        {
            return _users.TryGetValue(username, out string storedPassword) && storedPassword == password;
        }

        public bool AuthorizeUser(string username, string role)
        {
            return _userRoles.TryGetValue(username, out List<string> roles) && roles.Contains(role);
        }
    }
}
