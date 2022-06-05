﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Model
{
    public class DetailSubject
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DetailSubjectId { get; set; }

        public int IdSubject { get; set; }
        public Subject Subjects { get; set; }
        public int IdCourse { get; set; }
        public Courses Course { get; set; }
        public Schedule Schedule { get; set; }
    }
}
