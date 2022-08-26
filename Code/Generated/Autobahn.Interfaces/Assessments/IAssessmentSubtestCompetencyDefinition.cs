//***************************************************************************
//* DomainName: Assessments Interfaces (used by both models and View Models
//* FileName:   IAssessmentSubtestCompetencyDefinition.cs
//***************************************************************************

using Autobahn.Interfaces.Common;

namespace Autobahn.Interfaces.Assessments
{
     /// <summary>
     /// The IAssessmentSubtestCompetencyDefinition Interface
     /// </summary>
    public partial interface IAssessmentSubtestCompetencyDefinition : IAutobahnBase
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="IAssessmentSubtest"/> model
        /// </summary>
        Guid AssessmentSubtestId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="ICompetencyDefinition"/> model
        /// </summary>
        Guid CompetencyDefinitionId { get; set; }

    }
}
