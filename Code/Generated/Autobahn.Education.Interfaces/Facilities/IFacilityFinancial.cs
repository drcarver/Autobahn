//***************************************************************************
//* DomainName: Facilities Interfaces (used by both models and View Models
//* FileName:   IFacilityFinancial.cs
//***************************************************************************

using Autobahn.Education.Interfaces.Common;

namespace Autobahn.Education.Interfaces.Facilities
{
     /// <summary>
     /// The IFacilityFinancial Interface
     /// </summary>
    public partial interface IFacilityFinancial : IAutobahnBase
    {
        #region IFacilityFinancial
        /// <summary>
        /// Reference to an optional instance of the <see cref="IFacilityLease"/> model
        /// </summary>
        Guid? FacilityLeaseId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IFacilityMortgageFee"/> model
        /// </summary>
        Guid? FacilityMortgageFeeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IFacilityMortgage"/> model
        /// </summary>
        Guid? FacilityMortgageId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganizationFinancial"/> model
        /// </summary>
        Guid OrganizationFinancialId { get; set; }

        #endregion
    }
}