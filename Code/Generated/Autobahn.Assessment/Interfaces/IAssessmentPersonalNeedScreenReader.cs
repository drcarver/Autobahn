//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   IAssessmentPersonalNeedScreenReader.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Assessment.Interfaces
{
     /// <summary>
     /// The IAssessmentPersonalNeedScreenReader
     /// </summary>
    public partial interface IAssessmentPersonalNeedScreenReader : IAutobahnBase
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

    }
}
