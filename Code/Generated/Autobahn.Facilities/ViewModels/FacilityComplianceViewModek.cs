//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   FacilityComplianceViewModel.cs
//**********************************************************

using Prism.Mvvm;
using Autobahn.Common.Interfaces;
using Autobahn.Autobahn.Facilities.Interfaces;

namespace Autobahn.Facilities.ViewModels
{
     /// <summary>
     /// The FacilityComplianceViewModel
     /// </summary>
    public partial class FacilityComplianceViewModel : BindableBase, IFacilityCompliance
    {
#region "Backing Fields"
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

        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

#endregion

#region Properties
        /// <summary>
        /// Reference to an optional instance of the <see cref="FacilityMandateId"/> model
        /// </summary>
        public Guid? FacilityMandateId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="BuildingSystemComponentId"/> model
        /// </summary>
        public Guid? BuildingSystemComponentId { get; set; }

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
        public Guid? RefFacilityComplianceStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFacilityMaintStandardTypeId"/> model
        /// </summary>
        public Guid? RefFacilityMaintStandardTypeId { get; set; }

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
        public void Load(IFacilityCompliance model)
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
