using DataAccessLayer;
using GetFit.Contracts;
using GetFit.DB_Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GetFit.Providers
{
    public class UserHistoryProvider : UserHistoryContract
    {
        private readonly dbcontext Query;
        public UserHistoryProvider(dbcontext _Query)
        {
            Query = _Query;
        }

        public void Add(UserHistory addresult)
        {
            if (addresult == null)
            {
                throw new ArgumentNullException(nameof(addresult));
            }
            Query.UserHistory.Add(addresult);
        }

        public IEnumerable<UserHistory> GetHistory(int User_Id)
        {
            return Query.UserHistory.ToList().Where(x => x.UserID == User_Id);
        }

        public bool SaveChanges()
        {
            return (Query.SaveChanges() >= 0);
        }
    }
}
