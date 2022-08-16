//**********************************************************
//* DomainName: Facilities
//* FileName:   BuildingSystemComponentServiceViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Facilities.ViewModels
{
     /// <summary>
     /// The BuildingSystemComponentServiceViewModel
     /// </summary>
    public partial class BuildingSystemComponentServiceViewModel : ViewModelBase, Interfaces.IBuildingSystemComponentService
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from BuildingSystemComponentService";

        // member variable for the ComponentOrFixtureScheduledServicedDate property
        private  _ComponentOrFixtureScheduledServicedDate;

        // member variable for the ComponentOrFixtureServicedDate property
        private Guid? _ComponentOrFixtureServicedDate;

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// </summary>
        public  ComponentOrFixtureScheduledServicedDate { get => _ComponentOrFixtureScheduledServicedDate; set => SetProperty(ref _ComponentOrFixtureScheduledServicedDate, value); }

        /// <summary>
        /// </summary>
        public Guid? ComponentOrFixtureServicedDate { get => _ComponentOrFixtureServicedDate; set => SetProperty(ref _ComponentOrFixtureServicedDate, value); }

        /// <summary>
        /// </summary>
        public  RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// </summary>
        public  RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IBuildingSystemComponentService model)
        {
            IsBusy = true;
            Id = model.Id;
            ComponentOrFixtureScheduledServicedDate = model.ComponentOrFixtureScheduledServicedDate; // 
            ComponentOrFixtureServicedDate = model.ComponentOrFixtureServicedDate; // 
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
