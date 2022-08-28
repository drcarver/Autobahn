//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentPersonalNeedsProfileModel.cs
//***************************************************************************

using Autobahn.Education.Interfaces.Assessments;

namespace Autobahn.Education.Assessments.Models
{
     /// <summary>
     /// The AssessmentPersonalNeedsProfile Model
     /// </summary>
    public partial class AssessmentPersonalNeedsProfileModel : IAssessmentPersonalNeedsProfile
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

        #region IAssessmentPersonalNeedsProfile
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
        /// Assessment Need Type
        /// <para>
        /// A type of need identified for a learner as part of an assessment need profile.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20101">Assessment Need Type</a>
        /// </para>
        /// </summary>
        public System.String AssessmentNeedType { get; set; }

        /// <summary>
        /// Assessment Personal Needs Profile Assigned Support
        /// <para>
        /// Defines whether or not the individual needs the kind of support defined by the entity.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20007">Assessment Personal Needs Profile Assigned Support</a>
        /// </para>
        /// </summary>
        public Boolean? AssignedSupportFlag { get; set; }

        #endregion
    }
}
