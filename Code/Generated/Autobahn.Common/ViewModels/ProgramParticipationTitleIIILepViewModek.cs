//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   ProgramParticipationTitleIIILepViewModel.cs
//**********************************************************

using Prism.Mvvm;
using Autobahn.Common.Interfaces;
using Autobahn.Autobahn.Common.Interfaces;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The ProgramParticipationTitleIIILepViewModel
     /// </summary>
    public partial class ProgramParticipationTitleIIILepViewModel : BindableBase, IProgramParticipationTitleIIILep
    {
#region "Backing Fields"
        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

#endregion

#region Properties
        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTitleIIIAccountabilityId"/> model
        /// </summary>
        public Guid? RefTitleIIIAccountabilityId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTitleIIILanguageInstructionProgramTypeId"/> model
        /// </summary>
        public Guid? RefTitleIIILanguageInstructionProgramTypeId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="PersonProgramParticipationId"/> model
        /// </summary>
        public Guid PersonProgramParticipationId { get; set; }

        public System.DateTime? RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        public System.DateTime? RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="ProgramParticipationTitleIiiLepId"/> model
        /// </summary>
        public Guid ProgramParticipationTitleIiiLepId { get; set; }

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
        public void Load(IProgramParticipationTitleIIILep model)
        {
            IsBusy = true;
            Id = model.Id;
            RefTitleIIIAccountabilityId = model.RefTitleIIIAccountabilityId;
            RefTitleIIILanguageInstructionProgramTypeId = model.RefTitleIIILanguageInstructionProgramTypeId;
            PersonProgramParticipationId = model.PersonProgramParticipationId;
            RecordStartDateTime = model.RecordStartDateTime;
            RecordEndDateTime = model.RecordEndDateTime;
            ProgramParticipationTitleIiiLepId = model.ProgramParticipationTitleIiiLepId;
            RecordStatusId = model.RecordStatusId;
            DataCollectionId = model.DataCollectionId;
            IsChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
