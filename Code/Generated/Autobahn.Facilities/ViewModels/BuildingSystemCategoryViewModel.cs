//**********************************************************
//* DomainName: Facilities
//* FileName:   BuildingSystemCategoryViewModel.cs
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Facilities.ViewModels
{
     /// <summary>
     /// The BuildingSystemCategory View Model
     /// </summary>
    public partial class BuildingSystemCategoryViewModel : ViewModelBase, Interfaces.IBuildingSystemCategory
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from BuildingSystemCategory";

        // member variable for the BuildingSystemComponentId property
        private Guid _BuildingSystemComponentId;

        // RefBuildingAirDistributionSystemTypeId -- (backing property for Building Air Distribution System Type)
        private Guid? _RefBuildingAirDistributionSystemTypeId;

        // RefBuildingCommMgmtComponentSystemTypeId -- (backing property for Building Communications Management Component System Type)
        private Guid? _RefBuildingCommMgmtComponentSystemTypeId;

        // RefBuildingCoolingGenerationSystemTypeId -- (backing property for Building Cooling Generation System Type)
        private Guid? _RefBuildingCoolingGenerationSystemTypeId;

        // RefBuildingElectricalSystemTypeId -- (backing property for Building Electrical System Type)
        private Guid? _RefBuildingElectricalSystemTypeId;

        // RefBuildingFireProtectionSystemTypeId -- (backing property for Building Fire Protection System Type)
        private Guid? _RefBuildingFireProtectionSystemTypeId;

        // RefBuildingHeatingGenerationSystemTypeId -- (backing property for Building Heating Generation System Type)
        private Guid? _RefBuildingHeatingGenerationSystemTypeId;

        // RefBuildingHVACSystemTypeId -- (backing property for Building HVAC System Type)
        private Guid? _RefBuildingHVACSystemTypeId;

        // RefBuildingMechanicalConveyingSystemTypeId -- (backing property for Building Mechanical Conveying System Type)
        private Guid? _RefBuildingMechanicalConveyingSystemTypeId;

        // RefBuildingMechanicalSystemTypeId -- (backing property for Building Mechanical System Type)
        private Guid? _RefBuildingMechanicalSystemTypeId;

        // RefBuildingPlumbingSystemTypeId -- (backing property for Building Plumbing System Type)
        private Guid? _RefBuildingPlumbingSystemTypeId;

        // RefBuildingSecuritySystemTypeId -- (backing property for Building Security System Type)
        private Guid? _RefBuildingSecuritySystemTypeId;

        // RefBuildingSystemTypeId -- (backing property for Building System Type)
        private Guid? _RefBuildingSystemTypeId;

        // RefBuildingTechnologyWiringSystemTypeId -- (backing property for Building Technology Wiring System Type)
        private Guid? _RefBuildingTechnologyWiringSystemTypeId;

        // RefBuildingVerticalTransportationSystemTypeId -- (backing property for Building Vertical Transportation System Type)
        private Guid? _RefBuildingVerticalTransportationSystemTypeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IBuildingSystemComponent"/> model
        /// </summary>
        public Guid BuildingSystemComponentId { get => _BuildingSystemComponentId; set => SetProperty(ref _BuildingSystemComponentId, value); }

        /// <summary>
        /// Building Air Distribution System Type
        /// <para>
        /// The primary means by which air is circulated, freshened, and exhausted.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20771">Building Air Distribution System Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefBuildingAirDistributionSystemTypeId { get => _RefBuildingAirDistributionSystemTypeId; set => SetProperty(ref _RefBuildingAirDistributionSystemTypeId, value); }

        /// <summary>
        /// Building Communications Management Component System Type
        /// <para>
        /// The type of system, interface, and management components for carrying voice, video, and data throughout a building.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20772">Building Communications Management Component System Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefBuildingCommMgmtComponentSystemTypeId { get => _RefBuildingCommMgmtComponentSystemTypeId; set => SetProperty(ref _RefBuildingCommMgmtComponentSystemTypeId, value); }

        /// <summary>
        /// Building Cooling Generation System Type
        /// <para>
        /// The type of mechanical systems and building designs used for cooling.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20775">Building Cooling Generation System Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefBuildingCoolingGenerationSystemTypeId { get => _RefBuildingCoolingGenerationSystemTypeId; set => SetProperty(ref _RefBuildingCoolingGenerationSystemTypeId, value); }

        /// <summary>
        /// Building Electrical System Type
        /// <para>
        /// The components and system required to distribute electricity throughout the building or site.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20776">Building Electrical System Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefBuildingElectricalSystemTypeId { get => _RefBuildingElectricalSystemTypeId; set => SetProperty(ref _RefBuildingElectricalSystemTypeId, value); }

        /// <summary>
        /// Building Fire Protection System Type
        /// <para>
        /// The type of system that protects the facility against fire.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20779">Building Fire Protection System Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefBuildingFireProtectionSystemTypeId { get => _RefBuildingFireProtectionSystemTypeId; set => SetProperty(ref _RefBuildingFireProtectionSystemTypeId, value); }

        /// <summary>
        /// Building Heating Generation System Type
        /// <para>
        /// The method by which the heat is distributed and delivered throughout the room(s) or building.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20780">Building Heating Generation System Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefBuildingHeatingGenerationSystemTypeId { get => _RefBuildingHeatingGenerationSystemTypeId; set => SetProperty(ref _RefBuildingHeatingGenerationSystemTypeId, value); }

        /// <summary>
        /// Building HVAC System Type
        /// <para>
        /// The building service system that provides for heating, ventilation and air-conditioning.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20781">Building HVAC System Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefBuildingHVACSystemTypeId { get => _RefBuildingHVACSystemTypeId; set => SetProperty(ref _RefBuildingHVACSystemTypeId, value); }

        /// <summary>
        /// Building Mechanical Conveying System Type
        /// <para>
        /// Mechanical means for moving people and equipment within buildings.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20783">Building Mechanical Conveying System Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefBuildingMechanicalConveyingSystemTypeId { get => _RefBuildingMechanicalConveyingSystemTypeId; set => SetProperty(ref _RefBuildingMechanicalConveyingSystemTypeId, value); }

        /// <summary>
        /// Building Mechanical System Type
        /// <para>
        /// The major manufactured systems required to operate a building.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20790">Building Mechanical System Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefBuildingMechanicalSystemTypeId { get => _RefBuildingMechanicalSystemTypeId; set => SetProperty(ref _RefBuildingMechanicalSystemTypeId, value); }

        /// <summary>
        /// Building Plumbing System Type
        /// <para>
        /// The component of an on-site system for supplying, eliminating, and treating water.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20784">Building Plumbing System Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefBuildingPlumbingSystemTypeId { get => _RefBuildingPlumbingSystemTypeId; set => SetProperty(ref _RefBuildingPlumbingSystemTypeId, value); }

        /// <summary>
        /// Building Security System Type
        /// <para>
        /// The type of system that protects the facility from intrusion.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20785">Building Security System Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefBuildingSecuritySystemTypeId { get => _RefBuildingSecuritySystemTypeId; set => SetProperty(ref _RefBuildingSecuritySystemTypeId, value); }

        /// <summary>
        /// Building System Type
        /// <para>
        /// The type of system that is installed in the building or site.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20792">Building System Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefBuildingSystemTypeId { get => _RefBuildingSystemTypeId; set => SetProperty(ref _RefBuildingSystemTypeId, value); }

        /// <summary>
        /// Building Technology Wiring System Type
        /// <para>
        /// The means through which voice, video, audio, and data information are conveyed.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20788">Building Technology Wiring System Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefBuildingTechnologyWiringSystemTypeId { get => _RefBuildingTechnologyWiringSystemTypeId; set => SetProperty(ref _RefBuildingTechnologyWiringSystemTypeId, value); }

        /// <summary>
        /// Building Vertical Transportation System Type
        /// <para>
        /// The type of system used to convey persons or freight between floors.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20793">Building Vertical Transportation System Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefBuildingVerticalTransportationSystemTypeId { get => _RefBuildingVerticalTransportationSystemTypeId; set => SetProperty(ref _RefBuildingVerticalTransportationSystemTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IBuildingSystemCategory model)
        {
            IsBusy = true;
            Id = model.Id;
            BuildingSystemComponentId = model.BuildingSystemComponentId; // 
            RefBuildingAirDistributionSystemTypeId = model.RefBuildingAirDistributionSystemTypeId; // Building Air Distribution System Type
            RefBuildingCommMgmtComponentSystemTypeId = model.RefBuildingCommMgmtComponentSystemTypeId; // Building Communications Management Component System Type
            RefBuildingCoolingGenerationSystemTypeId = model.RefBuildingCoolingGenerationSystemTypeId; // Building Cooling Generation System Type
            RefBuildingElectricalSystemTypeId = model.RefBuildingElectricalSystemTypeId; // Building Electrical System Type
            RefBuildingFireProtectionSystemTypeId = model.RefBuildingFireProtectionSystemTypeId; // Building Fire Protection System Type
            RefBuildingHeatingGenerationSystemTypeId = model.RefBuildingHeatingGenerationSystemTypeId; // Building Heating Generation System Type
            RefBuildingHVACSystemTypeId = model.RefBuildingHVACSystemTypeId; // Building HVAC System Type
            RefBuildingMechanicalConveyingSystemTypeId = model.RefBuildingMechanicalConveyingSystemTypeId; // Building Mechanical Conveying System Type
            RefBuildingMechanicalSystemTypeId = model.RefBuildingMechanicalSystemTypeId; // Building Mechanical System Type
            RefBuildingPlumbingSystemTypeId = model.RefBuildingPlumbingSystemTypeId; // Building Plumbing System Type
            RefBuildingSecuritySystemTypeId = model.RefBuildingSecuritySystemTypeId; // Building Security System Type
            RefBuildingSystemTypeId = model.RefBuildingSystemTypeId; // Building System Type
            RefBuildingTechnologyWiringSystemTypeId = model.RefBuildingTechnologyWiringSystemTypeId; // Building Technology Wiring System Type
            RefBuildingVerticalTransportationSystemTypeId = model.RefBuildingVerticalTransportationSystemTypeId; // Building Vertical Transportation System Type
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
