using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObj;
using DataAccess;

namespace BusinessLogic
{
    public class UserBL
    {
        public CustomBO AddUser(UserBO objuserBO)
        {
            return new UserDAL().Adduser(objuserBO);
        }
    }
}
