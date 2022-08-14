using System;
using System.Reflection;

namespace AutobahnCodeGen
{
    public class ModelProperty
    {
        public string Domain { get; set; }
        public string ModelName { get; set; }
        public Type ModelType { get; set; }
        public PropertyInfo PropertyInfo { get; set; }
        public CEDSElement Element { get; set; }
        public string PropertyName { get; set; }
        public string GlobalId { get; set; }
    }
}
