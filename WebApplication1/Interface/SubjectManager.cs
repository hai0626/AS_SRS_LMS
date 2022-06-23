using WebApplication1.Model;
using WebApplication1.Request;

namespace WebApplication1.Interface
{
    public interface ISubject
    {
        List<Subject> GetAllSubject();
        int AddSubject(SubjectRequest request);
        int DetailSubject(int id);
        int DeleteSubject(int id);
        int UpdateSubject(int id, SubjectRequest request);


    }
    public class SubjectManager : ISubject
    {
        private readonly DBContext _context;
        public SubjectManager(DBContext context)
        {
            _context = context;
        }
        public int AddSubject(SubjectRequest request)
        {
            var name = _context.Subject.FirstOrDefault(u => u.SubjectName == request.SubjectName);
            if (name != null)
            {
                return 0;
            }
            else
            {
                var sub = new Subject
                {
                    SubjectName = request.SubjectName,
                    Period = request.Period,
                    StartDay = request.StartDay,
                    EndDay = request.EndDay
                };
                _context.Subject.Add(sub);
                _context.SaveChanges();
                return 1;
            }
        }

        public int DeleteSubject(int id)
        {
            var cls = _context.Subject.FirstOrDefault(u => u.SubjectId == id);
            if (cls == null)
            {
                return 0;
            }
            else
            {
                _context.Subject.Remove(cls);
                _context.SaveChanges();
                return 1;
            }
        }

        public int DetailSubject(int id)
        {
            var cls = _context.Subject.Any(m => m.SubjectId == id);
            if (cls == null)
                return 0;
            return 1;
        }

        public List<Subject> GetAllSubject()
        {
            return _context.Subject.ToList();
        }

        public int UpdateSubject(int id, SubjectRequest request)
        {
            var sub = _context.Subject.FirstOrDefault(u => u.SubjectId == id);
            if (sub != null)
            {
                sub.SubjectName = request.SubjectName;
                sub.Period = request.Period;
                sub.StartDay = request.StartDay;
                sub.EndDay = request.EndDay;
                _context.Subject.Update(sub);
                _context.SaveChanges();
                return 1;
            }
            else
            {

                return 0;
            }
        }
    }
}
