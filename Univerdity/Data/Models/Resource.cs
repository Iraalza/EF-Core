using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Univerdity.Data.Models
{
    public enum ResourceType
    {
        video = 1,
        presentation = 2,
        document = 3,
        other = 4
    }
    public class Resource
    {
        [Key]
        public int ResourceId { get; set; }

        [Required, MaxLength(64)]
        public string Name { get; set; }

        [Required, Column(TypeName = "varchar(max)")]
        public string Url { get; set; }

        [Required]
        public ResourceType ContentType { get; set; }

        [ForeignKey("Course")]
        public int CourceId { get; set; }
        public virtual Cource Cource { get; set; }
    }
}
