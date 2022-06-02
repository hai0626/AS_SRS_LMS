using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace WebApplication1.Model
{
    public class Exam
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string IdExam { get; set; }
        public string NameExam { get; set; }
        public string Content { get; set; }
        public DateTime Date { get; set; }
        public int Time { get; set; }
        public bool Status { get; set; }
    }
}
