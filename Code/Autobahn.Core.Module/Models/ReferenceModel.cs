using Autobahn.Core.Interface;

namespace Autobahn.Core.Models
{
    public partial class ReferenceModel : IReferenceModel
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public string Code { get; set; }
        public string Definition { get; set; }
        public Guid? RefJurisdictionId { get; set; }
        public decimal? SortOrder { get; set; }
        public DateTime? RecordStartDateTime { get; set; }
        public DateTime? RecordEndDateTime { get; set; }
    }
}
