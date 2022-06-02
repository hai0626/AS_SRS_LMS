using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Model
{
    public class Class
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string IdClass { get; set; }
        public string NameClass { get; set; }
        public int Amount { get; set; }
        public bool Status { get; set; }
    }
}
