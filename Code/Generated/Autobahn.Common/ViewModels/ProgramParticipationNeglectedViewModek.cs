//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   ProgramParticipationNeglectedViewModel.cs
//**********************************************************

using Prism.Mvvm;
using Autobahn.Common.Interfaces;
using Autobahn.Autobahn.Common.Interfaces;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The ProgramParticipationNeglectedViewModel
     /// </summary>
    public partial class ProgramParticipationNeglectedViewModel : BindableBase, IProgramParticipationNeglected
    {
#region "Backing Fields"
        // member variable for the AchievementIndicator property
        private System.Boolean? _AchievementIndicator;

        // member variable for the OutcomeIndicator property
        private System.Boolean? _OutcomeIndicator;

        // member variable for the ObtainedEmployment property
        private System.Boolean? _ObtainedEmployment;

        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

#endregion

#region Properties
        /// <summary>
        /// Reference to a required instance of the <see cref="PersonProgramParticipationId"/> model
        /// </summary>
        public Guid PersonProgramParticipationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefNeglectedProgramTypeId"/> model
        /// </summary>
        public Guid? RefNeglectedProgramTypeId { get; set; }

        public System.Boolean? AchievementIndicator { get => _AchievementIndicator; set => SetProperty(ref _AchievementIndicator, value); }

        public System.Boolean? OutcomeIndicator { get => _OutcomeIndicator; set => SetProperty(ref _OutcomeIndicator, value); }

        public System.Boolean? ObtainedEmployment { get => _ObtainedEmployment; set => SetProperty(ref _ObtainedEmployment, value); }

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
        public void Load(IProgramParticipationNeglected model)
        {
            IsBusy = true;
            Id = model.Id;
            PersonProgramParticipationId = model.PersonProgramParticipationId;
            RefNeglectedProgramTypeId = model.RefNeglectedProgramTypeId;
            AchievementIndicator = model.AchievementIndicator;
            OutcomeIndicator = model.OutcomeIndicator;
            ObtainedEmployment = model.ObtainedEmployment;
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
