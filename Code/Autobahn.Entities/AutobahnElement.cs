using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection;

namespace Autobahn.Entities
{
    [Table("AutobahnElement")]
    public partial class AutobahnElement
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string GlobalId { get; set; }
        public string ElementName { get; set; }
        public string AltName { get; set; }
        public string Definition { get; set; }
        public string Format { get; set; }
        public string HasOptionSet { get; set; }
        public string UsageNotes { get; set; }
        public string URL { get; set; }
        public string Version { get; set; }
        public string TermID { get; set; }
        public string ChangeNotes { get; set; }
        public string TechnicalName { get; set; }
        public List<Guid?> AutobahnTableList { get; set; } = new List<Guid?>();
        public List<Guid?> AutobahnDomainList { get; set; } = new List<Guid?>();

        public AutobahnElement Clone()
        {
            var model = new AutobahnElement
            {
                Id = Id,
                GlobalId = GlobalId,
                ElementName = ElementName,
                AltName = AltName,
                Definition = Definition,
                Format = Format,
                HasOptionSet = HasOptionSet,
                UsageNotes = UsageNotes,
                URL = URL,
                Version = Version,
                TermID = TermID,
                ChangeNotes = ChangeNotes,
                TechnicalName = TechnicalName,
                AutobahnDomainList = AutobahnDomainList,
                AutobahnTableList = AutobahnTableList,
            };
            return model;
        }
    }
}