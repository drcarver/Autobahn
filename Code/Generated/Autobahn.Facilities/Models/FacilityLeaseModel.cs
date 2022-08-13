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
        /// The amount of money the school must pay to rent the facility that it is in.
        /// </summary>
        public Guid FacilityId { get; set; }

        /// <summary>
        /// The amount of money the school must pay to rent the facility that it is in.
        /// </summary>
        public System.Decimal? FacilityLeaseAmount { get; set; }

        /// <summary>
        /// The amount of money the school must pay to rent the facility that it is in.
        /// </summary>
        public Guid? RefFacilityLeaseAmountCategoryId { get; set; }

        /// <summary>
        /// The amount of money the school must pay to rent the facility that it is in.
        /// </summary>
        public Guid? RefFacilityLeaseTypeId { get; set; }

    }
}
