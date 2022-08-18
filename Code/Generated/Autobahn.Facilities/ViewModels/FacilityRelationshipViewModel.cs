//**********************************************************
//* DomainName: Facilities
//* FileName:   FacilityRelationshipViewModel.cs
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Facilities.ViewModels
{
     /// <summary>
     /// The FacilityRelationship View Model
     /// </summary>
    public partial class FacilityRelationshipViewModel : ViewModelBase, Interfaces.IFacilityRelationship
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from FacilityRelationship";

        // member variable for the FacilityId property
        private Guid _FacilityId;

        // member variable for the Parent_FacilityId property
        private Guid _Parent_FacilityId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IFacility"/> model
        /// </summary>
        public Guid FacilityId { get => _FacilityId; set => SetProperty(ref _FacilityId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IParent_Facility"/> model
        /// </summary>
        public Guid Parent_FacilityId { get => _Parent_FacilityId; set => SetProperty(ref _Parent_FacilityId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IFacilityRelationship model)
        {
            IsBusy = true;
            Id = model.Id;
            FacilityId = model.FacilityId; // 
            Parent_FacilityId = model.Parent_FacilityId; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
