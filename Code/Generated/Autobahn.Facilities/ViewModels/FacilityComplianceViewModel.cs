//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   FacilityComplianceViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

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

        // member variable for the FacilityMandateId property
        private Guid? _FacilityMandateId;

        // member variable for the BuildingSystemComponentId property
        private Guid? _BuildingSystemComponentId;

        // member variable for the FacilityComplianceName property
        private System.String _FacilityComplianceName;

        // member variable for the FacilityComplianceDeterminationDate property
        private System.DateTime? _FacilityComplianceDeterminationDate;

        // member variable for the ComponentOrFixtureCheckDate property
        private System.DateTime? _ComponentOrFixtureCheckDate;

        // member variable for the FacilityComponentDeficiencyDescription property
        private System.String _FacilityComponentDeficiencyDescription;

        // member variable for the FacilityEstimatedCostToEliminateDeferredMaint property
        private System.Decimal? _FacilityEstimatedCostToEliminateDeferredMaint;

        // member variable for the FacilityInspectionScoreResultDescription property
        private System.String _FacilityInspectionScoreResultDescription;

        // member variable for the FacilityInspectionViolationDescription property
        private System.String _FacilityInspectionViolationDescription;

        // member variable for the RefFacilityComplianceStatusId property
        private Guid? _RefFacilityComplianceStatusId;

        // member variable for the RefFacilityMaintStandardTypeId property
        private Guid? _RefFacilityMaintStandardTypeId;

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
        /// The title of the FacilityComplianceViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="FacilityMandateId"/> model
        /// </summary>
        public Guid? FacilityMandateId { get => _FacilityMandateId; set => SetProperty(ref _FacilityMandateId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="BuildingSystemComponentId"/> model
        /// </summary>
        public Guid? BuildingSystemComponentId { get => _BuildingSystemComponentId; set => SetProperty(ref _BuildingSystemComponentId, value); }

        public System.String FacilityComplianceName  { get => _FacilityComplianceName; set => SetProperty(ref _FacilityComplianceName, value); }

        public System.DateTime? FacilityComplianceDeterminationDate { get => _FacilityComplianceDeterminationDate; set => SetProperty(ref _FacilityComplianceDeterminationDate, value); }

        public System.DateTime? ComponentOrFixtureCheckDate { get => _ComponentOrFixtureCheckDate; set => SetProperty(ref _ComponentOrFixtureCheckDate, value); }

        public System.String FacilityComponentDeficiencyDescription  { get => _FacilityComponentDeficiencyDescription; set => SetProperty(ref _FacilityComponentDeficiencyDescription, value); }

        public System.Decimal? FacilityEstimatedCostToEliminateDeferredMaint { get => _FacilityEstimatedCostToEliminateDeferredMaint; set => SetProperty(ref _FacilityEstimatedCostToEliminateDeferredMaint, value); }

        public System.String FacilityInspectionScoreResultDescription  { get => _FacilityInspectionScoreResultDescription; set => SetProperty(ref _FacilityInspectionScoreResultDescription, value); }

        public System.String FacilityInspectionViolationDescription  { get => _FacilityInspectionViolationDescription; set => SetProperty(ref _FacilityInspectionViolationDescription, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFacilityComplianceStatusId"/> model
        /// </summary>
        public Guid? RefFacilityComplianceStatusId { get => _RefFacilityComplianceStatusId; set => SetProperty(ref _RefFacilityComplianceStatusId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFacilityMaintStandardTypeId"/> model
        /// </summary>
        public Guid? RefFacilityMaintStandardTypeId { get => _RefFacilityMaintStandardTypeId; set => SetProperty(ref _RefFacilityMaintStandardTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IFacilityCompliance model)
        {
            IsBusy = true;
            Id = model.Id;
            FacilityMandateId = model.FacilityMandateId;
            BuildingSystemComponentId = model.BuildingSystemComponentId;
            FacilityComplianceName = model.FacilityComplianceName;
            FacilityComplianceDeterminationDate = model.FacilityComplianceDeterminationDate;
            ComponentOrFixtureCheckDate = model.ComponentOrFixtureCheckDate;
            FacilityComponentDeficiencyDescription = model.FacilityComponentDeficiencyDescription;
            FacilityEstimatedCostToEliminateDeferredMaint = model.FacilityEstimatedCostToEliminateDeferredMaint;
            FacilityInspectionScoreResultDescription = model.FacilityInspectionScoreResultDescription;
            FacilityInspectionViolationDescription = model.FacilityInspectionViolationDescription;
            RefFacilityComplianceStatusId = model.RefFacilityComplianceStatusId;
            RefFacilityMaintStandardTypeId = model.RefFacilityMaintStandardTypeId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
