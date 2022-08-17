//**********************************************************
//* DomainName: Common Models
//* FileName:   StaffCompensationModel.cs
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The StaffCompensation Model
     /// </summary>
    public partial class StaffCompensationModel : AutobahnBase, Interfaces.IStaffCompensation
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefStaffCompensationSourceType"/> model
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
        public System.Decimal? StaffCompensationAnnualSupplement { get; set; }

        /// <summary>
        /// Staff Compensation Base Salary
        /// <para>
        /// The salary or wage a person is paid before deductions (excluding differentials) but including annuities.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19032">Staff Compensation Base Salary</a>
        /// </para>
        /// </summary>
        public System.Decimal? StaffCompensationBaseSalary { get; set; }

        /// <summary>
        /// Staff Compensation Health Benefits
        /// <para>
        /// Contributions made by the school district, municipal, state, federal and other government agencies for the teacher's or early learning provider's health insurance, prorated to the specific school or local provider agency indicated on the record, not including contributions made by the teacher or early learning provider.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19136">Staff Compensation Health Benefits</a>
        /// </para>
        /// </summary>
        public System.Decimal? StaffCompensationHealthBenefits { get; set; }

        /// <summary>
        /// Staff Compensation Longevity
        /// <para>
        /// Compensation paid to a staff member based on their years of service.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20963">Staff Compensation Longevity</a>
        /// </para>
        /// </summary>
        public System.Decimal? StaffCompensationLongevity { get; set; }

        /// <summary>
        /// Staff Compensation Other Benefits
        /// <para>
        /// All other benefits paid by the school district, municipal, state, federal, and other government agencies for the teacher or early learning provider, prorated to the specific school or local provider agency indicated on the record, not including retirement and health insurance benefits or contributions made by the teacher or early learning provider.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19205">Staff Compensation Other Benefits</a>
        /// </para>
        /// </summary>
        public System.Decimal? StaffCompensationOtherBenefits { get; set; }

        /// <summary>
        /// Staff Compensation Retirement Benefits
        /// <para>
        /// Contributions made by the school district, municipal, state, federal and other government agencies for the teacher's or early learning provider's health insurance, prorated to the specific school or local provider agency indicated on the record, not including contributions made by the teacher or early learning provider.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19233">Staff Compensation Retirement Benefits</a>
        /// </para>
        /// </summary>
        public System.Decimal? StaffCompensationRetirementBenefits { get; set; }

        /// <summary>
        /// Staff Compensation Total Benefits
        /// <para>
        /// Sum of retirement, health, and all other benefits, or total benefits paid by the school district, municipal, state, federal and other government agencies for the teacher's or early learning provider's health insurance, prorated to the specific school or local provider agency indicated on the record, not including contributions made by the teacher or early learning provider.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19293">Staff Compensation Total Benefits</a>
        /// </para>
        /// </summary>
        public System.Decimal? StaffCompensationTotalBenefits { get; set; }

        /// <summary>
        /// Staff Compensation Total Salary
        /// <para>
        /// Total annualized salary of staff at the specific school/program indicated on the record in the school/program year  specified on the record.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19295">Staff Compensation Total Salary</a>
        /// </para>
        /// </summary>
        public System.Decimal? StaffCompensationTotalSalary { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IStaffEmployment"/> model
        /// </summary>
        public Guid StaffEmploymentId { get; set; }

    }
}
