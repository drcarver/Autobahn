//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   PersonProgramParticipationViewModel.cs
//**********************************************************

using Prism.Mvvm;
using Autobahn.Common.Interfaces;
using Autobahn.Autobahn.Common.Interfaces;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The PersonProgramParticipationViewModel
     /// </summary>
    public partial class PersonProgramParticipationViewModel : BindableBase, IPersonProgramParticipation
    {
#region "Backing Fields"
        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

        // member variable for the ParticipationStatus property
        private System.String _ParticipationStatus;

#endregion

#region Properties
        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationPersonRoleId"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefParticipationTypeId"/> model
        /// </summary>
        public Guid? RefParticipationTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefProgramExitReasonId"/> model
        /// </summary>
        public Guid? RefProgramExitReasonId { get; set; }

        public System.DateTime? RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        public System.DateTime? RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        public System.String ParticipationStatus  { get => _ParticipationStatus; set => SetProperty(ref _ParticipationStatus, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefProgramEntryReasonId"/> model
        /// </summary>
        public Guid? RefProgramEntryReasonId { get; set; }

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
        public void Load(IPersonProgramParticipation model)
        {
            IsBusy = true;
            Id = model.Id;
            OrganizationPersonRoleId = model.OrganizationPersonRoleId;
            RefParticipationTypeId = model.RefParticipationTypeId;
            RefProgramExitReasonId = model.RefProgramExitReasonId;
            RecordStartDateTime = model.RecordStartDateTime;
            RecordEndDateTime = model.RecordEndDateTime;
            ParticipationStatus = model.ParticipationStatus;
            RefProgramEntryReasonId = model.RefProgramEntryReasonId;
            RecordStatusId = model.RecordStatusId;
            DataCollectionId = model.DataCollectionId;
            IsChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
