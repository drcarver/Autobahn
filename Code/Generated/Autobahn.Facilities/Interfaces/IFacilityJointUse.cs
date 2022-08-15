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
        /// The reasons for permitting and participating in joint-use.
        /// </summary>
        Guid? RefBuildingJointUseRationaleTypeId { get; set; }

    }
}
