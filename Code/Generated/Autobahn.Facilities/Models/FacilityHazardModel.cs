//**********************************************************
//* DomainName: Facilities
//* FileName:   FacilityHazardModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Facilities.Models
{
     /// <summary>
     /// The FacilityHazard Model
     /// </summary>
    public partial class FacilityHazardModel : AutobahnBase, Interfaces.IFacilityHazard
    {
        /// <summary>
        /// The location at which the identified hazardous material is found.
        /// </summary>
        public System.DateTime? FacilityHazardousCondExpectedRemediationDate { get; set; }

        /// <summary>
        /// The location at which the identified hazardous material is found.
        /// </summary>
        public Guid FacilityId { get; set; }

        /// <summary>
        /// The location at which the identified hazardous material is found.
        /// </summary>
        public System.String FacilityLocationOfHazardousMaterials { get; set; }

        /// <summary>
        /// The location at which the identified hazardous material is found.
        /// </summary>
        public System.String FacilityNearbyEnvHazardDescription { get; set; }

        /// <summary>
        /// The location at which the identified hazardous material is found.
        /// </summary>
        public System.String HazardousMaterialOrConditionDescription { get; set; }

        /// <summary>
        /// The location at which the identified hazardous material is found.
        /// </summary>
        public System.DateTime? HazardousMaterialOrConditionTestingDate { get; set; }

        /// <summary>
        /// The location at which the identified hazardous material is found.
        /// </summary>
        public Guid? RefFacilityHazardousMaterialsOrCondTypeId { get; set; }

        /// <summary>
        /// The location at which the identified hazardous material is found.
        /// </summary>
        public Guid? RefFacilityNaturallyOccurringHazardTypeId { get; set; }

    }
}
