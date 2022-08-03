//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   AssessmentPersonalNeedScreenReader.cs
//**********************************************************

using Autobahn.Assessment.Interfaces;

namespace Autobahn.Assessment.Models
{
     /// <summary>
     /// The AssessmentPersonalNeedScreenReader
     /// </summary>
    public partial class AssessmentPersonalNeedScreenReader : IAssessmentPersonalNeedScreenReader
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="AssessmentPersonalNeedsProfileDisplay"/> model
        /// </summary>
        public Guid AssessmentPersonalNeedsProfileDisplayId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentNeedUsageType"/> model
        /// </summary>
        public Guid? RefAssessmentNeedUsageTypeId { get; set; }

        /// <summary>
        /// Defines the AssessmentPersonalNeedScreenReader.SpeechRate nullable property
        /// </summary>
        public System.Int32? SpeechRate { get; set; }

        /// <summary>
        /// Defines the AssessmentPersonalNeedScreenReader.Pitch nullable property
        /// </summary>
        public System.Decimal? Pitch { get; set; }

        /// <summary>
        /// Defines the AssessmentPersonalNeedScreenReader.Volume nullable property
        /// </summary>
        public System.Decimal? Volume { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentNeedLinkIndicationType"/> model
        /// </summary>
        public Guid? RefAssessmentNeedLinkIndicationTypeId { get; set; }

        /// <summary>
        /// Defines the AssessmentPersonalNeedScreenReader.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the AssessmentPersonalNeedScreenReader.RecordEndDateTime nullable property
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
