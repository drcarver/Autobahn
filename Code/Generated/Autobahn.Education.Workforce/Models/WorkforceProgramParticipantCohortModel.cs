//**********************************************************
//* DomainName: Workforce
//* FileName:   WorkforceProgramParticipantCohortModel.cs
//***************************************************************************

using Autobahn.Education.Interfaces.Workforce;

namespace Autobahn.Education.Workforce.Models
{
     /// <summary>
     /// The WorkforceProgramParticipantCohort Model
     /// </summary>
    public partial class WorkforceProgramParticipantCohortModel : IWorkforceProgramParticipantCohort
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

        #region IWorkforceProgramParticipantCohort
        public System.String CohortDescription { get; set; }

        /// <summary>
        /// Cohort Median Earnings
        /// <para>
        /// The midpoint between the lowest and highest quarterly wage, in U.S. dollars, for the total number of persons included in the cohort for the period of time between the Employment Record Reference Period Start Date and Employment Record Reference Period End Date.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20918">Cohort Median Earnings</a>
        /// </para>
        /// </summary>
        public Decimal? CohortMedianEarnings { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get; set; }

        #endregion
    }
}
