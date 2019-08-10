using System;
using System.Collections.Generic;
using System.Text;
using ResumeData;
using ResumeData.Models;

namespace ResumeServices
{
    class UserServices : IUser
    {
        private ResumeContext _context;

        public UserServices(ResumeContext context)
        {
            _context = context;
        }

        public void Add(User newUser)
        {
            throw new NotImplementedException();
        }

        public void ChangeEmail(int userId)
        {
            throw new NotImplementedException();
        }

        public void ChangePass(int userId)
        {
            throw new NotImplementedException();
        }

        public void ChangeRole(byte roleN)
        {
            throw new NotImplementedException();
        }

        public User Get(int userId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
