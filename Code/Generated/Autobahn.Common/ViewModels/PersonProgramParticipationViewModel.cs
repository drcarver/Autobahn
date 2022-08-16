//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonProgramParticipationViewModel.cs
//**********************************************************

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The PersonProgramParticipationViewModel
     /// </summary>
    public partial class PersonProgramParticipationViewModel : ViewModelBase, Interfaces.IPersonProgramParticipation
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from PersonProgramParticipation";

        // member variable for the ParticipationStatus property
        private  _ParticipationStatus;

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        // member variable for the RefParticipationTypeId property
        private Guid? _RefParticipationTypeId;

        // member variable for the RefProgramEntryReasonId property
        private  _RefProgramEntryReasonId;

        // member variable for the RefProgramExitReasonId property
        private  _RefProgramExitReasonId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// </summary>
        public  ParticipationStatus { get => _ParticipationStatus; set => SetProperty(ref _ParticipationStatus, value); }

        /// <summary>
        /// </summary>
        public  RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// </summary>
        public  RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefParticipationType"/> model
        /// </summary>
        public Guid? RefParticipationTypeId { get => _RefParticipationTypeId; set => SetProperty(ref _RefParticipationTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefProgramEntryReason"/> model
        /// </summary>
        public  RefProgramEntryReasonId { get => _RefProgramEntryReasonId; set => SetProperty(ref _RefProgramEntryReasonId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefProgramExitReason"/> model
        /// </summary>
        public  RefProgramExitReasonId { get => _RefProgramExitReasonId; set => SetProperty(ref _RefProgramExitReasonId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IPersonProgramParticipation model)
        {
            IsBusy = true;
            Id = model.Id;
            ParticipationStatus = model.ParticipationStatus; // 
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            RefParticipationTypeId = model.RefParticipationTypeId; // 
            RefProgramEntryReasonId = model.RefProgramEntryReasonId; // 
            RefProgramExitReasonId = model.RefProgramExitReasonId; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
