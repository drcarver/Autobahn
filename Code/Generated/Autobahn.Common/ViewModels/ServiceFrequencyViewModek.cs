//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   ServiceFrequencyViewModel.cs
//**********************************************************

using Prism.Mvvm;
using Autobahn.Common.Interfaces;
using Autobahn.Autobahn.Common.Interfaces;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The ServiceFrequencyViewModel
     /// </summary>
    public partial class ServiceFrequencyViewModel : BindableBase, IServiceFrequency
    {
#region "Backing Fields"
        // member variable for the DurationInMinutes property
        private System.Int32? _DurationInMinutes;

        // member variable for the FrequencyLength property
        private System.Int32? _FrequencyLength;

        // member variable for the InstancesPerCycle property
        private System.Int32? _InstancesPerCycle;

        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

#endregion

#region Properties
        /// <summary>
        /// Reference to a required instance of the <see cref="ServicePlanId"/> model
        /// </summary>
        public Guid ServicePlanId { get; set; }

        public System.Int32? DurationInMinutes { get => _DurationInMinutes; set => SetProperty(ref _DurationInMinutes, value); }

        public System.Int32? FrequencyLength { get => _FrequencyLength; set => SetProperty(ref _FrequencyLength, value); }

        public System.Int32? InstancesPerCycle { get => _InstancesPerCycle; set => SetProperty(ref _InstancesPerCycle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFrequencyUnitId"/> model
        /// </summary>
        public Guid? RefFrequencyUnitId { get; set; }

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
        public void Load(IServiceFrequency model)
        {
            IsBusy = true;
            Id = model.Id;
            ServicePlanId = model.ServicePlanId;
            DurationInMinutes = model.DurationInMinutes;
            FrequencyLength = model.FrequencyLength;
            InstancesPerCycle = model.InstancesPerCycle;
            RefFrequencyUnitId = model.RefFrequencyUnitId;
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
