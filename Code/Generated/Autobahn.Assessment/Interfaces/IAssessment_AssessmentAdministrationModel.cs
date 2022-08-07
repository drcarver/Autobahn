//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   IAssessment_AssessmentAdministrationModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Assessment.Interfaces
{
     /// <summary>
     /// The IAssessment_AssessmentAdministrationModel Interface
     /// </summary>
    public partial interface IAssessment_AssessmentAdministrationModel : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Assessment"/> model
        /// </summary>
        Guid AssessmentId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="AssessmentAdministration"/> model
        /// </summary>
        Guid AssessmentAdministrationId { get; set; }

    }
}
