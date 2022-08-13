//***************************************************************************
//* DomainName: Authentication and Authorization Interfaces (used by both models and View Models
//* FileName:   IAssessmentForm_AssessmentFormSection.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Authorization.Interfaces
{
     /// <summary>
     /// The IAssessmentForm_AssessmentFormSection Interface
     /// </summary>
    public partial interface IAssessmentForm_AssessmentFormSection : IAutobahnBase
    {
        /// <summary>
        /// The position of the assessment section presented in the sequence of sections within an assessment form.
        /// </summary>
        Guid AssessmentFormId { get; set; }

        /// <summary>
        /// The position of the assessment section presented in the sequence of sections within an assessment form.
        /// </summary>
        Guid AssessmentFormSectionId { get; set; }

        /// <summary>
        /// The position of the assessment section presented in the sequence of sections within an assessment form.
        /// </summary>
        System.Int32? SequenceNumber { get; set; }

    }
}
