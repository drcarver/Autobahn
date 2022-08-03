//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   PersonStatusViewModel.cs
//**********************************************************

using Prism.Mvvm;
using Autobahn.Common.Interfaces;
using Autobahn.Autobahn.Common.Interfaces;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The PersonStatusViewModel
     /// </summary>
    public partial class PersonStatusViewModel : BindableBase, IPersonStatus
    {
#region "Backing Fields"
        // member variable for the StatusValue property
        private System.Boolean _StatusValue;

        // member variable for the StatusStartDate property
        private System.DateTime? _StatusStartDate;

        // member variable for the StatusEndDate property
        private System.DateTime? _StatusEndDate;

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

        /// <summary>
        /// Reference to a required instance of the <see cref="RefPersonStatusTypeId"/> model
        /// </summary>
        public Guid RefPersonStatusTypeId { get; set; }

        public System.Boolean StatusValue  { get => _StatusValue; set => SetProperty(ref _StatusValue, value); }

        public System.DateTime? StatusStartDate { get => _StatusStartDate; set => SetProperty(ref _StatusStartDate, value); }

        public System.DateTime? StatusEndDate { get => _StatusEndDate; set => SetProperty(ref _StatusEndDate, value); }

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
        public void Load(IPersonStatus model)
        {
            IsBusy = true;
            Id = model.Id;
            PersonId = model.PersonId;
            RefPersonStatusTypeId = model.RefPersonStatusTypeId;
            StatusValue = model.StatusValue;
            StatusStartDate = model.StatusStartDate;
            StatusEndDate = model.StatusEndDate;
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
