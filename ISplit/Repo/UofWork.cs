using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using User.Data.iFace;
using User.Data.UserData;


namespace ISplit.Repo
{
    public class UofWork : iUofWork
    {
        public isUser sUserdata => throw new NotImplementedException();
        public isplitUser splituser => throw new NotImplementedException();
        public ipayment ipayments => throw new NotImplementedException();
        
        private readonly ApplicationDbContext _dbContext;
        public isUser userdata { get; }
        public isplitUser splituserdata { get; }
        public ipayment paymentdata { get; }
        public UofWork(ApplicationDbContext applicationDbContext, isUser sUser, ipayment payment, isplitUser splitUser)
            {
                    _dbContext = applicationDbContext;
                    userdata = sUser; 
                    splituserdata = splitUser;
                    paymentdata = payment;
        }

        public int complete()
        {
            return _dbContext.SaveChanges();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                _dbContext.Dispose();
            }
        }
    }
}
