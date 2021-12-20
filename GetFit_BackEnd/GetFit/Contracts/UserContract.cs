using DataAccessLayer;
using DataAccessLayer.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GetFit.Contracts
{
    public interface UserContract
    {
        //IEnumerable<User> GetUsers();
        User GetUser(int Id);
        void CreateUser(User User);
        //void UpdateUser(User User, UpdateUser UserUpdate);
        //void DeleteUser(User User);
        bool SaveChanges();
        string LoginUser(Login_user is_user);
    }
}
