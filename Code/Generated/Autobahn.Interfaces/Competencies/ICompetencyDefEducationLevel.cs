//***************************************************************************
//* DomainName: Competencies Interfaces (used by both models and View Models
//* FileName:   ICompetencyDefEducationLevel.cs
//***************************************************************************

using Autobahn.Interfaces.Common;

namespace Autobahn.Interfaces.Competencies
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
        /// Competency Definition Education Level
        /// <para>
        /// The education level, grade level or primary instructional level at which a Competency Definition is intended.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19701">Competency Definition Education Level</a>
        /// </para>
        /// </summary>
        Guid RefEducationLevelId { get; set; }

    }
}
