//**********************************************************
//* DomainName: Facilities
//* FileName:   FacilityComplianceViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Facilities.ViewModels
{
     /// <summary>
     /// The FacilityComplianceViewModel
     /// </summary>
    public partial class FacilityComplianceViewModel : ViewModelBase, Interfaces.IFacilityCompliance
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from FacilityCompliance";

        // member variable for the ComponentOrFixtureCheckDate property
        private  _ComponentOrFixtureCheckDate;

        // member variable for the FacilityComplianceDeterminationDate property
        private  _FacilityComplianceDeterminationDate;

        // member variable for the FacilityComplianceName property
        private  _FacilityComplianceName;

        // member variable for the FacilityComponentDeficiencyDescription property
        private  _FacilityComponentDeficiencyDescription;

        // member variable for the FacilityEstimatedCostToEliminateDeferredMaint property
        private  _FacilityEstimatedCostToEliminateDeferredMaint;

        // member variable for the FacilityInspectionScoreResultDescription property
        private  _FacilityInspectionScoreResultDescription;

        // member variable for the FacilityInspectionViolationDescription property
        private  _FacilityInspectionViolationDescription;

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        // member variable for the RefFacilityComplianceStatusId property
        private Guid? _RefFacilityComplianceStatusId;

        // member variable for the RefFacilityMaintStandardTypeId property
        private  _RefFacilityMaintStandardTypeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// </summary>
        public  ComponentOrFixtureCheckDate { get => _ComponentOrFixtureCheckDate; set => SetProperty(ref _ComponentOrFixtureCheckDate, value); }

        /// <summary>
        /// </summary>
        public  FacilityComplianceDeterminationDate { get => _FacilityComplianceDeterminationDate; set => SetProperty(ref _FacilityComplianceDeterminationDate, value); }

        /// <summary>
        /// </summary>
        public  FacilityComplianceName { get => _FacilityComplianceName; set => SetProperty(ref _FacilityComplianceName, value); }

        /// <summary>
        /// </summary>
        public  FacilityComponentDeficiencyDescription { get => _FacilityComponentDeficiencyDescription; set => SetProperty(ref _FacilityComponentDeficiencyDescription, value); }

        /// <summary>
        /// </summary>
        public  FacilityEstimatedCostToEliminateDeferredMaint { get => _FacilityEstimatedCostToEliminateDeferredMaint; set => SetProperty(ref _FacilityEstimatedCostToEliminateDeferredMaint, value); }

        /// <summary>
        /// </summary>
        public  FacilityInspectionScoreResultDescription { get => _FacilityInspectionScoreResultDescription; set => SetProperty(ref _FacilityInspectionScoreResultDescription, value); }

        /// <summary>
        /// </summary>
        public  FacilityInspectionViolationDescription { get => _FacilityInspectionViolationDescription; set => SetProperty(ref _FacilityInspectionViolationDescription, value); }

        /// <summary>
        /// </summary>
        public  RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// </summary>
        public  RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFacilityComplianceStatus"/> model
        /// </summary>
        public Guid? RefFacilityComplianceStatusId { get => _RefFacilityComplianceStatusId; set => SetProperty(ref _RefFacilityComplianceStatusId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFacilityMaintStandardType"/> model
        /// </summary>
        public  RefFacilityMaintStandardTypeId { get => _RefFacilityMaintStandardTypeId; set => SetProperty(ref _RefFacilityMaintStandardTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IFacilityCompliance model)
        {
            IsBusy = true;
            Id = model.Id;
            ComponentOrFixtureCheckDate = model.ComponentOrFixtureCheckDate; // 
            FacilityComplianceDeterminationDate = model.FacilityComplianceDeterminationDate; // 
            FacilityComplianceName = model.FacilityComplianceName; // 
            FacilityComponentDeficiencyDescription = model.FacilityComponentDeficiencyDescription; // 
            FacilityEstimatedCostToEliminateDeferredMaint = model.FacilityEstimatedCostToEliminateDeferredMaint; // 
            FacilityInspectionScoreResultDescription = model.FacilityInspectionScoreResultDescription; // 
            FacilityInspectionViolationDescription = model.FacilityInspectionViolationDescription; // 
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            RefFacilityComplianceStatusId = model.RefFacilityComplianceStatusId; // 
            RefFacilityMaintStandardTypeId = model.RefFacilityMaintStandardTypeId; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
