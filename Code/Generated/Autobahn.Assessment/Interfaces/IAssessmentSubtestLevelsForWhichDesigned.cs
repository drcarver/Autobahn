//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   IAssessmentSubtestLevelsForWhichDesigned.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Assessment.Interfaces
{
     /// <summary>
     /// The IAssessmentSubtestLevelsForWhichDesigned
     /// </summary>
    public partial interface IAssessmentSubtestLevelsForWhichDesigned : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="AssessmentSubTest"/> model
        /// </summary>
        Guid AssessmentSubTestId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="RefGrade"/> model
        /// </summary>
        Guid RefGradeId { get; set; }

    }
}
