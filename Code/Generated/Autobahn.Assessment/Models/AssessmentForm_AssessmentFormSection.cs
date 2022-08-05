//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   AssessmentForm_AssessmentFormSection.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Assessment.Models
{
     /// <summary>
     /// The AssessmentForm_AssessmentFormSection
     /// </summary>
    public partial class AssessmentForm_AssessmentFormSection : AutobahnBase, Interfaces.IAssessmentForm_AssessmentFormSection
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="AssessmentForm"/> model
        /// </summary>
        public Guid AssessmentFormId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="AssessmentFormSection"/> model
        /// </summary>
        public Guid AssessmentFormSectionId { get; set; }

        /// <summary>
        /// Defines the AssessmentForm_AssessmentFormSection.SequenceNumber nullable property
        /// </summary>
        public System.Int32? SequenceNumber { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
