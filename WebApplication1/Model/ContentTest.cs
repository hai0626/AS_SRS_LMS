using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace WebApplication1.Model
{
    public class ContentTest
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdContent { get; set; }
        public string Content { get; set; }

        public int Result { get; set; }
        public int IdTest { get; set; }
        public Test test  { get; set; }

    }
}
