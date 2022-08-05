//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   IAssessmentForm_AssessmentFormSection.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Assessment.Interfaces
{
     /// <summary>
     /// The IAssessmentForm_AssessmentFormSection
     /// </summary>
    public partial interface IAssessmentForm_AssessmentFormSection : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="AssessmentForm"/> model
        /// </summary>
        Guid AssessmentFormId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="AssessmentFormSection"/> model
        /// </summary>
        Guid AssessmentFormSectionId { get; set; }

        /// <summary>
        /// Defines the AssessmentForm_AssessmentFormSection.SequenceNumber nullable property
        /// </summary>
        System.Int32? SequenceNumber { get; set; }

    }
}
