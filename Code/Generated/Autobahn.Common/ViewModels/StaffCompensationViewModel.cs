//**********************************************************
//* DomainName: Common Models
//* FileName:   StaffCompensationViewModel.cs
//***************************************************************************

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The StaffCompensation View Model
     /// </summary>
    public partial class StaffCompensationViewModel : ViewModelBase, Interfaces.IStaffCompensation
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from StaffCompensation";

        // RefStaffCompensationSourceTypeId -- (backing property for Staff Compensation Source Type)
        private Guid? _RefStaffCompensationSourceTypeId;

        // StaffCompensationAnnualSupplement -- (backing property for Staff Compensation Annual Supplement)
        private System.Decimal? _StaffCompensationAnnualSupplement;

        // StaffCompensationBaseSalary -- (backing property for Staff Compensation Base Salary)
        private System.Decimal? _StaffCompensationBaseSalary;

        // StaffCompensationHealthBenefits -- (backing property for Staff Compensation Health Benefits)
        private System.Decimal? _StaffCompensationHealthBenefits;

        // StaffCompensationLongevity -- (backing property for Staff Compensation Longevity)
        private System.Decimal? _StaffCompensationLongevity;

        // StaffCompensationOtherBenefits -- (backing property for Staff Compensation Other Benefits)
        private System.Decimal? _StaffCompensationOtherBenefits;

        // StaffCompensationRetirementBenefits -- (backing property for Staff Compensation Retirement Benefits)
        private System.Decimal? _StaffCompensationRetirementBenefits;

        // StaffCompensationTotalBenefits -- (backing property for Staff Compensation Total Benefits)
        private System.Decimal? _StaffCompensationTotalBenefits;

        // StaffCompensationTotalSalary -- (backing property for Staff Compensation Total Salary)
        private System.Decimal? _StaffCompensationTotalSalary;

        // member variable for the StaffEmploymentId property
        private Guid _StaffEmploymentId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Staff Compensation Source Type
        /// <para>
        /// The source for the staff compensation a person receives.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20964">Staff Compensation Source Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefStaffCompensationSourceTypeId { get => _RefStaffCompensationSourceTypeId; set => SetProperty(ref _RefStaffCompensationSourceTypeId, value); }

        /// <summary>
        /// Staff Compensation Annual Supplement
        /// <para>
        /// The annual sum of payments given to staff in addition to their regular wages.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20962">Staff Compensation Annual Supplement</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Decimal? StaffCompensationAnnualSupplement { get => _StaffCompensationAnnualSupplement; set => SetProperty(ref _StaffCompensationAnnualSupplement, value); }

        /// <summary>
        /// Staff Compensation Base Salary
        /// <para>
        /// The salary or wage a person is paid before deductions (excluding differentials) but including annuities.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19032">Staff Compensation Base Salary</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Decimal? StaffCompensationBaseSalary { get => _StaffCompensationBaseSalary; set => SetProperty(ref _StaffCompensationBaseSalary, value); }

        /// <summary>
        /// Staff Compensation Health Benefits
        /// <para>
        /// Contributions made by the school district, municipal, state, federal and other government agencies for the teacher's or early learning provider's health insurance, prorated to the specific school or local provider agency indicated on the record, not including contributions made by the teacher or early learning provider.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19136">Staff Compensation Health Benefits</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Decimal? StaffCompensationHealthBenefits { get => _StaffCompensationHealthBenefits; set => SetProperty(ref _StaffCompensationHealthBenefits, value); }

        /// <summary>
        /// Staff Compensation Longevity
        /// <para>
        /// Compensation paid to a staff member based on their years of service.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20963">Staff Compensation Longevity</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Decimal? StaffCompensationLongevity { get => _StaffCompensationLongevity; set => SetProperty(ref _StaffCompensationLongevity, value); }

        /// <summary>
        /// Staff Compensation Other Benefits
        /// <para>
        /// All other benefits paid by the school district, municipal, state, federal, and other government agencies for the teacher or early learning provider, prorated to the specific school or local provider agency indicated on the record, not including retirement and health insurance benefits or contributions made by the teacher or early learning provider.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19205">Staff Compensation Other Benefits</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Decimal? StaffCompensationOtherBenefits { get => _StaffCompensationOtherBenefits; set => SetProperty(ref _StaffCompensationOtherBenefits, value); }

        /// <summary>
        /// Staff Compensation Retirement Benefits
        /// <para>
        /// Contributions made by the school district, municipal, state, federal and other government agencies for the teacher's or early learning provider's health insurance, prorated to the specific school or local provider agency indicated on the record, not including contributions made by the teacher or early learning provider.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19233">Staff Compensation Retirement Benefits</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Decimal? StaffCompensationRetirementBenefits { get => _StaffCompensationRetirementBenefits; set => SetProperty(ref _StaffCompensationRetirementBenefits, value); }

        /// <summary>
        /// Staff Compensation Total Benefits
        /// <para>
        /// Sum of retirement, health, and all other benefits, or total benefits paid by the school district, municipal, state, federal and other government agencies for the teacher's or early learning provider's health insurance, prorated to the specific school or local provider agency indicated on the record, not including contributions made by the teacher or early learning provider.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19293">Staff Compensation Total Benefits</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Decimal? StaffCompensationTotalBenefits { get => _StaffCompensationTotalBenefits; set => SetProperty(ref _StaffCompensationTotalBenefits, value); }

        /// <summary>
        /// Staff Compensation Total Salary
        /// <para>
        /// Total annualized salary of staff at the specific school/program indicated on the record in the school/program year  specified on the record.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19295">Staff Compensation Total Salary</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Decimal? StaffCompensationTotalSalary { get => _StaffCompensationTotalSalary; set => SetProperty(ref _StaffCompensationTotalSalary, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IStaffEmployment"/> model
        /// </summary>
        public Guid StaffEmploymentId { get => _StaffEmploymentId; set => SetProperty(ref _StaffEmploymentId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IStaffCompensation model)
        {
            IsBusy = true;
            Id = model.Id;
            RefStaffCompensationSourceTypeId = model.RefStaffCompensationSourceTypeId; // Staff Compensation Source Type
            StaffCompensationAnnualSupplement = model.StaffCompensationAnnualSupplement; // Staff Compensation Annual Supplement
            StaffCompensationBaseSalary = model.StaffCompensationBaseSalary; // Staff Compensation Base Salary
            StaffCompensationHealthBenefits = model.StaffCompensationHealthBenefits; // Staff Compensation Health Benefits
            StaffCompensationLongevity = model.StaffCompensationLongevity; // Staff Compensation Longevity
            StaffCompensationOtherBenefits = model.StaffCompensationOtherBenefits; // Staff Compensation Other Benefits
            StaffCompensationRetirementBenefits = model.StaffCompensationRetirementBenefits; // Staff Compensation Retirement Benefits
            StaffCompensationTotalBenefits = model.StaffCompensationTotalBenefits; // Staff Compensation Total Benefits
            StaffCompensationTotalSalary = model.StaffCompensationTotalSalary; // Staff Compensation Total Salary
            StaffEmploymentId = model.StaffEmploymentId; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
