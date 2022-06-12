using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace WebApplication1.Model
{
    public class TestSchedule
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TestScheduleId { get; set; }
        public DateTime DayExam { get; set; }
        public DateTime Time { get; set; }
        public List<Exam> Exam { get; set; }
    }
}
