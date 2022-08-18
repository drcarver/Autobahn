//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12StaffEmploymentViewModel.cs
//* Name:       Contract Days of Service Per Year
//* Definition: The number of days per year that a person is expected to work as outlined specifically in his or her employment agreement.
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.K12.ViewModels
{
     /// <summary>
     /// The number of days per year that a person is expected to work as outlined specifically in his or her employment agreement.
     /// </summary>
    public partial class K12StaffEmploymentViewModel : ViewModelBase, Interfaces.IK12StaffEmployment
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from K12StaffEmployment";

        // ContractDaysOfServicePerYear -- (backing property for Contract Days of Service Per Year)
        private System.Decimal? _ContractDaysOfServicePerYear;

        // MepPersonnelIndicator -- (backing property for Migrant Education Program Personnel Indicator)
        private System.Boolean? _MepPersonnelIndicator;

        // RefEmploymentStatusId -- (backing property for Employment Status)
        private Guid? _RefEmploymentStatusId;

        // RefK12StaffClassificationId -- (backing property for K12 Staff Classification)
        private Guid? _RefK12StaffClassificationId;

        // SalaryForTeachingAssignmentOnlyIndicator -- (backing property for Salary for Teaching Assignment Only Indicator)
        private System.Boolean? _SalaryForTeachingAssignmentOnlyIndicator;

        // member variable for the StaffEmploymentId property
        private Guid _StaffEmploymentId;

        // TitleITargetedAssistanceStaffFunded -- (backing property for Title I Targeted Assistance Staff Funded)
        private System.Boolean? _TitleITargetedAssistanceStaffFunded;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Contract Days of Service Per Year
        /// <para>
        /// The number of days per year that a person is expected to work as outlined specifically in his or her employment agreement.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19047">Contract Days of Service Per Year</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Decimal? ContractDaysOfServicePerYear { get => _ContractDaysOfServicePerYear; set => SetProperty(ref _ContractDaysOfServicePerYear, value); }

        /// <summary>
        /// Migrant Education Program Personnel Indicator
        /// <para>
        /// An indication that a staff member's salary is paid by the Title I, Part C Migrant Education Program (MEP) of ESEA as amended.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19534">Migrant Education Program Personnel Indicator</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Boolean? MepPersonnelIndicator { get => _MepPersonnelIndicator; set => SetProperty(ref _MepPersonnelIndicator, value); }

        /// <summary>
        /// Employment Status
        /// <para>
        /// The condition under which a person has agreed to serve as an employee.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19346">Employment Status</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefEmploymentStatusId { get => _RefEmploymentStatusId; set => SetProperty(ref _RefEmploymentStatusId, value); }

        /// <summary>
        /// K12 Staff Classification
        /// <para>
        /// The titles of employment, official status, or rank of education staff.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19087">K12 Staff Classification</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefK12StaffClassificationId { get => _RefK12StaffClassificationId; set => SetProperty(ref _RefK12StaffClassificationId, value); }

        /// <summary>
        /// Salary for Teaching Assignment Only Indicator
        /// <para>
        /// Indicator to determine whether the teacher's base salary includes pay for teaching assignments alone.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19234">Salary for Teaching Assignment Only Indicator</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Boolean? SalaryForTeachingAssignmentOnlyIndicator { get => _SalaryForTeachingAssignmentOnlyIndicator; set => SetProperty(ref _SalaryForTeachingAssignmentOnlyIndicator, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IStaffEmployment"/> model
        /// </summary>
        public Guid StaffEmploymentId { get => _StaffEmploymentId; set => SetProperty(ref _StaffEmploymentId, value); }

        /// <summary>
        /// Title I Targeted Assistance Staff Funded
        /// <para>
        /// An indication that a staff member is targeted assistance (TAS) program staff funded by Title I, Part A, Section 1115 of ESEA as amended.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19543">Title I Targeted Assistance Staff Funded</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Boolean? TitleITargetedAssistanceStaffFunded { get => _TitleITargetedAssistanceStaffFunded; set => SetProperty(ref _TitleITargetedAssistanceStaffFunded, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IK12StaffEmployment model)
        {
            IsBusy = true;
            Id = model.Id;
            ContractDaysOfServicePerYear = model.ContractDaysOfServicePerYear; // Contract Days of Service Per Year
            MepPersonnelIndicator = model.MepPersonnelIndicator; // Migrant Education Program Personnel Indicator
            RefEmploymentStatusId = model.RefEmploymentStatusId; // Employment Status
            RefK12StaffClassificationId = model.RefK12StaffClassificationId; // K12 Staff Classification
            SalaryForTeachingAssignmentOnlyIndicator = model.SalaryForTeachingAssignmentOnlyIndicator; // Salary for Teaching Assignment Only Indicator
            StaffEmploymentId = model.StaffEmploymentId; // 
            TitleITargetedAssistanceStaffFunded = model.TitleITargetedAssistanceStaffFunded; // Title I Targeted Assistance Staff Funded
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
