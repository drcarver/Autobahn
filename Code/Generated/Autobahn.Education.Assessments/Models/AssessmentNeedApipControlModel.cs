//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentNeedApipControlModel.cs
//***************************************************************************

using Autobahn.Education.Interfaces.Assessments;

namespace Autobahn.Education.Assessments.Models
{
     /// <summary>
     /// The AssessmentNeedApipControl Model
     /// </summary>
    public partial class AssessmentNeedApipControlModel : IAssessmentNeedApipControl
    {
        // Concrete implementation of IAutobahnBase
        #region IAutobahnBase
        /// <summary>
        /// Gets the model's changed status.
        /// </summary>
        public bool IsChanged { get; private set; } = false;

        /// <summary>
        /// Resets the model's state to unchanged by accepting the modifications.
        /// </summary>
        public void AcceptChanges()
        {
             IsChanged = false;
             IsNew = false;
        }

        /// <summary>
        /// True if the model is new and unsaved.
        /// </summary>
        public bool IsNew { get; set; } =  false;

        /// <summary>
        /// Is it a deleted model?
        /// </summary>
        public bool IsDeleted { get; set; } = false;

        /// <summary>
        /// The Id of the Model
        /// </summary>
        public Guid Id { get; set; } = Guid.NewGuid();
        #endregion

        #region IAssessmentNeedApipControl
        /// <summary>
        /// Assessment Need Time Multiplier
        /// <para>
        /// Defines the multiplier to be applied to the time limit to determine the total testing time allowed when Additional Testing Time is specified as part of an Assessment Personal Needs Profile.  If the value is `unlimited' then there is no time limit for the test.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20055">Assessment Need Time Multiplier</a>
        /// </para>
        /// </summary>
        public System.String AssessmentNeedTimeMultiplier { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IAssessmentPersonalNeedsProfileControl"/> model
        /// </summary>
        public Guid AssessmentPersonalNeedsProfileControlId { get; set; }

        /// <summary>
        /// Assessment Need Background Color
        /// <para>
        /// This is the preferred Background color for screen enhancement defined as part of an Assessment Personal Needs Profile.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20059">Assessment Need Background Color</a>
        /// </para>
        /// </summary>
        public System.String BackgroundColor { get; set; }

        /// <summary>
        /// Assessment Need Line Reader Highlight Color
        /// <para>
        /// The color defined as part of an Assessment Personal Needs Profile to be used to highlight the point of line reader activity i.e. the line being read.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20056">Assessment Need Line Reader Highlight Color</a>
        /// </para>
        /// </summary>
        public System.String LineReaderHighlightColor { get; set; }

        /// <summary>
        /// Assessment Need Overlay Color
        /// <para>
        /// This is the preferred color for the overlay for screen enhancement defined as part of an Assessment Personal Needs Profile.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20057">Assessment Need Overlay Color</a>
        /// </para>
        /// </summary>
        public System.String OverlayColor { get; set; }

        /// <summary>
        /// Assessment Need Increased Whitespacing Type
        /// <para>
        /// Defines the user preferences for white spacing in lines, words and characters as part of an Assessment Personal Needs Profile.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20060">Assessment Need Increased Whitespacing Type</a>
        /// </para>
        /// </summary>
        public Guid? RefAssessmentNeedIncreasedWhitespacingTypeId { get; set; }

        #endregion
    }
}
