//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentPersonalNeedScreenReaderModel.cs
//***************************************************************************

using Autobahn.Education.Interfaces.Assessments;

namespace Autobahn.Education.Assessments.Models
{
     /// <summary>
     /// The AssessmentPersonalNeedScreenReader Model
     /// </summary>
    public partial class AssessmentPersonalNeedScreenReaderModel : IAssessmentPersonalNeedScreenReader
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

        #region IAssessmentPersonalNeedScreenReader
        /// <summary>
        /// Reference to an optional instance of the <see cref="IAssessmentPersonalNeedsProfileDisplay"/> model
        /// </summary>
        public Guid AssessmentPersonalNeedsProfileDisplayId { get; set; }

        /// <summary>
        /// Assessment Need Pitch
        /// <para>
        /// Defines as part of an Assessment Personal Needs Profile the pitch of a speech synthesizer.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20031">Assessment Need Pitch</a>
        /// </para>
        /// </summary>
        public Decimal? Pitch { get; set; }

        /// <summary>
        /// Assessment Need Link Indication Type
        /// <para>
        /// Defines as part of an Assessment Personal Needs Profile the characteristics of presentation for a hyperlink when using a screen reader.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20029">Assessment Need Link Indication Type</a>
        /// </para>
        /// </summary>
        public Guid? RefAssessmentNeedLinkIndicationTypeId { get; set; }

        /// <summary>
        /// Assessment Need Usage Type
        /// <para>
        /// Defines as part of an Assessment Personal Needs Profile the rating for the collection of Access for All (AfA) needs and preferences.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20028">Assessment Need Usage Type</a>
        /// </para>
        /// </summary>
        public Guid? RefAssessmentNeedUsageTypeId { get; set; }

        /// <summary>
        /// Assessment Need Speech Rate
        /// <para>
        /// Defines as part of an Assessment Personal Needs Profile the rate of speech of a speech synthesizer.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20030">Assessment Need Speech Rate</a>
        /// </para>
        /// </summary>
        public Int32? SpeechRate { get; set; }

        /// <summary>
        /// Assessment Need Volume
        /// <para>
        /// Defines as part of an Assessment Personal Needs Profile the volume of a speech synthesizer.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20032">Assessment Need Volume</a>
        /// </para>
        /// </summary>
        public Decimal? Volume { get; set; }

        #endregion
    }
}
