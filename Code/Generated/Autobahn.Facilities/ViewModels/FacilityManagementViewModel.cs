//**********************************************************
//* DomainName: Facilities
//* FileName:   FacilityManagementViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

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

        // member variable for the FacilityId property
        private Guid _FacilityId;

        // member variable for the RefBuildingCharterSchoolRealtyAccessTypeId property
        private Guid? _RefBuildingCharterSchoolRealtyAccessTypeId;

        // member variable for the RefBuildingCleaningStandardTypeId property
        private Guid? _RefBuildingCleaningStandardTypeId;

        // member variable for the RefFacilityCapitalProgramMgmtTypeId property
        private Guid? _RefFacilityCapitalProgramMgmtTypeId;

        // member variable for the RefFacilityComplianceAgencyTypeId property
        private Guid? _RefFacilityComplianceAgencyTypeId;

        // member variable for the RefFacilityOperationsMgmtTypeId property
        private Guid? _RefFacilityOperationsMgmtTypeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the FacilityManagementViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="Facility"/> model
        /// </summary>
        public Guid FacilityId { get => _FacilityId; set => SetProperty(ref _FacilityId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingCharterSchoolRealtyAccessType"/> model
        /// </summary>
        public Guid? RefBuildingCharterSchoolRealtyAccessTypeId { get => _RefBuildingCharterSchoolRealtyAccessTypeId; set => SetProperty(ref _RefBuildingCharterSchoolRealtyAccessTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingCleaningStandardType"/> model
        /// </summary>
        public Guid? RefBuildingCleaningStandardTypeId { get => _RefBuildingCleaningStandardTypeId; set => SetProperty(ref _RefBuildingCleaningStandardTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFacilityCapitalProgramMgmtType"/> model
        /// </summary>
        public Guid? RefFacilityCapitalProgramMgmtTypeId { get => _RefFacilityCapitalProgramMgmtTypeId; set => SetProperty(ref _RefFacilityCapitalProgramMgmtTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFacilityComplianceAgencyType"/> model
        /// </summary>
        public Guid? RefFacilityComplianceAgencyTypeId { get => _RefFacilityComplianceAgencyTypeId; set => SetProperty(ref _RefFacilityComplianceAgencyTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFacilityOperationsMgmtType"/> model
        /// </summary>
        public Guid? RefFacilityOperationsMgmtTypeId { get => _RefFacilityOperationsMgmtTypeId; set => SetProperty(ref _RefFacilityOperationsMgmtTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IFacilityManagement model)
        {
            IsBusy = true;
            Id = model.Id;
            FacilityId = model.FacilityId;
            RefBuildingCharterSchoolRealtyAccessTypeId = model.RefBuildingCharterSchoolRealtyAccessTypeId;
            RefBuildingCleaningStandardTypeId = model.RefBuildingCleaningStandardTypeId;
            RefFacilityCapitalProgramMgmtTypeId = model.RefFacilityCapitalProgramMgmtTypeId;
            RefFacilityComplianceAgencyTypeId = model.RefFacilityComplianceAgencyTypeId;
            RefFacilityOperationsMgmtTypeId = model.RefFacilityOperationsMgmtTypeId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
