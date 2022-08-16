//**********************************************************
//* DomainName: Facilities
//* FileName:   FacilityManagementPlanViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Facilities.ViewModels
{
     /// <summary>
     /// The FacilityManagementPlanViewModel
     /// </summary>
    public partial class FacilityManagementPlanViewModel : ViewModelBase, Interfaces.IFacilityManagementPlan
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from FacilityManagementPlan";

        // member variable for the FacilitiesPlanDescription property
        private  _FacilitiesPlanDescription;

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        // member variable for the RefFacilitiesMgmtEmergencyTypeId property
        private Guid? _RefFacilitiesMgmtEmergencyTypeId;

        // member variable for the RefFacilitiesPlanTypeId property
        private  _RefFacilitiesPlanTypeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// </summary>
        public  FacilitiesPlanDescription { get => _FacilitiesPlanDescription; set => SetProperty(ref _FacilitiesPlanDescription, value); }

        /// <summary>
        /// </summary>
        public  RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// </summary>
        public  RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFacilitiesMgmtEmergencyType"/> model
        /// </summary>
        public Guid? RefFacilitiesMgmtEmergencyTypeId { get => _RefFacilitiesMgmtEmergencyTypeId; set => SetProperty(ref _RefFacilitiesMgmtEmergencyTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFacilitiesPlanType"/> model
        /// </summary>
        public  RefFacilitiesPlanTypeId { get => _RefFacilitiesPlanTypeId; set => SetProperty(ref _RefFacilitiesPlanTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IFacilityManagementPlan model)
        {
            IsBusy = true;
            Id = model.Id;
            FacilitiesPlanDescription = model.FacilitiesPlanDescription; // 
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            RefFacilitiesMgmtEmergencyTypeId = model.RefFacilitiesMgmtEmergencyTypeId; // 
            RefFacilitiesPlanTypeId = model.RefFacilitiesPlanTypeId; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
