﻿using System;
using System.Collections.Generic;

namespace Autobahn.Entities
{
    public class AutobahnElement
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string ElementName { get; set; }
        public string AltName { get; set; }
        public string Definition { get; set; }
        public string Format { get; set; }
        public string HasOptionSet { get; set; }
        public string UsageNotes { get; set; }
        public string URL { get; set; }
        public string Version { get; set; }
        public string TermID { get; set; }
        public string ChangedInThisVersionInd { get; set; }
        public string ChangeNotes { get; set; }
        public string TechnicalName { get; set; }
        public List<int> AutobahnTableList { get; set; } = new List<int>();
        public int AutobahnDomainId { get; set; }

        public AutobahnElement Clone()
        {
            var model = new AutobahnElement
            {
                Id = Id,
                //GlobalId = GlobalId,
                ElementName = ElementName,
                AltName = AltName,
                Definition = Definition,
                Format = Format,
                HasOptionSet = HasOptionSet,
                UsageNotes = UsageNotes,
                URL = URL,
                Version = Version,
                TermID = TermID,
                ChangedInThisVersionInd = ChangedInThisVersionInd,
                ChangeNotes = ChangeNotes,
                TechnicalName = TechnicalName,
                AutobahnDomainId = AutobahnDomainId,
                AutobahnTableList = new List<int>()
            };
            model.AutobahnTableList.AddRange(AutobahnTableList);
            return model;
        }
    }
}