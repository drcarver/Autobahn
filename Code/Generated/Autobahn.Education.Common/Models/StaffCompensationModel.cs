//**********************************************************
//* DomainName: Common Models
//* FileName:   StaffCompensationModel.cs
//***************************************************************************

using Autobahn.Education.Interfaces.Common;

namespace Autobahn.Education.Common.Models
{
     /// <summary>
     /// The StaffCompensation Model
     /// </summary>
    public partial class StaffCompensationModel : IStaffCompensation
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

        #region IStaffCompensation
        /// <summary>
        /// Staff Compensation Source Type
        /// <para>
        /// The source for the staff compensation a person receives.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20964">Staff Compensation Source Type</a>
        /// </para>
        /// </summary>
        public Guid? RefStaffCompensationSourceTypeId { get; set; }

        /// <summary>
        /// Staff Compensation Annual Supplement
        /// <para>
        /// The annual sum of payments given to staff in addition to their regular wages.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20962">Staff Compensation Annual Supplement</a>
        /// </para>
        /// </summary>
        public Decimal? StaffCompensationAnnualSupplement { get; set; }

        /// <summary>
        /// Staff Compensation Base Salary
        /// <para>
        /// The salary or wage a person is paid before deductions (excluding differentials) but including annuities.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19032">Staff Compensation Base Salary</a>
        /// </para>
        /// </summary>
        public Decimal? StaffCompensationBaseSalary { get; set; }

        /// <summary>
        /// Staff Compensation Health Benefits
        /// <para>
        /// Contributions made by the school district, municipal, state, federal and other government agencies for the teacher's or early learning provider's health insurance, prorated to the specific school or local provider agency indicated on the record, not including contributions made by the teacher or early learning provider.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19136">Staff Compensation Health Benefits</a>
        /// </para>
        /// </summary>
        public Decimal? StaffCompensationHealthBenefits { get; set; }

        /// <summary>
        /// Staff Compensation Longevity
        /// <para>
        /// Compensation paid to a staff member based on their years of service.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20963">Staff Compensation Longevity</a>
        /// </para>
        /// </summary>
        public Decimal? StaffCompensationLongevity { get; set; }

        /// <summary>
        /// Staff Compensation Other Benefits
        /// <para>
        /// All other benefits paid by the school district, municipal, state, federal, and other government agencies for the teacher or early learning provider, prorated to the specific school or local provider agency indicated on the record, not including retirement and health insurance benefits or contributions made by the teacher or early learning provider.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19205">Staff Compensation Other Benefits</a>
        /// </para>
        /// </summary>
        public Decimal? StaffCompensationOtherBenefits { get; set; }

        /// <summary>
        /// Staff Compensation Retirement Benefits
        /// <para>
        /// Contributions made by the school district, municipal, state, federal and other government agencies for the teacher's or early learning provider's health insurance, prorated to the specific school or local provider agency indicated on the record, not including contributions made by the teacher or early learning provider.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19233">Staff Compensation Retirement Benefits</a>
        /// </para>
        /// </summary>
        public Decimal? StaffCompensationRetirementBenefits { get; set; }

        /// <summary>
        /// Staff Compensation Total Benefits
        /// <para>
        /// Sum of retirement, health, and all other benefits, or total benefits paid by the school district, municipal, state, federal and other government agencies for the teacher's or early learning provider's health insurance, prorated to the specific school or local provider agency indicated on the record, not including contributions made by the teacher or early learning provider.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19293">Staff Compensation Total Benefits</a>
        /// </para>
        /// </summary>
        public Decimal? StaffCompensationTotalBenefits { get; set; }

        /// <summary>
        /// Staff Compensation Total Salary
        /// <para>
        /// Total annualized salary of staff at the specific school/program indicated on the record in the school/program year  specified on the record.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19295">Staff Compensation Total Salary</a>
        /// </para>
        /// </summary>
        public Decimal? StaffCompensationTotalSalary { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IStaffEmployment"/> model
        /// </summary>
        public Guid StaffEmploymentId { get; set; }

        #endregion
    }
}
