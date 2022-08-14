//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentPersonalNeedScreenReaderModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Assessments.Models
{
     /// <summary>
     /// The AssessmentPersonalNeedScreenReader Model
     /// </summary>
    public partial class AssessmentPersonalNeedScreenReaderModel : AutobahnBase, Interfaces.IAssessmentPersonalNeedScreenReader
    {
        /// <summary>
        /// Defines as part of an Assessment Personal Needs Profile the rating for the collection of Access for All (AfA) needs and preferences.
        /// </summary>
        public Guid AssessmentPersonalNeedsProfileDisplayId { get; set; }

        /// <summary>
        /// Defines as part of an Assessment Personal Needs Profile the rating for the collection of Access for All (AfA) needs and preferences.
        /// </summary>
        public System.Decimal? Pitch { get; set; }

        /// <summary>
        /// Defines as part of an Assessment Personal Needs Profile the rating for the collection of Access for All (AfA) needs and preferences.
        /// </summary>
        public Guid? RefAssessmentNeedLinkIndicationTypeId { get; set; }

        /// <summary>
        /// Defines as part of an Assessment Personal Needs Profile the rating for the collection of Access for All (AfA) needs and preferences.
        /// </summary>
        public Guid? RefAssessmentNeedUsageTypeId { get; set; }

        /// <summary>
        /// Defines as part of an Assessment Personal Needs Profile the rating for the collection of Access for All (AfA) needs and preferences.
        /// </summary>
        public System.Int32? SpeechRate { get; set; }

        /// <summary>
        /// Defines as part of an Assessment Personal Needs Profile the rating for the collection of Access for All (AfA) needs and preferences.
        /// </summary>
        public System.Decimal? Volume { get; set; }

    }
}
