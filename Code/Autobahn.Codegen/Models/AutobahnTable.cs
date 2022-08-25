namespace Autobahn.Codegen.Models
{
    internal class AutobahnTable
    {
        internal Guid Id { get; set; } = Guid.NewGuid();
        internal string ModuleName { get; set; }
        internal string GlobalId { get; set; }
        internal string TableName { get; set; }
        internal string ColumnName { get; set; }
        internal string Description { get; set; }
        internal string Version { get; set; }
        internal string ColumnType { get; set; }
    }
}
