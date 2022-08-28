//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentPersonalNeedLanguageLearnerModel.cs
//***************************************************************************

using Autobahn.Education.Interfaces.Assessments;

namespace Autobahn.Education.Assessments.Models
{
     /// <summary>
     /// The AssessmentPersonalNeedLanguageLearner Model
     /// </summary>
    public partial class AssessmentPersonalNeedLanguageLearnerModel : IAssessmentPersonalNeedLanguageLearner
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

        #region IAssessmentPersonalNeedLanguageLearner
        /// <summary>
        /// Assessment Personal Needs Profile Activate by Default
        /// <para>
        /// Determines if the alternative accessible content is rendered as the default content for the learner.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20008">Assessment Personal Needs Profile Activate by Default</a>
        /// </para>
        /// </summary>
        public Boolean? ActivateByDefault { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IAssessmentNeedsProfileContent"/> model
        /// </summary>
        public Guid AssessmentNeedsProfileContentId { get; set; }

        /// <summary>
        /// Assessment Personal Needs Profile Assigned Support
        /// <para>
        /// Defines whether or not the individual needs the kind of support defined by the entity.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20007">Assessment Personal Needs Profile Assigned Support</a>
        /// </para>
        /// </summary>
        public Boolean? AssignedSupport { get; set; }

        /// <summary>
        /// Assessment Need Language Type
        /// <para>
        /// Defines as part of an Assessment Personal Needs Profile a preference for the language of the user interface.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20025">Assessment Need Language Type</a>
        /// </para>
        /// </summary>
        public Guid RefAssessmentNeedsProfileContentLanguageLearnerTypeId { get; set; }

        #endregion
    }
}
