//***************************************************************************
//* DomainName: Assessments Interfaces (used by both models and View Models
//* FileName:   IAssessmentFormSection_AssessmentItem.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Assessments.Interfaces
{
     /// <summary>
     /// The IAssessmentFormSection_AssessmentItem Interface
     /// </summary>
    public partial interface IAssessmentFormSection_AssessmentItem : IAutobahnBase
    {
        /// <summary>
        /// The position of the assessment section presented in the sequence of sections within an assessment form.
        /// </summary>
        Guid AssessmentFormSectionId { get; set; }

        /// <summary>
        /// The position of the assessment section presented in the sequence of sections within an assessment form.
        /// </summary>
        Guid AssessmentFormSectionItemId { get; set; }

        /// <summary>
        /// The position of the assessment section presented in the sequence of sections within an assessment form.
        /// </summary>
        Guid AssessmentItemId { get; set; }

        /// <summary>
        /// The position of the assessment section presented in the sequence of sections within an assessment form.
        /// </summary>
        System.Int32 SequenceNumber { get; set; }

    }
}
