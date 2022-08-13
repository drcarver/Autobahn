//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   AssessmentFormSection_AssessmentItemModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Authorization.Models
{
     /// <summary>
     /// The AssessmentFormSection_AssessmentItem Model
     /// </summary>
    public partial class AssessmentFormSection_AssessmentItemModel : AutobahnBase, Interfaces.IAssessmentFormSection_AssessmentItem
    {
        /// <summary>
        /// The position of the assessment section presented in the sequence of sections within an assessment form.
        /// </summary>
        public Guid AssessmentFormSectionId { get; set; }

        /// <summary>
        /// The position of the assessment section presented in the sequence of sections within an assessment form.
        /// </summary>
        public Guid AssessmentFormSectionItemId { get; set; }

        /// <summary>
        /// The position of the assessment section presented in the sequence of sections within an assessment form.
        /// </summary>
        public Guid AssessmentItemId { get; set; }

        /// <summary>
        /// The position of the assessment section presented in the sequence of sections within an assessment form.
        /// </summary>
        public System.Int32 SequenceNumber { get; set; }

    }
}
