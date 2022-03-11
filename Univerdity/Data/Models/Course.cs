using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Univerdity.Data.Models
{
    public class Cource
    {
        public Cource()
        {
            this.StudentsEnrollments = new HashSet<StudentCource>();
            this.Resources = new HashSet<Resource>();
            this.HomeworkSubmissions = new HashSet<Homework>();
        }

        [Key]
        public int CourceId { get; set; }

        [Required, MaxLength(128)]
        public string Name { get; set; }
        public string Description { get; set; }

        [Required]
        public DateTime StartDate { get; set; }
        [Required]
        public DateTime EndDate { get; set; }
        [Required]
        public decimal Price { get; set; }

        public virtual ICollection<StudentCource> StudentsEnrollments { get; set; }
        public virtual ICollection<Homework> HomeworkSubmissions { get; set; }
        public virtual ICollection<Resource> Resources { get; set; }

    }
}
