//**********************************************************
//* DomainName: Early Learning (EL)
//* FileName:   ELStaffEmploymentViewModel.cs
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.EarlyLearning.ViewModels
{
     /// <summary>
     /// The ELStaffEmployment View Model
     /// </summary>
    public partial class ELStaffEmploymentViewModel : ViewModelBase, Interfaces.IELStaffEmployment
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from ELStaffEmployment";

        // HourlyWage -- (backing property for Hourly Wage)
        private System.Decimal? _HourlyWage;

        // HoursWorkedPerWeek -- (backing property for Hours Worked Per Week)
        private System.Decimal? _HoursWorkedPerWeek;

        // RefELEducationStaffClassificationId -- (backing property for Early Learning Education Staff Classification)
        private Guid? _RefELEducationStaffClassificationId;

        // RefELEmploymentSeparationReasonId -- (backing property for Early Learning Employment Separation Reason)
        private Guid? _RefELEmploymentSeparationReasonId;

        // RefELServiceProfessionalStaffClassificationId -- (backing property for Early Learning Service Professional Staff Classification)
        private Guid? _RefELServiceProfessionalStaffClassificationId;

        // RefEmploymentStatusId -- (backing property for Employment Status)
        private Guid? _RefEmploymentStatusId;

        // RefWageCollectionMethodId -- (backing property for Wage Collection Code)
        private Guid? _RefWageCollectionMethodId;

        // RefWageVerificationId -- (backing property for Wage Verification Code)
        private Guid? _RefWageVerificationId;

        // StaffApprovalIndicator -- (backing property for Staff Approval Indicator)
        private System.Boolean? _StaffApprovalIndicator;

        // member variable for the StaffEmploymentId property
        private Guid _StaffEmploymentId;

        // UnionMembershipStatus -- (backing property for Union Membership Status)
        private System.Boolean? _UnionMembershipStatus;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Hourly Wage
        /// <para>
        /// Hourly wage associated with the employment position being reported.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19796">Hourly Wage</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Decimal? HourlyWage { get => _HourlyWage; set => SetProperty(ref _HourlyWage, value); }

        /// <summary>
        /// Hours Worked Per Week
        /// <para>
        /// The number of hours worked per week in employment.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19795">Hours Worked Per Week</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Decimal? HoursWorkedPerWeek { get => _HoursWorkedPerWeek; set => SetProperty(ref _HoursWorkedPerWeek, value); }

        /// <summary>
        /// Early Learning Education Staff Classification
        /// <para>
        /// The title/role of employment, official status, or rank of education staff
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20581">Early Learning Education Staff Classification</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefELEducationStaffClassificationId { get => _RefELEducationStaffClassificationId; set => SetProperty(ref _RefELEducationStaffClassificationId, value); }

        /// <summary>
        /// Early Learning Employment Separation Reason
        /// <para>
        /// The primary reason for the termination of the employment relationship.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20613">Early Learning Employment Separation Reason</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefELEmploymentSeparationReasonId { get => _RefELEmploymentSeparationReasonId; set => SetProperty(ref _RefELEmploymentSeparationReasonId, value); }

        /// <summary>
        /// Early Learning Service Professional Staff Classification
        /// <para>
        /// The title/role of employment, official status, or rank of early learning service professionals
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20617">Early Learning Service Professional Staff Classification</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefELServiceProfessionalStaffClassificationId { get => _RefELServiceProfessionalStaffClassificationId; set => SetProperty(ref _RefELServiceProfessionalStaffClassificationId, value); }

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
        /// Wage Collection Code
        /// <para>
        /// Method used for the collection of wage data for an employment record.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19797">Wage Collection Code</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefWageCollectionMethodId { get => _RefWageCollectionMethodId; set => SetProperty(ref _RefWageCollectionMethodId, value); }

        /// <summary>
        /// Wage Verification Code
        /// <para>
        /// An indication of whether the wage information has been verified.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19818">Wage Verification Code</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefWageVerificationId { get => _RefWageVerificationId; set => SetProperty(ref _RefWageVerificationId, value); }

        /// <summary>
        /// Staff Approval Indicator
        /// <para>
        /// Individual is approved to Work with Children
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20560">Staff Approval Indicator</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Boolean? StaffApprovalIndicator { get => _StaffApprovalIndicator; set => SetProperty(ref _StaffApprovalIndicator, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IStaffEmployment"/> model
        /// </summary>
        public Guid StaffEmploymentId { get => _StaffEmploymentId; set => SetProperty(ref _StaffEmploymentId, value); }

        /// <summary>
        /// Union Membership Status
        /// <para>
        /// An indication of whether the person is a member of a union.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19798">Union Membership Status</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Boolean? UnionMembershipStatus { get => _UnionMembershipStatus; set => SetProperty(ref _UnionMembershipStatus, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IELStaffEmployment model)
        {
            IsBusy = true;
            Id = model.Id;
            HourlyWage = model.HourlyWage; // Hourly Wage
            HoursWorkedPerWeek = model.HoursWorkedPerWeek; // Hours Worked Per Week
            RefELEducationStaffClassificationId = model.RefELEducationStaffClassificationId; // Early Learning Education Staff Classification
            RefELEmploymentSeparationReasonId = model.RefELEmploymentSeparationReasonId; // Early Learning Employment Separation Reason
            RefELServiceProfessionalStaffClassificationId = model.RefELServiceProfessionalStaffClassificationId; // Early Learning Service Professional Staff Classification
            RefEmploymentStatusId = model.RefEmploymentStatusId; // Employment Status
            RefWageCollectionMethodId = model.RefWageCollectionMethodId; // Wage Collection Code
            RefWageVerificationId = model.RefWageVerificationId; // Wage Verification Code
            StaffApprovalIndicator = model.StaffApprovalIndicator; // Staff Approval Indicator
            StaffEmploymentId = model.StaffEmploymentId; // 
            UnionMembershipStatus = model.UnionMembershipStatus; // Union Membership Status
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }

        #region RefWageCollectionMethod List
        /// <summary>
        /// The complete <see cref="RefWageCollectionMethod"> List
        /// </summary>
        private static List<ReferenceModelBase> RefWageCollectionMethodList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("a9a69643-e7c9-4525-8170-39019168f425"), Code="01", Description="Collected as an hourly wage amount", Definition="The wage data for an employment record was collected as an hourly wage amount.", SortOrder=Convert.ToDecimal("1.00") },
            new ReferenceModelBase { Id=Guid.Parse("fa5a9f95-bbef-4d86-8f41-5d4c70f96ffa"), Code="02", Description="Collected as salary and converted to an hourly wage amount", Definition="The wage data for an employment record was collected as salary and converted to an hourly wage amount.", SortOrder=Convert.ToDecimal("2.00") },
            new ReferenceModelBase { Id=Guid.Parse("90cad34a-3cc0-4efe-84e7-f9ef9e3cb7c3"), Code="03", Description="Collected in both methods but method not tracked on an individual record", Definition="The wage data for an employment record was collected in both methods but method not tracked on an individual record.", SortOrder=Convert.ToDecimal("3.00") },
            new ReferenceModelBase { Id=Guid.Parse("450fba43-87cc-47d1-837f-c252c78db033"), Code="99", Description="Wage data not present", Definition="Wage data not present in the employment record.", SortOrder=Convert.ToDecimal("4.00") },
        };
        #endregion

        #region RefWageVerification List
        /// <summary>
        /// The complete <see cref="RefWageVerification"> List
        /// </summary>
        private static List<ReferenceModelBase> RefWageVerificationList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("3dc8bef2-5e93-47b5-88f5-20285b37e988"), Code="01", Description="Verified", Definition="The wage information has been verified.", SortOrder=Convert.ToDecimal("1.00") },
            new ReferenceModelBase { Id=Guid.Parse("096b5cdc-72f2-4a0c-8d80-7c7c5dd1e123"), Code="02", Description="Not verified", Definition="The wage information has NOT been verified.", SortOrder=Convert.ToDecimal("2.00") },
            new ReferenceModelBase { Id=Guid.Parse("64782cfc-d332-440a-9612-df097d54064b"), Code="03", Description="Wage data not present", Definition="Wage data not present.", SortOrder=Convert.ToDecimal("3.00") },
        };
        #endregion
    }
}
