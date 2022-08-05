//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   AssessmentNeedApipControl.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Assessment.Models
{
     /// <summary>
     /// The AssessmentNeedApipControl
     /// </summary>
    public partial class AssessmentNeedApipControl : AutobahnBase, Interfaces.IAssessmentNeedApipControl
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="AssessmentPersonalNeedsProfileControl"/> model
        /// </summary>
        public Guid AssessmentPersonalNeedsProfileControlId { get; set; }

        /// <summary>
        /// Defines the AssessmentNeedApipControl.AssessmentNeedTimeMultiplier non nullable property
        /// </summary>
        public System.String AssessmentNeedTimeMultiplier { get; set; }

        /// <summary>
        /// Defines the AssessmentNeedApipControl.LineReaderHighlightColor non nullable property
        /// </summary>
        public System.String LineReaderHighlightColor { get; set; }

        /// <summary>
        /// Defines the AssessmentNeedApipControl.OverlayColor non nullable property
        /// </summary>
        public System.String OverlayColor { get; set; }

        /// <summary>
        /// Defines the AssessmentNeedApipControl.BackgroundColor non nullable property
        /// </summary>
        public System.String BackgroundColor { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentNeedIncreasedWhitespacingType"/> model
        /// </summary>
        public Guid? RefAssessmentNeedIncreasedWhitespacingTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
