//**********************************************************
//* DomainName: Facilities
//* FileName:   FacilityManagementViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Facilities.ViewModels
{
     /// <summary>
     /// The FacilityManagementViewModel
     /// </summary>
    public partial class FacilityManagementViewModel : ViewModelBase, Interfaces.IFacilityManagement
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from FacilityManagement";

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        // member variable for the RefBuildingCharterSchoolRealtyAccessTypeId property
        private Guid? _RefBuildingCharterSchoolRealtyAccessTypeId;

        // member variable for the RefBuildingCleaningStandardTypeId property
        private  _RefBuildingCleaningStandardTypeId;

        // member variable for the RefFacilityCapitalProgramMgmtTypeId property
        private  _RefFacilityCapitalProgramMgmtTypeId;

        // member variable for the RefFacilityComplianceAgencyTypeId property
        private  _RefFacilityComplianceAgencyTypeId;

        // member variable for the RefFacilityOperationsMgmtTypeId property
        private  _RefFacilityOperationsMgmtTypeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// </summary>
        public  RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// </summary>
        public  RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingCharterSchoolRealtyAccessType"/> model
        /// </summary>
        public Guid? RefBuildingCharterSchoolRealtyAccessTypeId { get => _RefBuildingCharterSchoolRealtyAccessTypeId; set => SetProperty(ref _RefBuildingCharterSchoolRealtyAccessTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingCleaningStandardType"/> model
        /// </summary>
        public  RefBuildingCleaningStandardTypeId { get => _RefBuildingCleaningStandardTypeId; set => SetProperty(ref _RefBuildingCleaningStandardTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFacilityCapitalProgramMgmtType"/> model
        /// </summary>
        public  RefFacilityCapitalProgramMgmtTypeId { get => _RefFacilityCapitalProgramMgmtTypeId; set => SetProperty(ref _RefFacilityCapitalProgramMgmtTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFacilityComplianceAgencyType"/> model
        /// </summary>
        public  RefFacilityComplianceAgencyTypeId { get => _RefFacilityComplianceAgencyTypeId; set => SetProperty(ref _RefFacilityComplianceAgencyTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFacilityOperationsMgmtType"/> model
        /// </summary>
        public  RefFacilityOperationsMgmtTypeId { get => _RefFacilityOperationsMgmtTypeId; set => SetProperty(ref _RefFacilityOperationsMgmtTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IFacilityManagement model)
        {
            IsBusy = true;
            Id = model.Id;
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            RefBuildingCharterSchoolRealtyAccessTypeId = model.RefBuildingCharterSchoolRealtyAccessTypeId; // 
            RefBuildingCleaningStandardTypeId = model.RefBuildingCleaningStandardTypeId; // 
            RefFacilityCapitalProgramMgmtTypeId = model.RefFacilityCapitalProgramMgmtTypeId; // 
            RefFacilityComplianceAgencyTypeId = model.RefFacilityComplianceAgencyTypeId; // 
            RefFacilityOperationsMgmtTypeId = model.RefFacilityOperationsMgmtTypeId; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
