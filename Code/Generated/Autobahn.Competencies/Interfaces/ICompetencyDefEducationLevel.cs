//***************************************************************************
//* DomainName: Competencies Interfaces (used by both models and View Models
//* FileName:   ICompetencyDefEducationLevel.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Competencies.Interfaces
{
     /// <summary>
     /// The ICompetencyDefEducationLevel Interface
     /// </summary>
    public partial interface ICompetencyDefEducationLevel : IAutobahnBase
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="ICompetencyDefinition"/> model
        /// </summary>
        Guid CompetencyDefinitionId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefEducationLevel"/> model
        /// </summary>
        Guid RefEducationLevelId { get; set; }

    }
}
