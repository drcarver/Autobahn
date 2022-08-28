//**********************************************************
//* DomainName: Assessments
//* FileName:   LearnerActionModel.cs
//***************************************************************************

using Autobahn.Education.Interfaces.Assessments;

namespace Autobahn.Education.Assessments.Models
{
     /// <summary>
     /// The LearnerAction Model
     /// </summary>
    public partial class LearnerActionModel : ILearnerAction
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

        #region ILearnerAction
        /// <summary>
        /// Reference to an optional instance of the <see cref="IAssessmentItemResponse"/> model
        /// </summary>
        public Guid? AssessmentItemResponseId { get; set; }

        /// <summary>
        /// Learner Action Actor Identifier
        /// <para>
        ///  A unique identifier for the person performing the learner action.  The identifier should be encrypted when integrating learning experience data across systems to secure the privacy of the learner.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20533">Learner Action Actor Identifier</a>
        /// </para>
        /// </summary>
        public System.String LearnerActionActorIdentifier { get; set; }

        /// <summary>
        /// Learner Action Date Time
        /// <para>
        /// The date and time at which the action was taken.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19938">Learner Action Date Time</a>
        /// </para>
        /// </summary>
        public DateTime? LearnerActionDateTime { get; set; }

        /// <summary>
        /// Learner Action Object Description
        /// <para>
        /// A description of the object upon which the person has performed the Learner Action.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20534">Learner Action Object Description</a>
        /// </para>
        /// </summary>
        public System.String LearnerActionObjectDescription { get; set; }

        /// <summary>
        /// Learner Action Object Identifier
        /// <para>
        /// A globally unique identifier for the object upon which the learning has performed the Learner Action which may be a URL with information about a learning resource or to launch the resource.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20535">Learner Action Object Identifier</a>
        /// </para>
        /// </summary>
        public System.String LearnerActionObjectIdentifier { get; set; }

        /// <summary>
        /// Learner Action Object Type
        /// <para>
        /// The type of object upon which a person has performed the Learner Action.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20536">Learner Action Object Type</a>
        /// </para>
        /// </summary>
        public System.String LearnerActionObjectType { get; set; }

        /// <summary>
        /// Learner Action Type
        /// <para>
        /// The type of action taken by the learner.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19935">Learner Action Type</a>
        /// </para>
        /// </summary>
        public Guid? RefLearnerActionTypeId { get; set; }

        /// <summary>
        /// Learner Action Value
        /// <para>
        /// The value representing input by the learner using an online system, such as a value entered in response to an assessment question, or the URL of a learning resource link clicked.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19936">Learner Action Value</a>
        /// </para>
        /// </summary>
        public System.String Value { get; set; }

        #endregion
    }
}
