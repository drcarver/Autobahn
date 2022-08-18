//**********************************************************
//* DomainName: Facilities
//* FileName:   FacilityComplianceViewModel.cs
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Facilities.ViewModels
{
     /// <summary>
     /// The FacilityCompliance View Model
     /// </summary>
    public partial class FacilityComplianceViewModel : ViewModelBase, Interfaces.IFacilityCompliance
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from FacilityCompliance";

        // member variable for the BuildingSystemComponentId property
        private Guid? _BuildingSystemComponentId;

        // ComponentOrFixtureCheckDate -- (backing property for Component or Fixture Check Date)
        private System.DateTime? _ComponentOrFixtureCheckDate;

        // FacilityComplianceDeterminationDate -- (backing property for Facility Compliance Determination Date)
        private System.DateTime? _FacilityComplianceDeterminationDate;

        // FacilityComplianceName -- (backing property for Facility Compliance Name)
        private System.String _FacilityComplianceName;

        // FacilityComponentDeficiencyDescription -- (backing property for Facility Component Deficiency Description)
        private System.String _FacilityComponentDeficiencyDescription;

        // FacilityEstimatedCostToEliminateDeferredMaint -- (backing property for Facility Estimated Cost to Eliminate Deferred Maintenance)
        private System.Decimal? _FacilityEstimatedCostToEliminateDeferredMaint;

        // FacilityInspectionScoreResultDescription -- (backing property for Facility Inspection Score Result Description)
        private System.String _FacilityInspectionScoreResultDescription;

        // FacilityInspectionViolationDescription -- (backing property for Facility Inspection Violation Description)
        private System.String _FacilityInspectionViolationDescription;

        // member variable for the FacilityMandateId property
        private Guid? _FacilityMandateId;

        // RefFacilityComplianceStatusId -- (backing property for Facility Compliance Status)
        private Guid? _RefFacilityComplianceStatusId;

        // RefFacilityMaintStandardTypeId -- (backing property for Facility Maintenance Standard Type)
        private Guid? _RefFacilityMaintStandardTypeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IBuildingSystemComponent"/> model
        /// </summary>
        public Guid? BuildingSystemComponentId { get => _BuildingSystemComponentId; set => SetProperty(ref _BuildingSystemComponentId, value); }

        /// <summary>
        /// Component or Fixture Check Date
        /// <para>
        /// The month, day, and year that the condition of a system, component, equipment, or fixture was  checked.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20879">Component or Fixture Check Date</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.DateTime? ComponentOrFixtureCheckDate { get => _ComponentOrFixtureCheckDate; set => SetProperty(ref _ComponentOrFixtureCheckDate, value); }

        /// <summary>
        /// Facility Compliance Determination Date
        /// <para>
        /// The month, day, and year that the school, building, site, system, component, equipment, or fixture compliance status was determined.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20818">Facility Compliance Determination Date</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.DateTime? FacilityComplianceDeterminationDate { get => _FacilityComplianceDeterminationDate; set => SetProperty(ref _FacilityComplianceDeterminationDate, value); }

        /// <summary>
        /// Facility Compliance Name
        /// <para>
        /// The name of the inspection or process that indicates conformity to the requirements or standards specified in federal, state, or local standards or codes.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20819">Facility Compliance Name</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String FacilityComplianceName { get => _FacilityComplianceName; set => SetProperty(ref _FacilityComplianceName, value); }

        /// <summary>
        /// Facility Component Deficiency Description
        /// <para>
        /// A description of the component, system, or finish that needs replacement, repair, or maintenance to perform at an optimal level.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20820">Facility Component Deficiency Description</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String FacilityComponentDeficiencyDescription { get => _FacilityComponentDeficiencyDescription; set => SetProperty(ref _FacilityComponentDeficiencyDescription, value); }

        /// <summary>
        /// Facility Estimated Cost to Eliminate Deferred Maintenance
        /// <para>
        /// The estimated cost to bring systems, components, finishes, fixtures, or equipment to a state of good repair.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20822">Facility Estimated Cost to Eliminate Deferred Maintenance</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Decimal? FacilityEstimatedCostToEliminateDeferredMaint { get => _FacilityEstimatedCostToEliminateDeferredMaint; set => SetProperty(ref _FacilityEstimatedCostToEliminateDeferredMaint, value); }

        /// <summary>
        /// Facility Inspection Score Result Description
        /// <para>
        /// The description of a meaningful raw score of statistical expression of the performance on an inspection.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20827">Facility Inspection Score Result Description</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String FacilityInspectionScoreResultDescription { get => _FacilityInspectionScoreResultDescription; set => SetProperty(ref _FacilityInspectionScoreResultDescription, value); }

        /// <summary>
        /// Facility Inspection Violation Description
        /// <para>
        /// A description of the standard violation(s) found in the inspection.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20828">Facility Inspection Violation Description</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String FacilityInspectionViolationDescription { get => _FacilityInspectionViolationDescription; set => SetProperty(ref _FacilityInspectionViolationDescription, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IFacilityMandate"/> model
        /// </summary>
        public Guid? FacilityMandateId { get => _FacilityMandateId; set => SetProperty(ref _FacilityMandateId, value); }

        /// <summary>
        /// Facility Compliance Status
        /// <para>
        /// An indication of whether the school, building, site, system, component, equipment, vehicle, or fixture conforms to the requirements or standards specified in federal, state, or local standards or codes or other officially required guidelines or regulations.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20773">Facility Compliance Status</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefFacilityComplianceStatusId { get => _RefFacilityComplianceStatusId; set => SetProperty(ref _RefFacilityComplianceStatusId, value); }

        /// <summary>
        /// Facility Maintenance Standard Type
        /// <para>
        /// The standard for maintenance of a component, system, or building.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20857">Facility Maintenance Standard Type</a>
        /// </para>
        /// </summary>
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
            BuildingSystemComponentId = model.BuildingSystemComponentId; // 
            ComponentOrFixtureCheckDate = model.ComponentOrFixtureCheckDate; // Component or Fixture Check Date
            FacilityComplianceDeterminationDate = model.FacilityComplianceDeterminationDate; // Facility Compliance Determination Date
            FacilityComplianceName = model.FacilityComplianceName; // Facility Compliance Name
            FacilityComponentDeficiencyDescription = model.FacilityComponentDeficiencyDescription; // Facility Component Deficiency Description
            FacilityEstimatedCostToEliminateDeferredMaint = model.FacilityEstimatedCostToEliminateDeferredMaint; // Facility Estimated Cost to Eliminate Deferred Maintenance
            FacilityInspectionScoreResultDescription = model.FacilityInspectionScoreResultDescription; // Facility Inspection Score Result Description
            FacilityInspectionViolationDescription = model.FacilityInspectionViolationDescription; // Facility Inspection Violation Description
            FacilityMandateId = model.FacilityMandateId; // 
            RefFacilityComplianceStatusId = model.RefFacilityComplianceStatusId; // Facility Compliance Status
            RefFacilityMaintStandardTypeId = model.RefFacilityMaintStandardTypeId; // Facility Maintenance Standard Type
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
