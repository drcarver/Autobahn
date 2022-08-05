//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   IFacilityLease.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Facilities.Interfaces
{
     /// <summary>
     /// The IFacilityLease
     /// </summary>
    public partial interface IFacilityLease : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Facility"/> model
        /// </summary>
        Guid FacilityId { get; set; }

        /// <summary>
        /// Defines the FacilityLease.FacilityLeaseAmount nullable property
        /// </summary>
        System.Decimal? FacilityLeaseAmount { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFacilityLeaseAmountCategory"/> model
        /// </summary>
        Guid? RefFacilityLeaseAmountCategoryId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFacilityLeaseType"/> model
        /// </summary>
        Guid? RefFacilityLeaseTypeId { get; set; }

    }
}
