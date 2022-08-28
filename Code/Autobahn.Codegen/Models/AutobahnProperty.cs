using System.ComponentModel.DataAnnotations;
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
            IsVirtual = property.GetAccessors()[0].IsVirtual;
            if (property.PropertyType.IsGenericType && property.PropertyType.GetGenericTypeDefinition() == typeof(Nullable<>))
            {
                if (property.Name.EndsWith("Id"))
                {
                    // If it is NULLABLE, then get the underlying type. eg if "Nullable<int>" then this will return just "int"
                    PropertyType = $"Guid?";
                }
                else
                {
                    // If it is NULLABLE, then get the underlying type. eg if "Nullable<int>" then this will return just "int"
                    PropertyType = $"{property.PropertyType.GetGenericArguments()[0].Name}?";
                }
            }
            else
            {
                Attributes.RequiredAttribute = new RequiredAttribute();
                if (property.Name.EndsWith("Id"))
                {
                    PropertyType = "Guid";
                }
                else
                {
                    PropertyType = property.PropertyType.ToString();
                }
            } 
            NeedsValidation = Attributes.MaxLengthAttribute != null
                           || Attributes.RequiredAttribute != null
                           || Attributes.StringLengthAttribute != null;
        }
        internal PropertyAttributes Attributes { get; set; }
        internal string Name { get; set; }
        internal PropertyInfo Property { get; set; }
        internal string PropertyType { get; set; }
        internal bool NeedsValidation { get; set; }
        internal AutobahnElement? AutobahnElement { get; set; }
        internal bool IsVirtual { get; set; } = false;
    }
}