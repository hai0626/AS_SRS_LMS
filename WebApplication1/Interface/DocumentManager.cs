using WebApplication1.Model;
using WebApplication1.Request;

namespace WebApplication1.Interface
{
    public interface IDocument
    {
        List<Document> GetAllDocument();
        int AddDocument(DocumentRequest request);
        int DetailDocument(int id);
        int DeleteDocument(int id);
        int UpdateDocument(int id, DocumentRequest request);


    }
    public class DocumentManager : IDocument
    {
        private readonly DBContext _context;
        public DocumentManager(DBContext context)
        {
            _context = context;
        }
        public int AddDocument(DocumentRequest request)
        {
            var name = _context.Document.FirstOrDefault(u => u.NameDocument == request.DocumentName);
            if (name != null)
            {
                return 0;
            }
            else
            {
                var doc = new Document
                {
                    NameDocument = request.DocumentName,
                    Link = request.link,
                    SubjectId = request.SubjectId
                };
                _context.Document.Add(doc);
                _context.SaveChanges();
                return 1;
            }
        }

        public int DeleteDocument(int id)
        {
            var doc = _context.Document.FirstOrDefault(u => u.DocumentId == id);
            if (doc == null)
            {
                return 0;
            }
            else
            {
                _context.Document.Remove(doc);
                _context.SaveChanges();
                return 1;
            }
        }

        public int DetailDocument(int id)
        {
            var doc = _context.Document.Any(m => m.DocumentId == id);
            if (doc == null)
                return 0;
            return 1;
        }

        public List<Document> GetAllDocument()
        {
            return _context.Document.ToList();
        }

        public int UpdateDocument(int id, DocumentRequest request)
        { 
            var doc = _context.Document.FirstOrDefault(u => u.DocumentId == id);
            if (doc != null)
            {
                doc.NameDocument = request.DocumentName;
                doc.Link = request.link;
                doc.SubjectId = request.SubjectId;
                _context.Document.Update(doc);
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
