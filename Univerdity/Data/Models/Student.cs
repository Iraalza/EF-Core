using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Univerdity.Data.Models
{
    public class Student
    {
        public Student()
        {
            this.CourceEnrollments = new HashSet<StudentCource>();
            this.HomeworkSubmissions = new HashSet<Homework>();
        }

        [Key]
        public int StudentId { get; set; }

        [Required, MaxLength(128)]
        public string Name { get; set; }

        [Column(TypeName = "char(10)")]
        public string PhoneNumber { get; set; }

        [Required]
        public DateTime RegistrationOn { get; set; }

        public DateTime? Birthday { get; set; }

        public virtual ICollection<StudentCource> CourceEnrollments { get; set; }
        public virtual ICollection<Homework> HomeworkSubmissions { get; set; }

    }
}
