//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   FacilitySchoolDesignViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

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
        /// The title of the FacilitySchoolDesignViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="FacilityDesignId"/> model
        /// </summary>
        public Guid FacilityDesignId { get => _FacilityDesignId; set => SetProperty(ref _FacilityDesignId, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="RefBuildingSchoolDesignTypeId"/> model
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
