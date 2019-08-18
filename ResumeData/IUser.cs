using ResumeData.Models;
using System.Collections.Generic;

namespace ResumeData
{
    public interface IUser
    {
        User GetByLogin(string login);
        User Get(int userId);
        IEnumerable<User> GetAll();

        void ChangePass(int userId, string newPass);
        void ChangeEmail(int userId, string newEmail);
        void ChangeRole(int userId, byte newRole);

        void Add(User newUser);
        void Registration(string login, string email, string pass);
        bool Login(User user, string pass);
    }
}
