using WebApplication1.Model;

namespace WebApplication1.Interface
{
    public interface IUser
    {
        List<User> GetAllUser();
        int Register(UserRequest user);
        int Login(string email, string pass);
        int ForgotPassword(string email, string phone, string newpass);
        int DeleteUser(string id);
        int UpdateUser(UserRequest user,string id);


    }
    public class UserManager : IUser
    {
        private readonly DBContext _context;
        public UserManager(DBContext context)
        {
            _context = context;
        }

        public int DeleteUser(string id)
        {
            var user = _context.Users.FirstOrDefault(u => u.UserId == id);
            if (user != null)
            {
                return 0;
            }
            else
            {
                _context.Users.Remove(user);
                _context.SaveChanges();
                return 1;
            }
        }

        public int ForgotPassword(string email, string phone, string newpass)
        {
            var user = _context.Users.FirstOrDefault(u => u.Email == email && u.PhoneNumber == phone);
            if (user == null)
            {
                return 0;
            }
            else
            {
                user.Password = HashPass.Encrypt(newpass);
                _context.Users.Update(user);
                _context.SaveChanges();
                return 1;
            }
        }

        public List<User> GetAllUser()
        {
            return _context.Users.ToList(); ;
        }

        public int Login(string email, string pass)
        {
            var user = _context.Users.FirstOrDefault(u => u.Email == email && u.Password == HashPass.Encrypt(pass));
            if (user == null)
            {
                return 0;
            }
            else
            {
                return 1;
            }

        }

        public int Register(UserRequest request)
        {
            var email = _context.Users.FirstOrDefault(u => u.Email == request.Email);
            if (email != null)
            {
                return 0;
            }
            else
            {
                var user = new User
                {
                    Email = request.Email,
                    PhoneNumber = request.phone,
                    Password = HashPass.Encrypt(request.Password),
                    RoleId = request.RoleId,
                };
                _context.Users.Add(user);
                _context.SaveChanges();
                return 1;
            }
        }

        public int UpdateUser(UserRequest request, string id)
        {
            var user = _context.Users.FirstOrDefault(u => u.UserId == id);
            if (user != null)
            {
                return 0;
            }
            else
            {
                var New = new User
                {
                    Email = request.Email,
                    PhoneNumber = (request.phone).ToString(),
                    Password = HashPass.Encrypt(request.Password),
                    RoleId = request.RoleId,
                };
                _context.Users.Update(user);
                _context.SaveChanges();
                return 1;
            }
        }

        

    }
}
