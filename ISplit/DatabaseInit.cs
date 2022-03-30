using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using User.Data.iFace;
using User.Data.UserData;

namespace ISplit
{
    public class DatabaseInit : idatabaseInit
    {
        private readonly ApplicationDbContext _dbContext;
        public DatabaseInit(ApplicationDbContext dbContext)
        {

            _dbContext = dbContext;
        }
        public async Task SeedSampleData()
        {
            await _dbContext.Database.EnsureCreatedAsync().ConfigureAwait(false);
            if (!_dbContext.sUserdata.Any())
            {
                var testUser1 = new sUserdata
                {
                   FName = "Test 1",
                   LName = "Test 1", 
                   email = "abc@xz.ab" ,
                   phone = "040000000"
                };

                var testUser2 = new sUserdata
                {
                    FName = "Test 2",
                    LName = "Test 2",
                    email = "abc@xz.ab",
                    phone = "040000000"
                };

                _dbContext.sUserdata.Add(testUser1);
                _dbContext.sUserdata.Add(testUser2);

                await _dbContext.SaveChangesAsync();
            }



        }
       
}  
}
