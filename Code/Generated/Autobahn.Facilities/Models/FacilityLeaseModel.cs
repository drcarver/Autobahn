//**********************************************************
//* DomainName: Facilities
//* FileName:   FacilityLeaseModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Facilities.Models
{
     /// <summary>
     /// The FacilityLease Model
     /// </summary>
    public partial class FacilityLeaseModel : AutobahnBase, Interfaces.IFacilityLease
    {
        /// <summary>
        /// 
        /// </summary>
        public Guid? FacilityLeaseAmount { get; set; }

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
        public  RefFacilityLeaseAmountCategoryId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefFacilityLeaseTypeId { get; set; }

    }
}
