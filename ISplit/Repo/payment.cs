using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using User.Data.iFace;
using User.Data.UserData;

namespace ISplit.Repo
{
    public class payment : genops<paymentdata>,ipayment
    {
        public payment(ApplicationDbContext dbContext) : base(dbContext)
        {

        }
    }
}
