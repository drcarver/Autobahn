using System;

namespace Autobahn.Codegen.Models
{
    public partial class ReferenceModel
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Description { get; set; }
        public string Code { get; set; }
        public string Definition { get; set; }
        public Guid? RefJurisdictionId { get; set; }
        public decimal? SortOrder { get; set; }
    }
}
