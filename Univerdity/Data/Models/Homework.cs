using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Univerdity.Data.Models
{
    public enum ContentType
    {
        application = 1,
        pdf = 2,
        zip = 3
    }
    
    public class Homework
    {
        [Key]
        public int HomeworsId { get; set; }

        [Required, Column(TypeName = "varchar(max)")]
        public string Content { get; set; }

        [Required]
        public ContentType ContentType { get; set; }

        public DateTime SubmissionTime { get; set; }

        [ForeignKey ("Student")]
        public int StudentId { get; set; }
        public virtual Student Student { get; set; }

        [ForeignKey("Cource")]
        public int CourceId { get; set; }
        public virtual Cource Cource { get; set; }
    }
}
