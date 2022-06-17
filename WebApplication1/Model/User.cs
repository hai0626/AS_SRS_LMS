﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Model
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string UserId { get; set; }       
        public string Password { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Address { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string? PhoneNumber { get; set; }
        public string Email { get; set; }
        public bool? Gender { get; set; }
        public string? Images { get; set; }
        //public string? VerificationToken { get; set; }
        //public DateTime? VerifiedAt { get; set; }
        public int RoleId { get; set; }
        public Role Role { get; set; }
        //public List<Exam> Exams { get; set; }
    }
}
