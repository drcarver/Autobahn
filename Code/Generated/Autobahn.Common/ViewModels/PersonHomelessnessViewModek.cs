//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   PersonHomelessnessViewModel.cs
//**********************************************************

using Prism.Mvvm;
using Autobahn.Common.Interfaces;
using Autobahn.Autobahn.Common.Interfaces;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The PersonHomelessnessViewModel
     /// </summary>
    public partial class PersonHomelessnessViewModel : BindableBase, IPersonHomelessness
    {
#region "Backing Fields"
        // member variable for the HomelessnessStatus property
        private System.Boolean _HomelessnessStatus;

        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

#endregion

#region Properties
        /// <summary>
        /// Reference to a required instance of the <see cref="PersonId"/> model
        /// </summary>
        public Guid PersonId { get; set; }

        public System.Boolean HomelessnessStatus  { get => _HomelessnessStatus; set => SetProperty(ref _HomelessnessStatus, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="RefHomelessNighttimeResidenceId"/> model
        /// </summary>
        public Guid RefHomelessNighttimeResidenceId { get; set; }

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
        public void Load(IPersonHomelessness model)
        {
            IsBusy = true;
            Id = model.Id;
            PersonId = model.PersonId;
            HomelessnessStatus = model.HomelessnessStatus;
            RefHomelessNighttimeResidenceId = model.RefHomelessNighttimeResidenceId;
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
