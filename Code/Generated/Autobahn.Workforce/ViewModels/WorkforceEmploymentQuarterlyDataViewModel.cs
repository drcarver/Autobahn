//**********************************************************
//* DomainName: Workforce
//* FileName:   WorkforceEmploymentQuarterlyDataViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;
using CommunityToolkit.Maui;

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

        // member variable for the EmployedInMultipleJobsCount property
        private System.Decimal? _EmployedInMultipleJobsCount;

        // member variable for the MilitaryEnlistmentAfterExit property
        private System.Boolean? _MilitaryEnlistmentAfterExit;

        // member variable for the OrganizationPersonRoleId property
        private Guid _OrganizationPersonRoleId;

        // member variable for the RefEmployedAfterExitId property
        private Guid? _RefEmployedAfterExitId;

        // member variable for the RefEmployedWhileEnrolledId property
        private Guid? _RefEmployedWhileEnrolledId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the WorkforceEmploymentQuarterlyDataViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// An individual who is a paid employee or works in his or her own business, profession, or farm, as reported through the State Unemployment Insurance Wage Report, FEDES, or WRIS, and at the same time is enrolled in secondary, postsecondary, or adult education or workforce programs.
        /// </summary>
        public System.Decimal? EmployedInMultipleJobsCount { get => _EmployedInMultipleJobsCount; set => SetProperty(ref _EmployedInMultipleJobsCount, value); }

        /// <summary>
        /// An individual who is a paid employee or works in his or her own business, profession, or farm, as reported through the State Unemployment Insurance Wage Report, FEDES, or WRIS, and at the same time is enrolled in secondary, postsecondary, or adult education or workforce programs.
        /// </summary>
        public System.Boolean? MilitaryEnlistmentAfterExit { get => _MilitaryEnlistmentAfterExit; set => SetProperty(ref _MilitaryEnlistmentAfterExit, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="OrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get => _OrganizationPersonRoleId; set => SetProperty(ref _OrganizationPersonRoleId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefEmployedAfterExit"/> model
        /// </summary>
        public Guid? RefEmployedAfterExitId { get => _RefEmployedAfterExitId; set => SetProperty(ref _RefEmployedAfterExitId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefEmployedWhileEnrolled"/> model
        /// </summary>
        public Guid? RefEmployedWhileEnrolledId { get => _RefEmployedWhileEnrolledId; set => SetProperty(ref _RefEmployedWhileEnrolledId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IWorkforceEmploymentQuarterlyData model)
        {
            IsBusy = true;
            Id = model.Id;
            EmployedInMultipleJobsCount = model.EmployedInMultipleJobsCount;
            MilitaryEnlistmentAfterExit = model.MilitaryEnlistmentAfterExit;
            OrganizationPersonRoleId = model.OrganizationPersonRoleId;
            RefEmployedAfterExitId = model.RefEmployedAfterExitId;
            RefEmployedWhileEnrolledId = model.RefEmployedWhileEnrolledId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
