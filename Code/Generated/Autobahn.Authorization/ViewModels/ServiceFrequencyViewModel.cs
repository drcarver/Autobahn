//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   ServiceFrequencyViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;
using CommunityToolkit.Maui;

namespace Autobahn.Authorization.ViewModels
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
        private System.Int32? _DurationInMinutes;

        // member variable for the FrequencyLength property
        private System.Int32? _FrequencyLength;

        // member variable for the InstancesPerCycle property
        private System.Int32? _InstancesPerCycle;

        // member variable for the RefFrequencyUnitId property
        private Guid? _RefFrequencyUnitId;

        // member variable for the ServicePlanId property
        private Guid _ServicePlanId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the ServiceFrequencyViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// The unit of time by which a cycle is defined.
        /// </summary>
        public System.Int32? DurationInMinutes { get => _DurationInMinutes; set => SetProperty(ref _DurationInMinutes, value); }

        /// <summary>
        /// The unit of time by which a cycle is defined.
        /// </summary>
        public System.Int32? FrequencyLength { get => _FrequencyLength; set => SetProperty(ref _FrequencyLength, value); }

        /// <summary>
        /// The unit of time by which a cycle is defined.
        /// </summary>
        public System.Int32? InstancesPerCycle { get => _InstancesPerCycle; set => SetProperty(ref _InstancesPerCycle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFrequencyUnit"/> model
        /// </summary>
        public Guid? RefFrequencyUnitId { get => _RefFrequencyUnitId; set => SetProperty(ref _RefFrequencyUnitId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="ServicePlan"/> model
        /// </summary>
        public Guid ServicePlanId { get => _ServicePlanId; set => SetProperty(ref _ServicePlanId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IServiceFrequency model)
        {
            IsBusy = true;
            Id = model.Id;
            DurationInMinutes = model.DurationInMinutes;
            FrequencyLength = model.FrequencyLength;
            InstancesPerCycle = model.InstancesPerCycle;
            RefFrequencyUnitId = model.RefFrequencyUnitId;
            ServicePlanId = model.ServicePlanId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
