//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   AssessmentForm_AssessmentAsset.cs
//**********************************************************

using Autobahn.Assessment.Interfaces;

namespace Autobahn.Assessment.Models
{
     /// <summary>
     /// The AssessmentForm_AssessmentAsset
     /// </summary>
    public partial class AssessmentForm_AssessmentAsset : IAssessmentForm_AssessmentAsset
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="AssessmentForm"/> model
        /// </summary>
        public Guid AssessmentFormId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="AssessmentAsset"/> model
        /// </summary>
        public Guid AssessmentAssetId { get; set; }

        /// <summary>
        /// Defines the AssessmentForm_AssessmentAsset.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the AssessmentForm_AssessmentAsset.RecordEndDateTime nullable property
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
