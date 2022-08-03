//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   IFacilityJointUse.cs
//**********************************************************

namespace Autobahn.Facilities.Interfaces
{
     /// <summary>
     /// The IFacilityJointUse
     /// </summary>
    public partial interface IFacilityJointUse
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Facility"/> model
        /// </summary>
        Guid FacilityId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingJointUseRationaleType"/> model
        /// </summary>
        Guid? RefBuildingJointUseRationaleTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingJointUserType"/> model
        /// </summary>
        Guid? RefBuildingJointUserTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingJointUseSchedulingType"/> model
        /// </summary>
        Guid? RefBuildingJointUseSchedulingTypeId { get; set; }

        /// <summary>
        /// Defines the FacilityJointUse.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the FacilityJointUse.RecordEndDateTime nullable property
        /// </summary>
        System.DateTime? RecordEndDateTime { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatus"/> model
        /// </summary>
        Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        Guid? DataCollectionId { get; set; }

    }
}
