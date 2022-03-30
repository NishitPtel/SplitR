using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using User.Data.getUser;
using User.Data.iFace;
using User.Data.UserData;

namespace ISplit.Repo
{
    public class sUser : genops<sUserdata>, isUser
    {
        public sUser(ApplicationDbContext dbContext) : base(dbContext)
        { 



        }
    }
}
