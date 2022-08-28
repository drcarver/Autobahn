//**********************************************************
//* DomainName: Adult Education (AE)
//* FileName:   AeStaffModel.cs
//***************************************************************************

using Autobahn.Education.Interfaces.AdultEducation;

namespace Autobahn.Education.AdultEducation.Models
{
     /// <summary>
     /// The AeStaff Model
     /// </summary>
    public partial class AeStaffModel : IAeStaff
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

        #region IAeStaff
        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Adult Education Staff Classification
        /// <para>
        /// The titles of employment, official status, or rank of adult education staff.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19770">Adult Education Staff Classification</a>
        /// </para>
        /// </summary>
        public Guid? RefAeStaffClassificationId { get; set; }

        /// <summary>
        /// Adult Education Staff Employment Status
        /// <para>
        /// The condition under which a person has agreed to serve as an employee.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19771">Adult Education Staff Employment Status</a>
        /// </para>
        /// </summary>
        public Guid? RefAeStaffEmploymentStatusId { get; set; }

        /// <summary>
        /// Years of Prior Adult Education Teaching Experience
        /// <para>
        /// The total number of years that a person has previously held a teaching position in one or more adult education programs.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19774">Years of Prior Adult Education Teaching Experience</a>
        /// </para>
        /// </summary>
        public Decimal? YearsOfPriorAeTeachingExperience { get; set; }

        #endregion
    }
}
