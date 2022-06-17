using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace WebApplication1.Model
{
    public class Exam
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ExamId { get; set; }
        public string NameExam { get; set; }
        public string Content { get; set; }
        public string TypeTest { get; set; }
        public DateTime Date { get; set; }
        public int Time { get; set; }
        public string Description  { get; set; }
        public string ExamCode  { get; set; }
        public bool Status { get; set; }
        public int IdSubject { get; set; }
        public Subject Subject  { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public List<ContentTest> contentTests { get; set; }

    }
}
