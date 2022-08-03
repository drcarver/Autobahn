//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   FacilityEnergy.cs
//**********************************************************

using Autobahn.Facilities.Interfaces;

namespace Autobahn.Facilities.Models
{
     /// <summary>
     /// The FacilityEnergy
     /// </summary>
    public partial class FacilityEnergy : IFacilityEnergy
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Facility"/> model
        /// </summary>
        public Guid FacilityId { get; set; }

        /// <summary>
        /// Defines the FacilityEnergy.BuildingEnergyServiceCompanyName non nullable property
        /// </summary>
        public System.String BuildingEnergyServiceCompanyName { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingEnergySourceType"/> model
        /// </summary>
        public Guid? RefBuildingEnergySourceTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFacilityUtilityProviderType"/> model
        /// </summary>
        public Guid? RefFacilityUtilityProviderTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFacilityUtilityType"/> model
        /// </summary>
        public Guid? RefFacilityUtilityTypeId { get; set; }

        /// <summary>
        /// Defines the FacilityEnergy.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the FacilityEnergy.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatus"/> model
        /// </summary>
        public Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
