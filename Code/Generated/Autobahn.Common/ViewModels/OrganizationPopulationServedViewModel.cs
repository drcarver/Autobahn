//**********************************************************
//* DomainName: Common Models
//* FileName:   OrganizationPopulationServedViewModel.cs
//**********************************************************

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The OrganizationPopulationServedViewModel
     /// </summary>
    public partial class OrganizationPopulationServedViewModel : ViewModelBase, Interfaces.IOrganizationPopulationServed
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from OrganizationPopulationServed";

        // member variable for the OldestAgeServed property
        private  _OldestAgeServed;

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        // member variable for the RefPopulationServedId property
        private  _RefPopulationServedId;

        // member variable for the YoungestAgeServed property
        private Guid? _YoungestAgeServed;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// </summary>
        public  OldestAgeServed { get => _OldestAgeServed; set => SetProperty(ref _OldestAgeServed, value); }

        /// <summary>
        /// </summary>
        public  RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// </summary>
        public  RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPopulationServed"/> model
        /// </summary>
        public  RefPopulationServedId { get => _RefPopulationServedId; set => SetProperty(ref _RefPopulationServedId, value); }

        /// <summary>
        /// </summary>
        public Guid? YoungestAgeServed { get => _YoungestAgeServed; set => SetProperty(ref _YoungestAgeServed, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IOrganizationPopulationServed model)
        {
            IsBusy = true;
            Id = model.Id;
            OldestAgeServed = model.OldestAgeServed; // 
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            RefPopulationServedId = model.RefPopulationServedId; // 
            YoungestAgeServed = model.YoungestAgeServed; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
