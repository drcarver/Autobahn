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
        /// 
        /// </summary>
        public  RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RecordStartDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid? RefBuildingJointUseRationaleTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefBuildingJointUserTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefBuildingJointUseSchedulingTypeId { get; set; }

    }
}
