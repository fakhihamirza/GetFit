using DataAccessLayer;
using GetFitApp.Models;
using DataAccessLayer.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GetFit.Contracts
{
    public interface UserHistoryContract
    {
        IEnumerable<UserHistory> GetHistory(int User_Id);
        void Add(UserHistory food);
        bool SaveChanges();
    }
}
