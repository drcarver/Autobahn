using System;
using System.ComponentModel.DataAnnotations;

namespace AutobahnCodeGen
{
    public class CSVReferenceModel
    {
        public Guid id { get; set; } = Guid.NewGuid();

        [MaxLength(150)]
        public string Description { get; set; }

        [MaxLength(60)]
        public string Code { get; set; }
        
        [MaxLength(4000)]
        public string Definition { get; set; }

        public decimal SortOrder { get; set; }
    }
}
