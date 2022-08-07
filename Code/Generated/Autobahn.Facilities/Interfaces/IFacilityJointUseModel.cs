//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   IFacilityJointUseModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Facilities.Interfaces
{
     /// <summary>
     /// The IFacilityJointUseModel Interface
     /// </summary>
    public partial interface IFacilityJointUseModel : IAutobahnBase
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

    }
}
