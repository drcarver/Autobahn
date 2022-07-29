using System.ComponentModel.DataAnnotations;
using Autobahn.Core.Interface;

namespace Autobahn.Core
{
    public class ReferenceModelBase : IReferenceModelBase
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [StringLength(150)]
        public string Description { get; set; }

        [StringLength(50)]
        public string Code { get; set; }

        [StringLength(4000)]
        public string Definition { get; set; }

        public Guid? RefJurisdictionId { get; set; }

        public decimal? SortOrder { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }
    }
}
