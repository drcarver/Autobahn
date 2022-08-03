//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   ProgramParticipationWIOAViewModel.cs
//**********************************************************

using Prism.Mvvm;
using Autobahn.Common.Interfaces;
using Autobahn.Autobahn.Common.Interfaces;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The ProgramParticipationWIOAViewModel
     /// </summary>
    public partial class ProgramParticipationWIOAViewModel : BindableBase, IProgramParticipationWIOA
    {
#region "Backing Fields"
        // member variable for the WIOACareerServices property
        private System.Boolean? _WIOACareerServices;

        // member variable for the WIOATrainingServices property
        private System.Boolean? _WIOATrainingServices;

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

        public System.Boolean? WIOACareerServices { get => _WIOACareerServices; set => SetProperty(ref _WIOACareerServices, value); }

        public System.Boolean? WIOATrainingServices { get => _WIOATrainingServices; set => SetProperty(ref _WIOATrainingServices, value); }

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
        public void Load(IProgramParticipationWIOA model)
        {
            IsBusy = true;
            Id = model.Id;
            PersonProgramParticipationId = model.PersonProgramParticipationId;
            WIOACareerServices = model.WIOACareerServices;
            WIOATrainingServices = model.WIOATrainingServices;
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
