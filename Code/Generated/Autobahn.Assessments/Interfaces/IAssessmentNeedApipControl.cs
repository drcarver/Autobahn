//***************************************************************************
//* DomainName: Assessments Interfaces (used by both models and View Models
//* FileName:   IAssessmentNeedApipControl.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Assessments.Interfaces
{
     /// <summary>
     /// The IAssessmentNeedApipControl Interface
     /// </summary>
    public partial interface IAssessmentNeedApipControl : IAutobahnBase
    {
        /// <summary>
        /// Defines the multiplier to be applied to the time limit to determine the total testing time allowed when Additional Testing Time is specified as part of an Assessment Personal Needs Profile.  If the value is `unlimited' then there is no time limit for the test.
        /// </summary>
        System.String AssessmentNeedTimeMultiplier { get; set; }

        /// <summary>
        /// Defines the multiplier to be applied to the time limit to determine the total testing time allowed when Additional Testing Time is specified as part of an Assessment Personal Needs Profile.  If the value is `unlimited' then there is no time limit for the test.
        /// </summary>
        Guid AssessmentPersonalNeedsProfileControlId { get; set; }

        /// <summary>
        /// Defines the multiplier to be applied to the time limit to determine the total testing time allowed when Additional Testing Time is specified as part of an Assessment Personal Needs Profile.  If the value is `unlimited' then there is no time limit for the test.
        /// </summary>
        System.String BackgroundColor { get; set; }

        /// <summary>
        /// Defines the multiplier to be applied to the time limit to determine the total testing time allowed when Additional Testing Time is specified as part of an Assessment Personal Needs Profile.  If the value is `unlimited' then there is no time limit for the test.
        /// </summary>
        System.String LineReaderHighlightColor { get; set; }

        /// <summary>
        /// Defines the multiplier to be applied to the time limit to determine the total testing time allowed when Additional Testing Time is specified as part of an Assessment Personal Needs Profile.  If the value is `unlimited' then there is no time limit for the test.
        /// </summary>
        System.String OverlayColor { get; set; }

        /// <summary>
        /// Defines the multiplier to be applied to the time limit to determine the total testing time allowed when Additional Testing Time is specified as part of an Assessment Personal Needs Profile.  If the value is `unlimited' then there is no time limit for the test.
        /// </summary>
        Guid? RefAssessmentNeedIncreasedWhitespacingTypeId { get; set; }

    }
}
