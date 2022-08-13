//***************************************************************************
//* DomainName: Facilities Interfaces (used by both models and View Models
//* FileName:   IFacilityLease.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Facilities.Interfaces
{
     /// <summary>
     /// The IFacilityLease Interface
     /// </summary>
    public partial interface IFacilityLease : IAutobahnBase
    {
        /// <summary>
        /// The amount of money the school must pay to rent the facility that it is in.
        /// </summary>
        Guid FacilityId { get; set; }

        /// <summary>
        /// The amount of money the school must pay to rent the facility that it is in.
        /// </summary>
        System.Decimal? FacilityLeaseAmount { get; set; }

        /// <summary>
        /// The amount of money the school must pay to rent the facility that it is in.
        /// </summary>
        Guid? RefFacilityLeaseAmountCategoryId { get; set; }

        /// <summary>
        /// The amount of money the school must pay to rent the facility that it is in.
        /// </summary>
        Guid? RefFacilityLeaseTypeId { get; set; }

    }
}
