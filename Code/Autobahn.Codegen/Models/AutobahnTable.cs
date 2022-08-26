using CsvHelper.Configuration.Attributes;

namespace Autobahn.Codegen.Models
{
    internal class AutobahnTable
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string ModuleName { get; set; }
        public string GlobalId { get; set; }
        public string TableName { get; set; }
        public string ColumnName { get; set; }
        public string Description { get; set; }
        public string Version { get; set; }
        public string ColumnType { get; set; }
    }
}
