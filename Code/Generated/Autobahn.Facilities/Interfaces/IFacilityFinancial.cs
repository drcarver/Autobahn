//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   IFacilityFinancial.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Facilities.Interfaces
{
     /// <summary>
     /// The IFacilityFinancial
     /// </summary>
    public partial interface IFacilityFinancial : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationFinancial"/> model
        /// </summary>
        Guid OrganizationFinancialId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="FacilityLease"/> model
        /// </summary>
        Guid? FacilityLeaseId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="FacilityMortgage"/> model
        /// </summary>
        Guid? FacilityMortgageId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="FacilityMortgageFee"/> model
        /// </summary>
        Guid? FacilityMortgageFeeId { get; set; }

    }
}
