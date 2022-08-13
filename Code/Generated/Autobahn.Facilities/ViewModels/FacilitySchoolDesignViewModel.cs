//**********************************************************
//* DomainName: Facilities
//* FileName:   FacilitySchoolDesignViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;
using CommunityToolkit.Maui;

namespace Autobahn.Facilities.ViewModels
{
     /// <summary>
     /// The FacilitySchoolDesignViewModel
     /// </summary>
    public partial class FacilitySchoolDesignViewModel : ViewModelBase, Interfaces.IFacilitySchoolDesign
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from FacilitySchoolDesign";

        // member variable for the FacilityDesignId property
        private Guid _FacilityDesignId;

        // member variable for the RefBuildingSchoolDesignTypeId property
        private Guid _RefBuildingSchoolDesignTypeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the FacilitySchoolDesignViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="FacilityDesign"/> model
        /// </summary>
        public Guid FacilityDesignId { get => _FacilityDesignId; set => SetProperty(ref _FacilityDesignId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingSchoolDesignType"/> model
        /// </summary>
        public Guid RefBuildingSchoolDesignTypeId { get => _RefBuildingSchoolDesignTypeId; set => SetProperty(ref _RefBuildingSchoolDesignTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IFacilitySchoolDesign model)
        {
            IsBusy = true;
            Id = model.Id;
            FacilityDesignId = model.FacilityDesignId;
            RefBuildingSchoolDesignTypeId = model.RefBuildingSchoolDesignTypeId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
