using System.Reflection;

namespace Autobahn.Codegen.Models
{
    internal class AutobahnProperty
    {
        /// <summary>
        /// No equivalent type yet (like in schema.org)
        /// </summary>
        public AutobahnProperty()
        {
            Attributes = new PropertyAttributes(); 
        }

        /// <summary>
        /// Initialize from a PropertyInfo when going through 
        /// a set of Types
        /// </summary>
        /// <param name="property">The property Info</param>
        public AutobahnProperty(PropertyInfo property)
        {
            Attributes = new(property);
            Name = property.Name;
            Property = property;
        }
        internal PropertyAttributes Attributes { get; set; }
        internal string Name { get; set; }
        internal PropertyInfo Property { get; set; }
        internal string PropertyType { get; set; }
        internal AutobahnElement AutobahnElement { get; set; }
        internal bool IsVirtual { get; set; } = false;
    }
}