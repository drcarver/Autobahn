using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities.Common
{
    [Table("AutobahnTable")]
    public partial class AutobahnTable
    {
        public Guid? Id { get; set; } = Guid.NewGuid();
        public string ModuleName { get; set; }
        public string GlobalId { get; set; }
        public string TableName { get; set; }
        public string ColumnName { get; set; }
        public string Version { get; set; }
        public string ColumnType { get; set; }
    }
}
