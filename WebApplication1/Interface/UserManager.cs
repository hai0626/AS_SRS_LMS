using WebApplication1.Model;

namespace WebApplication1.Interface
{
    public interface IUser
    {
        List<User> GetAllUser();
        void Register(UserRequest user);
   
        void Verify(string token);
        void ForgotPassword(string email);
     
    }
    public class UserManager : IUser
    {
        private readonly DBContext  _context;
        public UserManager(DBContext context)
        {
            _context = context;
        }
        public void ForgotPassword(string email)
        {
            throw new NotImplementedException();
        }

        public List<User> GetAllUser()
        {
            return _context.Users.ToList(); ;
        }

      

        public void Register(UserRequest request)
        {
            var user = new User
            {                
                Email = request.Email,
                Password = request.Password,
                RoleId = request.RoleId,
            };
            _context.Users.Add(user);
            _context.SaveChanges();
        }

      

        public void Verify(string token)
        {
            throw new NotImplementedException();
        }
    }
}
