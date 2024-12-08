using DotnetBoilerplate.Models;
using System.Collections.Generic;
using System.Linq;

namespace DotnetBoilerplate.Services
{
    public class UserService
    {
        private readonly List<User> _users = new List<User>();

        public IEnumerable<User> GetUsers() => _users;

        public User GetUser(int id) => _users.FirstOrDefault(u => u.Id == id);

        public void AddUser(User user) => _users.Add(user);

        public void UpdateUser(User user)
        {
            var existingUser = GetUser(user.Id);
            if (existingUser != null)
            {
                existingUser.Name = user.Name;
                existingUser.Email = user.Email;
                existingUser.Password = user.Password;
            }
        }

        public void DeleteUser(int id) => _users.RemoveAll(u => u.Id == id);
    }
}