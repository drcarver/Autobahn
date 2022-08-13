//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   AssessmentForm_AssessmentFormSectionModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Authorization.Models
{
     /// <summary>
     /// The AssessmentForm_AssessmentFormSection Model
     /// </summary>
    public partial class AssessmentForm_AssessmentFormSectionModel : AutobahnBase, Interfaces.IAssessmentForm_AssessmentFormSection
    {
        /// <summary>
        /// The position of the assessment section presented in the sequence of sections within an assessment form.
        /// </summary>
        public Guid AssessmentFormId { get; set; }

        /// <summary>
        /// The position of the assessment section presented in the sequence of sections within an assessment form.
        /// </summary>
        public Guid AssessmentFormSectionId { get; set; }

        /// <summary>
        /// The position of the assessment section presented in the sequence of sections within an assessment form.
        /// </summary>
        public System.Int32? SequenceNumber { get; set; }

    }
}
