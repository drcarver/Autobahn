//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   ServiceFrequencyViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Invalid.ViewModels
{
     /// <summary>
     /// The ServiceFrequencyViewModel
     /// </summary>
    public partial class ServiceFrequencyViewModel : ViewModelBase, Interfaces.IServiceFrequency
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from ServiceFrequency";

        // member variable for the DurationInMinutes property
        private  _DurationInMinutes;

        // member variable for the FrequencyLength property
        private  _FrequencyLength;

        // member variable for the InstancesPerCycle property
        private  _InstancesPerCycle;

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        // member variable for the RefFrequencyUnitId property
        private Guid? _RefFrequencyUnitId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// </summary>
        public  DurationInMinutes { get => _DurationInMinutes; set => SetProperty(ref _DurationInMinutes, value); }

        /// <summary>
        /// </summary>
        public  FrequencyLength { get => _FrequencyLength; set => SetProperty(ref _FrequencyLength, value); }

        /// <summary>
        /// </summary>
        public  InstancesPerCycle { get => _InstancesPerCycle; set => SetProperty(ref _InstancesPerCycle, value); }

        /// <summary>
        /// </summary>
        public  RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// </summary>
        public  RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFrequencyUnit"/> model
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
            DurationInMinutes = model.DurationInMinutes; // 
            FrequencyLength = model.FrequencyLength; // 
            InstancesPerCycle = model.InstancesPerCycle; // 
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            RefFrequencyUnitId = model.RefFrequencyUnitId; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
