//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   AssessmentFormSection_AssessmentItem.cs
//**********************************************************

using Autobahn.Assessment.Interfaces;

namespace Autobahn.Assessment.Models
{
     /// <summary>
     /// The AssessmentFormSection_AssessmentItem
     /// </summary>
    public partial class AssessmentFormSection_AssessmentItem : IAssessmentFormSection_AssessmentItem
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="AssessmentFormSectionItem"/> model
        /// </summary>
        public Guid AssessmentFormSectionItemId { get; set; }

        /// <summary>
        /// Defines the AssessmentFormSection_AssessmentItem.SequenceNumber non nullable property
        /// </summary>
        public System.Int32 SequenceNumber { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="AssessmentFormSection"/> model
        /// </summary>
        public Guid AssessmentFormSectionId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="AssessmentItem"/> model
        /// </summary>
        public Guid AssessmentItemId { get; set; }

        /// <summary>
        /// Defines the AssessmentFormSection_AssessmentItem.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the AssessmentFormSection_AssessmentItem.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatus"/> model
        /// </summary>
        public Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
