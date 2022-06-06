using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Model
{
    public class Document
    {
       
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdDocument { get; set; }
        public int NameDocument { get; set; }
        public string Link { get; set; }
        public int IdSubject { get; set; }
        public Subject subject { get; set; }
    }
}
