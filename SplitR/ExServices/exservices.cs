using AutoMapper;
using SplitR.ExServices.interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;
using User.Data.getUser;
using User.Data.iFace;
using User.Data.UserData;

namespace SplitR.ExServices
{
    public class exservices : iexservices
    {
        
        public iUofWork _UofWork;
        private readonly IMapper _mapper;
        public exservices(iUofWork UofWork, IMapper mapper)
        {
            _mapper = mapper;
            _UofWork = UofWork;
        }
        public async Task<bool> createUser(addUser addUser)
        {
           if(addUser != null)
            {
                var newUser = _mapper.Map<sUserdata>(addUser);
                await _UofWork.userdata.Add(newUser);
                _UofWork.complete();
                return true;
            }
            return false;
     
        }

        public async Task<bool> DeleteUser(int userId)
        {
            if (userId > 0)
            {
                var suser = await _UofWork.userdata.Get(userId);
                if (suser == null)
                {
                    var deleteuser = _mapper.Map<sUserdata>(suser);
                    _UofWork.userdata.Delete(deleteuser);
                    _UofWork.complete();
                    return true;
                }
            }
            return false;
        }

        public async Task<List<viewUser>> GetAllUsers()
        {
            var sUserList = await _UofWork.userdata.GetAll();
            var userList = _mapper.Map<List<viewUser>>(sUserList);
            return userList;
        }

        public async Task<viewUser> GetUserById(int Id)
        {
            if (Id > 0)
            {
                var suser = await _UofWork.userdata.Get(Id);
                if(suser != null)
                {
                    var userentry = _mapper.Map<viewUser>(suser);
                    return userentry;
                }
            }
            return null;
        }

        public async Task<bool> UpdateUser(int Id, addUser updateUser)
        {
            if (Id > 0)
            {
                var suser = await _UofWork.userdata.Get(Id);
                if (suser == null)
                {
                    var updateuser = _mapper.Map<sUserdata>(suser);
                    _UofWork.userdata.Update(updateuser);
                    _UofWork.complete();
                    return true;
                }
            }
            return false;
        }
    }
}
