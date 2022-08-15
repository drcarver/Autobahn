//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   CoreKnowledgeAreaModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Invalid.Models
{
     /// <summary>
     /// The CoreKnowledgeArea Model
     /// </summary>
    public partial class CoreKnowledgeAreaModel : AutobahnBase, Interfaces.ICoreKnowledgeArea
    {
        /// <summary>
        /// A description of the core knowledge areas addressed by Early Learning professional development.
        /// </summary>
        public Guid RefCoreKnowledgeAreaId { get; set; }

    }
}
