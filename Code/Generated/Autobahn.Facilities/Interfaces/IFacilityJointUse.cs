//***************************************************************************
//* DomainName: Facilities Interfaces (used by both models and View Models
//* FileName:   IFacilityJointUse.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Facilities.Interfaces
{
     /// <summary>
     /// The IFacilityJointUse Interface
     /// </summary>
    public partial interface IFacilityJointUse : IAutobahnBase
    {
        /// <summary>
        /// 
        /// </summary>
         RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RecordStartDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        Guid? RefBuildingJointUseRationaleTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefBuildingJointUserTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefBuildingJointUseSchedulingTypeId { get; set; }

    }
}
