//**********************************************************
//* DomainName: Autobahn.Workforce
//* FileName:   WorkforceProgramParticipantCohortViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

namespace Autobahn.Workforce.ViewModels
{
     /// <summary>
     /// The WorkforceProgramParticipantCohortViewModel
     /// </summary>
    public partial class WorkforceProgramParticipantCohortViewModel : ViewModelBase, Interfaces.IWorkforceProgramParticipantCohortViewModel
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from WorkforceProgramParticipantCohort";

        // member variable for the OrganizationPersonRoleId property
        private Guid _OrganizationPersonRoleId;

        // member variable for the CohortDescription property
        private System.String _CohortDescription;

        // member variable for the CohortMedianEarnings property
        private System.Decimal? _CohortMedianEarnings;

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
        /// The title of the WorkforceProgramParticipantCohortViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationPersonRoleId"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get => _OrganizationPersonRoleId; set => SetProperty(ref _OrganizationPersonRoleId, value); }

        public System.String CohortDescription  { get => _CohortDescription; set => SetProperty(ref _CohortDescription, value); }

        public System.Decimal? CohortMedianEarnings { get => _CohortMedianEarnings; set => SetProperty(ref _CohortMedianEarnings, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IWorkforceProgramParticipantCohort model)
        {
            IsBusy = true;
            Id = model.Id;
            OrganizationPersonRoleId = model.OrganizationPersonRoleId;
            CohortDescription = model.CohortDescription;
            CohortMedianEarnings = model.CohortMedianEarnings;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
