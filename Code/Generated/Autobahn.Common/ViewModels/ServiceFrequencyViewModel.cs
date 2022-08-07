//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   ServiceFrequencyViewModel.cs
//**********************************************************


namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The ServiceFrequencyViewModel
     /// </summary>
    public partial class ServiceFrequencyViewModel : ViewModelBase, Interfaces.IServiceFrequencyViewModel
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from ServiceFrequency";

        // member variable for the ServicePlanId property
        private Guid _ServicePlanId;

        // member variable for the DurationInMinutes property
        private System.Int32? _DurationInMinutes;

        // member variable for the FrequencyLength property
        private System.Int32? _FrequencyLength;

        // member variable for the InstancesPerCycle property
        private System.Int32? _InstancesPerCycle;

        // member variable for the RefFrequencyUnitId property
        private Guid? _RefFrequencyUnitId;

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
        /// The title of the ServiceFrequencyViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="ServicePlanId"/> model
        /// </summary>
        public Guid ServicePlanId { get => _ServicePlanId; set => SetProperty(ref _ServicePlanId, value); }

        public System.Int32? DurationInMinutes { get => _DurationInMinutes; set => SetProperty(ref _DurationInMinutes, value); }

        public System.Int32? FrequencyLength { get => _FrequencyLength; set => SetProperty(ref _FrequencyLength, value); }

        public System.Int32? InstancesPerCycle { get => _InstancesPerCycle; set => SetProperty(ref _InstancesPerCycle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFrequencyUnitId"/> model
        /// </summary>
        public Guid? RefFrequencyUnitId { get => _RefFrequencyUnitId; set => SetProperty(ref _RefFrequencyUnitId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IServiceFrequency model)
        {
            IsBusy = true;
            Id = model.Id;
            ServicePlanId = model.ServicePlanId;
            DurationInMinutes = model.DurationInMinutes;
            FrequencyLength = model.FrequencyLength;
            InstancesPerCycle = model.InstancesPerCycle;
            RefFrequencyUnitId = model.RefFrequencyUnitId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
