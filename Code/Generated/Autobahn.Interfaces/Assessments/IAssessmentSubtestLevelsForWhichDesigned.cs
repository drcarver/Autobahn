//***************************************************************************
//* DomainName: Assessments Interfaces (used by both models and View Models
//* FileName:   IAssessmentSubtestLevelsForWhichDesigned.cs
//***************************************************************************

using Autobahn.Interfaces.Common;

namespace Autobahn.Interfaces.Assessments
{
     /// <summary>
     /// The IAssessmentSubtestLevelsForWhichDesigned Interface
     /// </summary>
    public partial interface IAssessmentSubtestLevelsForWhichDesigned : IAutobahnBase
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="IAssessmentSubTest"/> model
        /// </summary>
        Guid AssessmentSubTestId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefGrade"/> model
        /// </summary>
        Guid RefGradeId { get; set; }

    }
}
