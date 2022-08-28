//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentItemPossibleResponseModel.cs
//***************************************************************************

using Autobahn.Education.Interfaces.Assessments;

namespace Autobahn.Education.Assessments.Models
{
     /// <summary>
     /// The AssessmentItemPossibleResponse Model
     /// </summary>
    public partial class AssessmentItemPossibleResponseModel : IAssessmentItemPossibleResponse
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

        #region IAssessmentItemPossibleResponse
        /// <summary>
        /// Reference to an optional instance of the <see cref="IAssessmentItem"/> model
        /// </summary>
        public Guid AssessmentItemId { get; set; }

        /// <summary>
        /// Assessment Item Possible Response Correct Indicator
        /// <para>
        /// Indicates that the possible response is the correct response.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20183">Assessment Item Possible Response Correct Indicator</a>
        /// </para>
        /// </summary>
        public Boolean? CorrectIndicator { get; set; }

        /// <summary>
        /// Assessment Item Possible Response Feedback Message
        /// <para>
        /// A message provided to the person being assessed after giving a response that matches the possible response.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19904">Assessment Item Possible Response Feedback Message</a>
        /// </para>
        /// </summary>
        public System.String FeedbackMessage { get; set; }

        /// <summary>
        /// Assessment Item Possible Response Option
        /// <para>
        /// The possible response presented to the participant within a selected-response/multiple-choice assessment item.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20235">Assessment Item Possible Response Option</a>
        /// </para>
        /// </summary>
        public System.String PossibleResponseOption { get; set; }

        /// <summary>
        /// Assessment Item Possible Response Sequence Number
        /// <para>
        /// The position of this response in the list of responses displayed, such as for a multiple choice item type.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19905">Assessment Item Possible Response Sequence Number</a>
        /// </para>
        /// </summary>
        public Int32? SequenceNumber { get; set; }

        /// <summary>
        /// Assessment Item Possible Response Value
        /// <para>
        /// The description of each distracter on an assessment item, explaining why it is there, what misunderstandings it exposes.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19908">Assessment Item Possible Response Value</a>
        /// </para>
        /// </summary>
        public System.String Value { get; set; }

        #endregion
    }
}
