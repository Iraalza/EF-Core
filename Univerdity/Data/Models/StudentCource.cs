using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Univerdity.Data.Models
{
    public class StudentCource
    {
        [ForeignKey("Student")]
        public int StudentId { get; set; }
        public virtual Student Student { get; set; }

        [ForeignKey("Cource")]
        public int CourceId { get; set; }
        public virtual Cource Cource { get; set; }
    }
}
