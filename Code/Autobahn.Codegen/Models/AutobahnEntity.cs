namespace Autobahn.Codegen.Models
{
    internal class AutobahnEntity
    {
        internal AutobahnEntity()
        {
            Attributes = new();
        }

        internal AutobahnEntity(Type type)
        {
            Attributes = new(type);
            Name = type.Name;
            Label = Name;
            SubClass = new List<string>();
            foreach (var prop in type.GetProperties())
            {
                AutobahnProperties.Add(new(prop));
            }
        }
        internal EntityAttributes Attributes { get; set; }
        internal string Name { get; set; }
        internal Guid Id { get; set; } = Guid.NewGuid();
        internal string Label { get; set; }
        internal AutobahnElement? AutobahnElement { get; set; }
        internal List<string> SubClass { get; set; } = new List<string>();
        internal List<AutobahnProperty> AutobahnProperties { get; set; } = new List<AutobahnProperty>();
    }
}
