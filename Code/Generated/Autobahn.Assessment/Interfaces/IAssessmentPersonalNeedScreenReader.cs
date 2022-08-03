//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   IAssessmentPersonalNeedScreenReader.cs
//**********************************************************

namespace Autobahn.Assessment.Interfaces
{
     /// <summary>
     /// The IAssessmentPersonalNeedScreenReader
     /// </summary>
    public partial interface IAssessmentPersonalNeedScreenReader
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="AssessmentPersonalNeedsProfileDisplay"/> model
        /// </summary>
        Guid AssessmentPersonalNeedsProfileDisplayId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentNeedUsageType"/> model
        /// </summary>
        Guid? RefAssessmentNeedUsageTypeId { get; set; }

        /// <summary>
        /// Defines the AssessmentPersonalNeedScreenReader.SpeechRate nullable property
        /// </summary>
        System.Int32? SpeechRate { get; set; }

        /// <summary>
        /// Defines the AssessmentPersonalNeedScreenReader.Pitch nullable property
        /// </summary>
        System.Decimal? Pitch { get; set; }

        /// <summary>
        /// Defines the AssessmentPersonalNeedScreenReader.Volume nullable property
        /// </summary>
        System.Decimal? Volume { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentNeedLinkIndicationType"/> model
        /// </summary>
        Guid? RefAssessmentNeedLinkIndicationTypeId { get; set; }

        /// <summary>
        /// Defines the AssessmentPersonalNeedScreenReader.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the AssessmentPersonalNeedScreenReader.RecordEndDateTime nullable property
        /// </summary>
        System.DateTime? RecordEndDateTime { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatus"/> model
        /// </summary>
        Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        Guid? DataCollectionId { get; set; }

    }
}
