using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
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

        public void Registration(string login, string email, string password)
        {
            byte[] salt = new byte[128 / 8];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(salt);
            }
            string stringSalt = Convert.ToBase64String(salt);

            string hashed = Hashing(salt, password);

            Add(new User
            {
                Email = email,
                Login = login,
                Password = hashed,
                Salt = stringSalt,
                Role = 1
            });
        }

        public bool Login(User user, string pass)
        {
            byte[] salt = Convert.FromBase64String(user.Salt);

            if (user.Password == Hashing(salt, pass))
                return true;
            return false;
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

        private string Hashing(byte[] salt, string password)
        {
            return Convert.ToBase64String(KeyDerivation.Pbkdf2(
                        password: password,
                        salt: salt,
                        prf: KeyDerivationPrf.HMACSHA1,
                        iterationCount: 10000,
                        numBytesRequested: 256 / 8));
        }
    }
}
