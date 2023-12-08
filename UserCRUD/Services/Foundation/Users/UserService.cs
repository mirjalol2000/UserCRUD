using UserCRUD.Brokers.Storages;
using UserCRUD.Models.Users;

namespace UserCRUD.Services.Foundation.Users
{
    public class UserService : IUserService
    {
        private readonly IStorageBroker strogaBroker;

        public UserService(IStorageBroker strogaBroker)
        {
            this.strogaBroker = strogaBroker;
        }

        public User AddUSer(User user)=>
            this.strogaBroker.InsertUser(user);   
        
    }
}
