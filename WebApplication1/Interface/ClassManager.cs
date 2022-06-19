using WebApplication1.Model;
using WebApplication1.Request;

namespace WebApplication1.Interface
{
    public interface IClass
    {
        List<Class> GetAllClass();
        int AddClass(ClassRequest request);
        int DetailClass(int id);
        int DeleteUser(int id);
        int UpdateUser(int id);


    }
    public class ClassManager : IClass
    {
        private readonly DBContext _context;
        public ClassManager(DBContext context)
        {
            _context = context;
        }

        public int AddClass(ClassRequest request)
        {
            if (request == null)
            {
                return 0;
            }
            else
            {
                var cls = new Class
                {
                    NameClass = request.Name,
                    Amount = request.Amount,
                    Status = request.status
                };
                _context.Class.Add(cls);
                _context.SaveChanges();
                return 1;
            }
        }

        public int DeleteUser(int id)
        {
            var cls = _context.Class.FirstOrDefault(u => u.ClassId == id);
            if (cls != null)
            {
                return 0;
            }
            else
            {
                _context.Class.Remove(cls);
                _context.SaveChanges();
                return 1;
            }
        }

        public int DetailClass(int id)
        {
           var cls = _context.Class.Any(m=>m.ClassId==id);
            if (cls == null)
                return 0;
            return 1;
    }

        

        public List<Class> GetAllClass()
        {
            return _context.Class.ToList();
        }     

           

        public int UpdateUser(int id)
        {
            var user = _context.Class.FirstOrDefault(u => u.ClassId == id);
            if (user != null)
            {
                return 0;
            }
            else
            {   
                ClassRequest rq = new ClassRequest();
                var cls = new Class
                {
                    NameClass = rq.Name,
                    Amount = rq.Amount,
                    Status = rq.status
                };
                _context.Class.Update(cls);
                _context.SaveChanges();
                return 1;
            }
        }       

    }
}
