//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   IAssessmentLevelsForWhichDesigned.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Assessment.Interfaces
{
     /// <summary>
     /// The IAssessmentLevelsForWhichDesigned
     /// </summary>
    public partial interface IAssessmentLevelsForWhichDesigned : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Assessment"/> model
        /// </summary>
        Guid AssessmentId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="RefGradeLevel"/> model
        /// </summary>
        Guid RefGradeLevelId { get; set; }

    }
}
