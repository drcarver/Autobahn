//**********************************************************
//* DomainName: Facilities
//* FileName:   FacilityJointUseModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Facilities.Models
{
     /// <summary>
     /// The FacilityJointUse Model
     /// </summary>
    public partial class FacilityJointUseModel : AutobahnBase, Interfaces.IFacilityJointUse
    {
        /// <summary>
        /// The reasons for permitting and participating in joint-use.
        /// </summary>
        public Guid? RefBuildingJointUseRationaleTypeId { get; set; }

    }
}
