//**********************************************************
//* DomainName: Workforce
//* FileName:   WorkforceProgramParticipantCohortViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

namespace Autobahn.Workforce.ViewModels
{
     /// <summary>
     /// The WorkforceProgramParticipantCohortViewModel
     /// </summary>
    public partial class WorkforceProgramParticipantCohortViewModel : ViewModelBase, Interfaces.IWorkforceProgramParticipantCohort
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from WorkforceProgramParticipantCohort";

        // member variable for the CohortDescription property
        private System.String _CohortDescription;

        // member variable for the CohortMedianEarnings property
        private System.Decimal? _CohortMedianEarnings;

        // member variable for the OrganizationPersonRoleId property
        private Guid _OrganizationPersonRoleId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the WorkforceProgramParticipantCohortViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        public System.String CohortDescription { get => _CohortDescription; set => SetProperty(ref _CohortDescription, value); }

        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        public System.Decimal? CohortMedianEarnings { get => _CohortMedianEarnings; set => SetProperty(ref _CohortMedianEarnings, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="OrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get => _OrganizationPersonRoleId; set => SetProperty(ref _OrganizationPersonRoleId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IWorkforceProgramParticipantCohort model)
        {
            IsBusy = true;
            Id = model.Id;
            CohortDescription = model.CohortDescription;
            CohortMedianEarnings = model.CohortMedianEarnings;
            OrganizationPersonRoleId = model.OrganizationPersonRoleId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
