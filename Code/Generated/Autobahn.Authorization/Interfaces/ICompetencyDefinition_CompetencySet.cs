//***************************************************************************
//* DomainName: Authentication and Authorization Interfaces (used by both models and View Models
//* FileName:   ICompetencyDefinition_CompetencySet.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Authorization.Interfaces
{
     /// <summary>
     /// The ICompetencyDefinition_CompetencySet Interface
     /// </summary>
    public partial interface ICompetencyDefinition_CompetencySet : IAutobahnBase
    {
        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        Guid CompetencyDefinitionId { get; set; }

        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        Guid CompetencySetId { get; set; }

    }
}
