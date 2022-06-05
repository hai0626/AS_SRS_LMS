using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace WebApplication1.Model
{
    public class Answer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string IdAnswer { get; set; }
        public string Content { get; set; }
        public bool RightWrong { get; set; }

        public int IdExam { get; set; }
        public Exam exam { get; set; }
    }
}
