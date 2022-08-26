//***************************************************************************
//* DomainName: Competencies Interfaces (used by both models and View Models
//* FileName:   ICompetencyDefinitionCompetencySet.cs
//***************************************************************************

using Autobahn.Interfaces.Common;

namespace Autobahn.Interfaces.Competencies
{
     /// <summary>
     /// The ICompetencyDefinitionCompetencySet Interface
     /// </summary>
    public partial interface ICompetencyDefinitionCompetencySet : IAutobahnBase
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="ICompetencyDefinition"/> model
        /// </summary>
        Guid CompetencyDefinitionId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="ICompetencySet"/> model
        /// </summary>
        Guid CompetencySetId { get; set; }

    }
}
