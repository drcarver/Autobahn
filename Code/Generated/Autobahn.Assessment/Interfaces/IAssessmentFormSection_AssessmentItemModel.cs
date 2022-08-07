//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   IAssessmentFormSection_AssessmentItemModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Assessment.Interfaces
{
     /// <summary>
     /// The IAssessmentFormSection_AssessmentItemModel Interface
     /// </summary>
    public partial interface IAssessmentFormSection_AssessmentItemModel : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="AssessmentFormSectionItem"/> model
        /// </summary>
        Guid AssessmentFormSectionItemId { get; set; }

        /// <summary>
        /// Defines the AssessmentFormSection_AssessmentItem.SequenceNumber non nullable property
        /// </summary>
        System.Int32 SequenceNumber { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="AssessmentFormSection"/> model
        /// </summary>
        Guid AssessmentFormSectionId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="AssessmentItem"/> model
        /// </summary>
        Guid AssessmentItemId { get; set; }

    }
}
