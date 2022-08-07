//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   IFacilityHazardModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Facilities.Interfaces
{
     /// <summary>
     /// The IFacilityHazardModel Interface
     /// </summary>
    public partial interface IFacilityHazardModel : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Facility"/> model
        /// </summary>
        Guid FacilityId { get; set; }

        /// <summary>
        /// Defines the FacilityHazard.FacilityHazardousCondExpectedRemediationDate nullable property
        /// </summary>
        System.DateTime? FacilityHazardousCondExpectedRemediationDate { get; set; }

        /// <summary>
        /// Defines the FacilityHazard.FacilityLocationOfHazardousMaterials non nullable property
        /// </summary>
        System.String FacilityLocationOfHazardousMaterials { get; set; }

        /// <summary>
        /// Defines the FacilityHazard.FacilityNearbyEnvHazardDescription non nullable property
        /// </summary>
        System.String FacilityNearbyEnvHazardDescription { get; set; }

        /// <summary>
        /// Defines the FacilityHazard.HazardousMaterialOrConditionDescription non nullable property
        /// </summary>
        System.String HazardousMaterialOrConditionDescription { get; set; }

        /// <summary>
        /// Defines the FacilityHazard.HazardousMaterialOrConditionTestingDate nullable property
        /// </summary>
        System.DateTime? HazardousMaterialOrConditionTestingDate { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFacilityHazardousMaterialsOrCondType"/> model
        /// </summary>
        Guid? RefFacilityHazardousMaterialsOrCondTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFacilityNaturallyOccurringHazardType"/> model
        /// </summary>
        Guid? RefFacilityNaturallyOccurringHazardTypeId { get; set; }

    }
}
