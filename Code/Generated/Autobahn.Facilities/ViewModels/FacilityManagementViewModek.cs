//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   FacilityManagementViewModel.cs
//**********************************************************

using Prism.Mvvm;
using Autobahn.Common.Interfaces;
using Autobahn.Autobahn.Facilities.Interfaces;

namespace Autobahn.Facilities.ViewModels
{
     /// <summary>
     /// The FacilityManagementViewModel
     /// </summary>
    public partial class FacilityManagementViewModel : BindableBase, IFacilityManagement
    {
#region "Backing Fields"
        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

#endregion

#region Properties
        /// <summary>
        /// Reference to a required instance of the <see cref="FacilityId"/> model
        /// </summary>
        public Guid FacilityId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingCharterSchoolRealtyAccessTypeId"/> model
        /// </summary>
        public Guid? RefBuildingCharterSchoolRealtyAccessTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingCleaningStandardTypeId"/> model
        /// </summary>
        public Guid? RefBuildingCleaningStandardTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFacilityCapitalProgramMgmtTypeId"/> model
        /// </summary>
        public Guid? RefFacilityCapitalProgramMgmtTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFacilityComplianceAgencyTypeId"/> model
        /// </summary>
        public Guid? RefFacilityComplianceAgencyTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFacilityOperationsMgmtTypeId"/> model
        /// </summary>
        public Guid? RefFacilityOperationsMgmtTypeId { get; set; }

        public System.DateTime? RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        public System.DateTime? RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatusId"/> model
        /// </summary>
        public Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollectionId"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

#endregion


        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(IFacilityManagement model)
        {
            IsBusy = true;
            Id = model.Id;
            FacilityId = model.FacilityId;
            RefBuildingCharterSchoolRealtyAccessTypeId = model.RefBuildingCharterSchoolRealtyAccessTypeId;
            RefBuildingCleaningStandardTypeId = model.RefBuildingCleaningStandardTypeId;
            RefFacilityCapitalProgramMgmtTypeId = model.RefFacilityCapitalProgramMgmtTypeId;
            RefFacilityComplianceAgencyTypeId = model.RefFacilityComplianceAgencyTypeId;
            RefFacilityOperationsMgmtTypeId = model.RefFacilityOperationsMgmtTypeId;
            RecordStartDateTime = model.RecordStartDateTime;
            RecordEndDateTime = model.RecordEndDateTime;
            RecordStatusId = model.RecordStatusId;
            DataCollectionId = model.DataCollectionId;
            IsChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
