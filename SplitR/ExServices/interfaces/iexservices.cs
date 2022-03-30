using System.Collections.Generic;
using System.Threading.Tasks;
using User.Data.getUser;

namespace SplitR.ExServices.interfaces
{
    public interface iexservices
    {
        Task<bool> createUser(addUser addUser);

        Task<List<viewUser>> GetAllUsers();

        Task<viewUser> GetUserById(int Id);
        Task<bool> UpdateUser(int Id, addUser updateUser);

        Task<bool> DeleteUser(int userId);

    }
}
