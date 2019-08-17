using System.Collections.Generic;
using System.Linq;
using ResumeData;
using ResumeData.Models;

namespace ResumeServices
{
    public class UserServices : IUser
    {
        private ResumeContext _context;

        public UserServices(ResumeContext context)
        {
            _context = context;
        }

        public User GetByLogin(string login)
        {
            return GetAll().FirstOrDefault(x => x.Login == login);
        }

        public void Add(User newUser)
        {
            _context.Add(newUser);
            _context.SaveChanges();
        }

        public User Get(int userId)
        {
            return GetAll().FirstOrDefault(x => x.Id == userId);
        }

        public IEnumerable<User> GetAll()
        {
            return _context.Users;
        }

        public void ChangeEmail(int userId, string newEmail)
        {
            User userForUpdate = Get(userId);
            if (userForUpdate != null)
            {
                userForUpdate.Email = newEmail;
                _context.SaveChanges();
            }
        }

        public void ChangePass(int userId, string newPass)
        {
            User userForUpdate = Get(userId);
            if (userForUpdate != null)
            {
                userForUpdate.Password = newPass;
                _context.SaveChanges();
            }
        }

        public void ChangeRole(int userId, byte newRole)
        {
            User userForUpdate = Get(userId);
            if (userForUpdate != null)
            {
                userForUpdate.Role = newRole;
                _context.SaveChanges();
            }
        }
    }
}
