using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Model
{
    public class RegisterClass
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string IdClass { get; set; }
        public string NameClass { get; set; }
        public string Link { get; set; }
        public int Amount { get; set; }
        public bool Status { get; set; }
        public int IdSubject { get; set; }
        public Subject subject { get; set; }
    }
}
