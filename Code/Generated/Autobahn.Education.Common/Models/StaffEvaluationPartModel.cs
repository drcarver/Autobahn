//**********************************************************
//* DomainName: Common Models
//* FileName:   StaffEvaluationPartModel.cs
//***************************************************************************

using Autobahn.Education.Interfaces.Common;

namespace Autobahn.Education.Common.Models
{
     /// <summary>
     /// The StaffEvaluationPart Model
     /// </summary>
    public partial class StaffEvaluationPartModel : IStaffEvaluationPart
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

        #region IStaffEvaluationPart
        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Staff Evaluation Part Name
        /// <para>
        /// The name of the component part that is being evaluated and scored.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20965">Staff Evaluation Part Name</a>
        /// </para>
        /// </summary>
        public System.String PartName { get; set; }

        /// <summary>
        /// Staff Evaluation Part Scale
        /// <para>
        /// The quantitative or qualitative range of possible scores/rating for a person's performance on a component part (e.g., 0 - 10; Poor, Fair, Average, Good, Excellent).
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20966">Staff Evaluation Part Scale</a>
        /// </para>
        /// </summary>
        public System.String Scale { get; set; }

        /// <summary>
        /// Staff Evaluation Part Score or Rating
        /// <para>
        /// The actual quantitative or qualitative assessment of a person's performance on a component part that is being evaluated. 
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20967">Staff Evaluation Part Score or Rating</a>
        /// </para>
        /// </summary>
        public System.String ScoreOrRating { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IStaffEvaluation"/> model
        /// </summary>
        public Guid? StaffEvaluationId { get; set; }

        #endregion
    }
}
