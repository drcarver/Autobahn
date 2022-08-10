using System;

namespace Autobahn.Entities
{
    public partial class AutobahnTable
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public Guid? AutobahnDomainId { get; set; }
        public Guid? AutobahnElementId { get; set; }
        public string GlobalId { get; set; }
        public string ModelName { get; set; }
        public string ColumnName { get; set; }
        public string Description { get; set; }
        public string Version { get; set; }
    }
}