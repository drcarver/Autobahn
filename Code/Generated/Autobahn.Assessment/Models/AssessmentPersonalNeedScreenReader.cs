//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   AssessmentPersonalNeedScreenReader.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Assessment.Models
{
     /// <summary>
     /// The AssessmentPersonalNeedScreenReader
     /// </summary>
    public partial class AssessmentPersonalNeedScreenReader : AutobahnBase, Interfaces.IAssessmentPersonalNeedScreenReader
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
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
