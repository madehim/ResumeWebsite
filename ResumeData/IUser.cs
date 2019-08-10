using ResumeData.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ResumeData
{
    interface IUser
    {
        User Get(int userId);
        IEnumerable<User> GetAll();

        void ChangePass(int userId);
        void ChangeEmail(int userId);
        void ChangeRole(byte roleN);

        void Add(User newUser);
    }
}
