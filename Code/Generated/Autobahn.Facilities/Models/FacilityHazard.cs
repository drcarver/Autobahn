//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   FacilityHazard.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Facilities.Models
{
     /// <summary>
     /// The FacilityHazard
     /// </summary>
    public partial class FacilityHazard : AutobahnBase, Interfaces.IFacilityHazard
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Facility"/> model
        /// </summary>
        public Guid FacilityId { get; set; }

        /// <summary>
        /// Defines the FacilityHazard.FacilityHazardousCondExpectedRemediationDate nullable property
        /// </summary>
        public System.DateTime? FacilityHazardousCondExpectedRemediationDate { get; set; }

        /// <summary>
        /// Defines the FacilityHazard.FacilityLocationOfHazardousMaterials non nullable property
        /// </summary>
        public System.String FacilityLocationOfHazardousMaterials { get; set; }

        /// <summary>
        /// Defines the FacilityHazard.FacilityNearbyEnvHazardDescription non nullable property
        /// </summary>
        public System.String FacilityNearbyEnvHazardDescription { get; set; }

        /// <summary>
        /// Defines the FacilityHazard.HazardousMaterialOrConditionDescription non nullable property
        /// </summary>
        public System.String HazardousMaterialOrConditionDescription { get; set; }

        /// <summary>
        /// Defines the FacilityHazard.HazardousMaterialOrConditionTestingDate nullable property
        /// </summary>
        public System.DateTime? HazardousMaterialOrConditionTestingDate { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFacilityHazardousMaterialsOrCondType"/> model
        /// </summary>
        public Guid? RefFacilityHazardousMaterialsOrCondTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFacilityNaturallyOccurringHazardType"/> model
        /// </summary>
        public Guid? RefFacilityNaturallyOccurringHazardTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
