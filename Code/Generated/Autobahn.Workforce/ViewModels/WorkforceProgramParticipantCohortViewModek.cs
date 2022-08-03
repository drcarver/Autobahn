//**********************************************************
//* DomainName: Autobahn.Workforce
//* FileName:   WorkforceProgramParticipantCohortViewModel.cs
//**********************************************************

using Prism.Mvvm;
using Autobahn.Common.Interfaces;
using Autobahn.Autobahn.Workforce.Interfaces;

namespace Autobahn.Workforce.ViewModels
{
     /// <summary>
     /// The WorkforceProgramParticipantCohortViewModel
     /// </summary>
    public partial class WorkforceProgramParticipantCohortViewModel : BindableBase, IWorkforceProgramParticipantCohort
    {
#region "Backing Fields"
        // member variable for the CohortDescription property
        private System.String _CohortDescription;

        // member variable for the CohortMedianEarnings property
        private System.Decimal? _CohortMedianEarnings;

        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

#endregion

#region Properties
        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationPersonRoleId"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get; set; }

        public System.String CohortDescription  { get => _CohortDescription; set => SetProperty(ref _CohortDescription, value); }

        public System.Decimal? CohortMedianEarnings { get => _CohortMedianEarnings; set => SetProperty(ref _CohortMedianEarnings, value); }

        public System.DateTime? RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        public System.DateTime? RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatusId"/> model
        /// </summary>
        public Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollectionId"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

#endregion


        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(IWorkforceProgramParticipantCohort model)
        {
            IsBusy = true;
            Id = model.Id;
            OrganizationPersonRoleId = model.OrganizationPersonRoleId;
            CohortDescription = model.CohortDescription;
            CohortMedianEarnings = model.CohortMedianEarnings;
            RecordStartDateTime = model.RecordStartDateTime;
            RecordEndDateTime = model.RecordEndDateTime;
            RecordStatusId = model.RecordStatusId;
            DataCollectionId = model.DataCollectionId;
            IsChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
