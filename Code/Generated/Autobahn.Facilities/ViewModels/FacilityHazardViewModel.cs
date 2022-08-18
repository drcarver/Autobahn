//**********************************************************
//* DomainName: Facilities
//* FileName:   FacilityHazardViewModel.cs
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Facilities.ViewModels
{
     /// <summary>
     /// The FacilityHazard View Model
     /// </summary>
    public partial class FacilityHazardViewModel : ViewModelBase, Interfaces.IFacilityHazard
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from FacilityHazard";

        // FacilityHazardousCondExpectedRemediationDate -- (backing property for Facility Hazardous Condition Expected Remediation Date)
        private System.DateTime? _FacilityHazardousCondExpectedRemediationDate;

        // member variable for the FacilityId property
        private Guid _FacilityId;

        // FacilityLocationOfHazardousMaterials -- (backing property for Facility Location of Hazardous Materials)
        private System.String _FacilityLocationOfHazardousMaterials;

        // FacilityNearbyEnvHazardDescription -- (backing property for Facility Nearby Environmental Hazard Description)
        private System.String _FacilityNearbyEnvHazardDescription;

        // HazardousMaterialOrConditionDescription -- (backing property for Hazardous Material or Condition Description)
        private System.String _HazardousMaterialOrConditionDescription;

        // HazardousMaterialOrConditionTestingDate -- (backing property for Hazardous Material or Condition Testing Date)
        private System.DateTime? _HazardousMaterialOrConditionTestingDate;

        // RefFacilityHazardousMaterialsOrCondTypeId -- (backing property for Facility Hazardous Materials or Condition Type)
        private Guid? _RefFacilityHazardousMaterialsOrCondTypeId;

        // RefFacilityNaturallyOccurringHazardTypeId -- (backing property for Facility Naturally Occurring Hazard Type)
        private Guid? _RefFacilityNaturallyOccurringHazardTypeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Facility Hazardous Condition Expected Remediation Date
        /// <para>
        /// The month, day, and year by which a hazardous condition of a site or building is expected to be remediated.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20823">Facility Hazardous Condition Expected Remediation Date</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.DateTime? FacilityHazardousCondExpectedRemediationDate { get => _FacilityHazardousCondExpectedRemediationDate; set => SetProperty(ref _FacilityHazardousCondExpectedRemediationDate, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IFacility"/> model
        /// </summary>
        public Guid FacilityId { get => _FacilityId; set => SetProperty(ref _FacilityId, value); }

        /// <summary>
        /// Facility Location of Hazardous Materials
        /// <para>
        /// The location at which the identified hazardous material is found.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20789">Facility Location of Hazardous Materials</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String FacilityLocationOfHazardousMaterials { get => _FacilityLocationOfHazardousMaterials; set => SetProperty(ref _FacilityLocationOfHazardousMaterials, value); }

        /// <summary>
        /// Facility Nearby Environmental Hazard Description
        /// <para>
        /// Description of any type of environmental hazards within range of the facility that has the potential to seriously affect the health, safety and operation of school facilities and their occupants.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20791">Facility Nearby Environmental Hazard Description</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String FacilityNearbyEnvHazardDescription { get => _FacilityNearbyEnvHazardDescription; set => SetProperty(ref _FacilityNearbyEnvHazardDescription, value); }

        /// <summary>
        /// Hazardous Material or Condition Description
        /// <para>
        /// A description of the seriousness a threat or hazardous material poses.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20825">Hazardous Material or Condition Description</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String HazardousMaterialOrConditionDescription { get => _HazardousMaterialOrConditionDescription; set => SetProperty(ref _HazardousMaterialOrConditionDescription, value); }

        /// <summary>
        /// Hazardous Material or Condition Testing Date
        /// <para>
        /// The month, day, and year that the site or building is tested for a specific hazardous material.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20826">Hazardous Material or Condition Testing Date</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.DateTime? HazardousMaterialOrConditionTestingDate { get => _HazardousMaterialOrConditionTestingDate; set => SetProperty(ref _HazardousMaterialOrConditionTestingDate, value); }

        /// <summary>
        /// Facility Hazardous Materials or Condition Type
        /// <para>
        /// The type of hazardous materials or conditions tested for at a site or building.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20855">Facility Hazardous Materials or Condition Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefFacilityHazardousMaterialsOrCondTypeId { get => _RefFacilityHazardousMaterialsOrCondTypeId; set => SetProperty(ref _RefFacilityHazardousMaterialsOrCondTypeId, value); }

        /// <summary>
        /// Facility Naturally Occurring Hazard Type
        /// <para>
        /// Type of natural hazard that can affect the health, safety and operation of school facilities and their occupants.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20858">Facility Naturally Occurring Hazard Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefFacilityNaturallyOccurringHazardTypeId { get => _RefFacilityNaturallyOccurringHazardTypeId; set => SetProperty(ref _RefFacilityNaturallyOccurringHazardTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IFacilityHazard model)
        {
            IsBusy = true;
            Id = model.Id;
            FacilityHazardousCondExpectedRemediationDate = model.FacilityHazardousCondExpectedRemediationDate; // Facility Hazardous Condition Expected Remediation Date
            FacilityId = model.FacilityId; // 
            FacilityLocationOfHazardousMaterials = model.FacilityLocationOfHazardousMaterials; // Facility Location of Hazardous Materials
            FacilityNearbyEnvHazardDescription = model.FacilityNearbyEnvHazardDescription; // Facility Nearby Environmental Hazard Description
            HazardousMaterialOrConditionDescription = model.HazardousMaterialOrConditionDescription; // Hazardous Material or Condition Description
            HazardousMaterialOrConditionTestingDate = model.HazardousMaterialOrConditionTestingDate; // Hazardous Material or Condition Testing Date
            RefFacilityHazardousMaterialsOrCondTypeId = model.RefFacilityHazardousMaterialsOrCondTypeId; // Facility Hazardous Materials or Condition Type
            RefFacilityNaturallyOccurringHazardTypeId = model.RefFacilityNaturallyOccurringHazardTypeId; // Facility Naturally Occurring Hazard Type
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
