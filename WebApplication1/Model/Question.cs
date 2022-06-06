using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace WebApplication1.Model
{
    public class Question
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string IdQuestion { get; set; }
        public string Content { get; set; }
        public string Form { get; set; }
        public int IdSubject { get; set; }
        public Subject subject { get; set; }
    }
}
