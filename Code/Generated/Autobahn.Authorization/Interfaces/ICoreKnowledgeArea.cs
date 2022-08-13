//***************************************************************************
//* DomainName: Authentication and Authorization Interfaces (used by both models and View Models
//* FileName:   ICoreKnowledgeArea.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Authorization.Interfaces
{
     /// <summary>
     /// The ICoreKnowledgeArea Interface
     /// </summary>
    public partial interface ICoreKnowledgeArea : IAutobahnBase
    {
        /// <summary>
        /// A description of the core knowledge areas addressed by Early Learning professional development.
        /// </summary>
        Guid ProfessionalDevelopmentActivityId { get; set; }

        /// <summary>
        /// A description of the core knowledge areas addressed by Early Learning professional development.
        /// </summary>
        Guid RefCoreKnowledgeAreaId { get; set; }

    }
}
