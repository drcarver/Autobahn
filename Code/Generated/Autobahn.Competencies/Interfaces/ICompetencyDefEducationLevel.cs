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
        /// The education level, grade level or primary instructional level at which a Competency Definition is intended.
        /// </summary>
        Guid CompetencyDefinitionId { get; set; }

        /// <summary>
        /// The education level, grade level or primary instructional level at which a Competency Definition is intended.
        /// </summary>
        Guid RefEducationLevelId { get; set; }

    }
}
