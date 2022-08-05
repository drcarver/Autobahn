//**********************************************************
//* DomainName: Autobahn.Workforce
//* FileName:   WorkforceEmploymentQuarterlyDataViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

namespace Autobahn.Workforce.ViewModels
{
     /// <summary>
     /// The WorkforceEmploymentQuarterlyDataViewModel
     /// </summary>
    public partial class WorkforceEmploymentQuarterlyDataViewModel : ViewModelBase, Interfaces.IWorkforceEmploymentQuarterlyData
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from WorkforceEmploymentQuarterlyData";

        // member variable for the OrganizationPersonRoleId property
        private Guid _OrganizationPersonRoleId;

        // member variable for the EmployedInMultipleJobsCount property
        private System.Decimal? _EmployedInMultipleJobsCount;

        // member variable for the MilitaryEnlistmentAfterExit property
        private System.Boolean? _MilitaryEnlistmentAfterExit;

        // member variable for the RefEmployedWhileEnrolledId property
        private Guid? _RefEmployedWhileEnrolledId;

        // member variable for the RefEmployedAfterExitId property
        private Guid? _RefEmployedAfterExitId;

        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

        // member variable for the RecordStatusId property
        private Guid? _RecordStatusId;

        // member variable for the DataCollectionId property
        private Guid? _DataCollectionId;

#endregion

        #region Properties
        /// <summary>
        /// The title of the WorkforceEmploymentQuarterlyDataViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationPersonRoleId"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get => _OrganizationPersonRoleId; set => SetProperty(ref _OrganizationPersonRoleId, value); }

        public System.Decimal? EmployedInMultipleJobsCount { get => _EmployedInMultipleJobsCount; set => SetProperty(ref _EmployedInMultipleJobsCount, value); }

        public System.Boolean? MilitaryEnlistmentAfterExit { get => _MilitaryEnlistmentAfterExit; set => SetProperty(ref _MilitaryEnlistmentAfterExit, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefEmployedWhileEnrolledId"/> model
        /// </summary>
        public Guid? RefEmployedWhileEnrolledId { get => _RefEmployedWhileEnrolledId; set => SetProperty(ref _RefEmployedWhileEnrolledId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefEmployedAfterExitId"/> model
        /// </summary>
        public Guid? RefEmployedAfterExitId { get => _RefEmployedAfterExitId; set => SetProperty(ref _RefEmployedAfterExitId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IWorkforceEmploymentQuarterlyData model)
        {
            IsBusy = true;
            Id = model.Id;
            OrganizationPersonRoleId = model.OrganizationPersonRoleId;
            EmployedInMultipleJobsCount = model.EmployedInMultipleJobsCount;
            MilitaryEnlistmentAfterExit = model.MilitaryEnlistmentAfterExit;
            RefEmployedWhileEnrolledId = model.RefEmployedWhileEnrolledId;
            RefEmployedAfterExitId = model.RefEmployedAfterExitId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
