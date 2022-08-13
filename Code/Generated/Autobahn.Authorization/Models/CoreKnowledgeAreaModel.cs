//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   CoreKnowledgeAreaModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Authorization.Models
{
     /// <summary>
     /// The CoreKnowledgeArea Model
     /// </summary>
    public partial class CoreKnowledgeAreaModel : AutobahnBase, Interfaces.ICoreKnowledgeArea
    {
        /// <summary>
        /// A description of the core knowledge areas addressed by Early Learning professional development.
        /// </summary>
        public Guid ProfessionalDevelopmentActivityId { get; set; }

        /// <summary>
        /// A description of the core knowledge areas addressed by Early Learning professional development.
        /// </summary>
        public Guid RefCoreKnowledgeAreaId { get; set; }

    }
}
