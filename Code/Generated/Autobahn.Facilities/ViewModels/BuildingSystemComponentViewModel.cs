//**********************************************************
//* DomainName: Facilities
//* FileName:   BuildingSystemComponentViewModel.cs
//* Name:       Building Institutional Equipment Description
//* Definition: Equipment that is installed for use in support of instructional program such as kilns for art, planetarium equipment for astronomy, fitness equipment for physical education.
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Facilities.ViewModels
{
     /// <summary>
     /// Equipment that is installed for use in support of instructional program such as kilns for art, planetarium equipment for astronomy, fitness equipment for physical education.
     /// </summary>
    public partial class BuildingSystemComponentViewModel : ViewModelBase, Interfaces.IBuildingSystemComponent
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from BuildingSystemComponent";

        // BuildingInstitutionalEquipmentDescription -- (backing property for Building Institutional Equipment Description)
        private System.String _BuildingInstitutionalEquipmentDescription;

        // ComponentOrFixtureUsefulLife -- (backing property for Component or Fixture Useful Life)
        private System.Int32? _ComponentOrFixtureUsefulLife;

        // member variable for the FacilityId property
        private Guid _FacilityId;

        // Identifier -- (backing property for Facility Component Identification Code)
        private System.String _Identifier;

        // InstallationDate -- (backing property for Installation Date)
        private System.String _InstallationDate;

        // LifecycleCost -- (backing property for Life-cycle Cost)
        private System.Decimal? _LifecycleCost;

        // RefFacilityFurnishingsTypeId -- (backing property for Facility Furnishings Type)
        private Guid? _RefFacilityFurnishingsTypeId;

        // RefFacilitySystemOrComponentConditionId -- (backing property for Facility System or Component Condition)
        private Guid? _RefFacilitySystemOrComponentConditionId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Building Institutional Equipment Description
        /// <para>
        /// Equipment that is installed for use in support of instructional program such as kilns for art, planetarium equipment for astronomy, fitness equipment for physical education.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20782">Building Institutional Equipment Description</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String BuildingInstitutionalEquipmentDescription { get => _BuildingInstitutionalEquipmentDescription; set => SetProperty(ref _BuildingInstitutionalEquipmentDescription, value); }

        /// <summary>
        /// Component or Fixture Useful Life
        /// <para>
        /// The anticipated time (in years) from the time of installation or service that a properly maintained system, component, equipment, or fixture is expected to operate effectively and efficiently.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20882">Component or Fixture Useful Life</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Int32? ComponentOrFixtureUsefulLife { get => _ComponentOrFixtureUsefulLife; set => SetProperty(ref _ComponentOrFixtureUsefulLife, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IFacility"/> model
        /// </summary>
        public Guid FacilityId { get => _FacilityId; set => SetProperty(ref _FacilityId, value); }

        /// <summary>
        /// Facility Component Identification Code
        /// <para>
        /// A unique number or alphanumeric code assigned to a component by a school, school system, state, or other agency or entity.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20821">Facility Component Identification Code</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String Identifier { get => _Identifier; set => SetProperty(ref _Identifier, value); }

        /// <summary>
        /// Installation Date
        /// <para>
        /// The year in which the system, component, equipment, or fixture was originally installed.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20829">Installation Date</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String InstallationDate { get => _InstallationDate; set => SetProperty(ref _InstallationDate, value); }

        /// <summary>
        /// Life-cycle Cost
        /// <para>
        /// The total cost of acquiring, owning, operating, and disposing of a building, facility, or piece of equipment over its useful life.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20830">Life-cycle Cost</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Decimal? LifecycleCost { get => _LifecycleCost; set => SetProperty(ref _LifecycleCost, value); }

        /// <summary>
        /// Facility Furnishings Type
        /// <para>
        /// Moveable assets that are provided so the building or interior assets can be utilized by occupants for their intended purposes.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20801">Facility Furnishings Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefFacilityFurnishingsTypeId { get => _RefFacilityFurnishingsTypeId; set => SetProperty(ref _RefFacilityFurnishingsTypeId, value); }

        /// <summary>
        /// Facility System or Component Condition
        /// <para>
        /// The rating of the system or component functions under the demands of its regular operation.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20774">Facility System or Component Condition</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefFacilitySystemOrComponentConditionId { get => _RefFacilitySystemOrComponentConditionId; set => SetProperty(ref _RefFacilitySystemOrComponentConditionId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IBuildingSystemComponent model)
        {
            IsBusy = true;
            Id = model.Id;
            BuildingInstitutionalEquipmentDescription = model.BuildingInstitutionalEquipmentDescription; // Building Institutional Equipment Description
            ComponentOrFixtureUsefulLife = model.ComponentOrFixtureUsefulLife; // Component or Fixture Useful Life
            FacilityId = model.FacilityId; // 
            Identifier = model.Identifier; // Facility Component Identification Code
            InstallationDate = model.InstallationDate; // Installation Date
            LifecycleCost = model.LifecycleCost; // Life-cycle Cost
            RefFacilityFurnishingsTypeId = model.RefFacilityFurnishingsTypeId; // Facility Furnishings Type
            RefFacilitySystemOrComponentConditionId = model.RefFacilitySystemOrComponentConditionId; // Facility System or Component Condition
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
