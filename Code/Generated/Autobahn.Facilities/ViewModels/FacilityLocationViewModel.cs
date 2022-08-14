//**********************************************************
//* DomainName: Facilities
//* FileName:   FacilityLocationViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

namespace Autobahn.Facilities.ViewModels
{
     /// <summary>
     /// The FacilityLocationViewModel
     /// </summary>
    public partial class FacilityLocationViewModel : ViewModelBase, Interfaces.IFacilityLocation
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from FacilityLocation";

        // member variable for the FacilityId property
        private Guid _FacilityId;

        // member variable for the LocationId property
        private Guid _LocationId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the FacilityLocationViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="Facility"/> model
        /// </summary>
        public Guid FacilityId { get => _FacilityId; set => SetProperty(ref _FacilityId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="Location"/> model
        /// </summary>
        public Guid LocationId { get => _LocationId; set => SetProperty(ref _LocationId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IFacilityLocation model)
        {
            IsBusy = true;
            Id = model.Id;
            FacilityId = model.FacilityId;
            LocationId = model.LocationId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
