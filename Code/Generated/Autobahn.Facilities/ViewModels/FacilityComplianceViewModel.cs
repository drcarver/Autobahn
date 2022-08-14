//**********************************************************
//* DomainName: Facilities
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

        // member variable for the BuildingSystemComponentId property
        private Guid? _BuildingSystemComponentId;

        // member variable for the ComponentOrFixtureCheckDate property
        private System.DateTime? _ComponentOrFixtureCheckDate;

        // member variable for the FacilityComplianceDeterminationDate property
        private System.DateTime? _FacilityComplianceDeterminationDate;

        // member variable for the FacilityComplianceName property
        private System.String _FacilityComplianceName;

        // member variable for the FacilityComponentDeficiencyDescription property
        private System.String _FacilityComponentDeficiencyDescription;

        // member variable for the FacilityEstimatedCostToEliminateDeferredMaint property
        private System.Decimal? _FacilityEstimatedCostToEliminateDeferredMaint;

        // member variable for the FacilityInspectionScoreResultDescription property
        private System.String _FacilityInspectionScoreResultDescription;

        // member variable for the FacilityInspectionViolationDescription property
        private System.String _FacilityInspectionViolationDescription;

        // member variable for the FacilityMandateId property
        private Guid? _FacilityMandateId;

        // member variable for the RefFacilityComplianceStatusId property
        private Guid? _RefFacilityComplianceStatusId;

        // member variable for the RefFacilityMaintStandardTypeId property
        private Guid? _RefFacilityMaintStandardTypeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the FacilityComplianceViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="BuildingSystemComponent"/> model
        /// </summary>
        public Guid? BuildingSystemComponentId { get => _BuildingSystemComponentId; set => SetProperty(ref _BuildingSystemComponentId, value); }

        /// <summary>
        /// An indication of whether the school, building, site, system, component, equipment, vehicle, or fixture conforms to the requirements or standards specified in federal, state, or local standards or codes or other officially required guidelines or regulations.
        /// </summary>
        public System.DateTime? ComponentOrFixtureCheckDate { get => _ComponentOrFixtureCheckDate; set => SetProperty(ref _ComponentOrFixtureCheckDate, value); }

        /// <summary>
        /// An indication of whether the school, building, site, system, component, equipment, vehicle, or fixture conforms to the requirements or standards specified in federal, state, or local standards or codes or other officially required guidelines or regulations.
        /// </summary>
        public System.DateTime? FacilityComplianceDeterminationDate { get => _FacilityComplianceDeterminationDate; set => SetProperty(ref _FacilityComplianceDeterminationDate, value); }

        /// <summary>
        /// An indication of whether the school, building, site, system, component, equipment, vehicle, or fixture conforms to the requirements or standards specified in federal, state, or local standards or codes or other officially required guidelines or regulations.
        /// </summary>
        public System.String FacilityComplianceName { get => _FacilityComplianceName; set => SetProperty(ref _FacilityComplianceName, value); }

        /// <summary>
        /// An indication of whether the school, building, site, system, component, equipment, vehicle, or fixture conforms to the requirements or standards specified in federal, state, or local standards or codes or other officially required guidelines or regulations.
        /// </summary>
        public System.String FacilityComponentDeficiencyDescription { get => _FacilityComponentDeficiencyDescription; set => SetProperty(ref _FacilityComponentDeficiencyDescription, value); }

        /// <summary>
        /// An indication of whether the school, building, site, system, component, equipment, vehicle, or fixture conforms to the requirements or standards specified in federal, state, or local standards or codes or other officially required guidelines or regulations.
        /// </summary>
        public System.Decimal? FacilityEstimatedCostToEliminateDeferredMaint { get => _FacilityEstimatedCostToEliminateDeferredMaint; set => SetProperty(ref _FacilityEstimatedCostToEliminateDeferredMaint, value); }

        /// <summary>
        /// An indication of whether the school, building, site, system, component, equipment, vehicle, or fixture conforms to the requirements or standards specified in federal, state, or local standards or codes or other officially required guidelines or regulations.
        /// </summary>
        public System.String FacilityInspectionScoreResultDescription { get => _FacilityInspectionScoreResultDescription; set => SetProperty(ref _FacilityInspectionScoreResultDescription, value); }

        /// <summary>
        /// An indication of whether the school, building, site, system, component, equipment, vehicle, or fixture conforms to the requirements or standards specified in federal, state, or local standards or codes or other officially required guidelines or regulations.
        /// </summary>
        public System.String FacilityInspectionViolationDescription { get => _FacilityInspectionViolationDescription; set => SetProperty(ref _FacilityInspectionViolationDescription, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="FacilityMandate"/> model
        /// </summary>
        public Guid? FacilityMandateId { get => _FacilityMandateId; set => SetProperty(ref _FacilityMandateId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFacilityComplianceStatus"/> model
        /// </summary>
        public Guid? RefFacilityComplianceStatusId { get => _RefFacilityComplianceStatusId; set => SetProperty(ref _RefFacilityComplianceStatusId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFacilityMaintStandardType"/> model
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
            BuildingSystemComponentId = model.BuildingSystemComponentId;
            ComponentOrFixtureCheckDate = model.ComponentOrFixtureCheckDate;
            FacilityComplianceDeterminationDate = model.FacilityComplianceDeterminationDate;
            FacilityComplianceName = model.FacilityComplianceName;
            FacilityComponentDeficiencyDescription = model.FacilityComponentDeficiencyDescription;
            FacilityEstimatedCostToEliminateDeferredMaint = model.FacilityEstimatedCostToEliminateDeferredMaint;
            FacilityInspectionScoreResultDescription = model.FacilityInspectionScoreResultDescription;
            FacilityInspectionViolationDescription = model.FacilityInspectionViolationDescription;
            FacilityMandateId = model.FacilityMandateId;
            RefFacilityComplianceStatusId = model.RefFacilityComplianceStatusId;
            RefFacilityMaintStandardTypeId = model.RefFacilityMaintStandardTypeId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
