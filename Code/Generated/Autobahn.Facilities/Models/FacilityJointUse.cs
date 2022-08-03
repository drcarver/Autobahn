//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   FacilityJointUse.cs
//**********************************************************

using Autobahn.Facilities.Interfaces;

namespace Autobahn.Facilities.Models
{
     /// <summary>
     /// The FacilityJointUse
     /// </summary>
    public partial class FacilityJointUse : IFacilityJointUse
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Facility"/> model
        /// </summary>
        public Guid FacilityId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingJointUseRationaleType"/> model
        /// </summary>
        public Guid? RefBuildingJointUseRationaleTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingJointUserType"/> model
        /// </summary>
        public Guid? RefBuildingJointUserTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingJointUseSchedulingType"/> model
        /// </summary>
        public Guid? RefBuildingJointUseSchedulingTypeId { get; set; }

        /// <summary>
        /// Defines the FacilityJointUse.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the FacilityJointUse.RecordEndDateTime nullable property
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
