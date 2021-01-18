using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Medex.Database
{
    public class Prescription : BaseEntity
    {
        public string Name { get; set; }

        public DateTime CreatedDate { get; set; }

        [ForeignKey("Doctor")]
        public int DoctorId { get; set; }
        public virtual Doctor Doctor { get; set; }

        [NotMapped]
        public virtual IEnumerable<Medicine> Medicines { get; set; }

    }
}
