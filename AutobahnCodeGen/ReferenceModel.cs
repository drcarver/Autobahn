using System;
using System.ComponentModel.DataAnnotations;

namespace AutobahnCodeGen
{
    public partial class ReferenceModel
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        [MaxLength(150)]
        public string Description { get; set; }

        [MaxLength(60)]
        public string Code { get; set; }

        [MaxLength(4000)]
        public string Definition { get; set; }
        
        public Guid? RefJurisdictionId { get; set; }
        
        public decimal? SortOrder { get; set; }
    }
}
