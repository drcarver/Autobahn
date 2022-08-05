//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   IAssessmentNeedApipControl.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Assessment.Interfaces
{
     /// <summary>
     /// The IAssessmentNeedApipControl
     /// </summary>
    public partial interface IAssessmentNeedApipControl : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="AssessmentPersonalNeedsProfileControl"/> model
        /// </summary>
        Guid AssessmentPersonalNeedsProfileControlId { get; set; }

        /// <summary>
        /// Defines the AssessmentNeedApipControl.AssessmentNeedTimeMultiplier non nullable property
        /// </summary>
        System.String AssessmentNeedTimeMultiplier { get; set; }

        /// <summary>
        /// Defines the AssessmentNeedApipControl.LineReaderHighlightColor non nullable property
        /// </summary>
        System.String LineReaderHighlightColor { get; set; }

        /// <summary>
        /// Defines the AssessmentNeedApipControl.OverlayColor non nullable property
        /// </summary>
        System.String OverlayColor { get; set; }

        /// <summary>
        /// Defines the AssessmentNeedApipControl.BackgroundColor non nullable property
        /// </summary>
        System.String BackgroundColor { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentNeedIncreasedWhitespacingType"/> model
        /// </summary>
        Guid? RefAssessmentNeedIncreasedWhitespacingTypeId { get; set; }

    }
}
