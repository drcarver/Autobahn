//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   IAssessmentSubtest_CompetencyDefinition.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Assessment.Interfaces
{
     /// <summary>
     /// The IAssessmentSubtest_CompetencyDefinition
     /// </summary>
    public partial interface IAssessmentSubtest_CompetencyDefinition : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="AssessmentSubtest"/> model
        /// </summary>
        Guid AssessmentSubtestId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="CompetencyDefinition"/> model
        /// </summary>
        Guid CompetencyDefinitionId { get; set; }

    }
}
