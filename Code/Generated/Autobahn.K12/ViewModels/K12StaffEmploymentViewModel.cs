//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12StaffEmploymentViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;
using CommunityToolkit.Maui;

namespace Autobahn.K12.ViewModels
{
     /// <summary>
     /// The K12StaffEmploymentViewModel
     /// </summary>
    public partial class K12StaffEmploymentViewModel : ViewModelBase, Interfaces.IK12StaffEmployment
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from K12StaffEmployment";

        // member variable for the ContractDaysOfServicePerYear property
        private System.Decimal? _ContractDaysOfServicePerYear;

        // member variable for the MepPersonnelIndicator property
        private System.Boolean? _MepPersonnelIndicator;

        // member variable for the RefEmploymentStatusId property
        private Guid? _RefEmploymentStatusId;

        // member variable for the RefK12StaffClassificationId property
        private Guid? _RefK12StaffClassificationId;

        // member variable for the SalaryForTeachingAssignmentOnlyIndicator property
        private System.Boolean? _SalaryForTeachingAssignmentOnlyIndicator;

        // member variable for the StaffEmploymentId property
        private Guid _StaffEmploymentId;

        // member variable for the TitleITargetedAssistanceStaffFunded property
        private System.Boolean? _TitleITargetedAssistanceStaffFunded;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the K12StaffEmploymentViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// The number of days per year that a person is expected to work as outlined specifically in his or her employment agreement.
        /// </summary>
        public System.Decimal? ContractDaysOfServicePerYear { get => _ContractDaysOfServicePerYear; set => SetProperty(ref _ContractDaysOfServicePerYear, value); }

        /// <summary>
        /// The number of days per year that a person is expected to work as outlined specifically in his or her employment agreement.
        /// </summary>
        public System.Boolean? MepPersonnelIndicator { get => _MepPersonnelIndicator; set => SetProperty(ref _MepPersonnelIndicator, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefEmploymentStatus"/> model
        /// </summary>
        public Guid? RefEmploymentStatusId { get => _RefEmploymentStatusId; set => SetProperty(ref _RefEmploymentStatusId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefK12StaffClassification"/> model
        /// </summary>
        public Guid? RefK12StaffClassificationId { get => _RefK12StaffClassificationId; set => SetProperty(ref _RefK12StaffClassificationId, value); }

        /// <summary>
        /// The number of days per year that a person is expected to work as outlined specifically in his or her employment agreement.
        /// </summary>
        public System.Boolean? SalaryForTeachingAssignmentOnlyIndicator { get => _SalaryForTeachingAssignmentOnlyIndicator; set => SetProperty(ref _SalaryForTeachingAssignmentOnlyIndicator, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="StaffEmployment"/> model
        /// </summary>
        public Guid StaffEmploymentId { get => _StaffEmploymentId; set => SetProperty(ref _StaffEmploymentId, value); }

        /// <summary>
        /// The number of days per year that a person is expected to work as outlined specifically in his or her employment agreement.
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
            ContractDaysOfServicePerYear = model.ContractDaysOfServicePerYear;
            MepPersonnelIndicator = model.MepPersonnelIndicator;
            RefEmploymentStatusId = model.RefEmploymentStatusId;
            RefK12StaffClassificationId = model.RefK12StaffClassificationId;
            SalaryForTeachingAssignmentOnlyIndicator = model.SalaryForTeachingAssignmentOnlyIndicator;
            StaffEmploymentId = model.StaffEmploymentId;
            TitleITargetedAssistanceStaffFunded = model.TitleITargetedAssistanceStaffFunded;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
