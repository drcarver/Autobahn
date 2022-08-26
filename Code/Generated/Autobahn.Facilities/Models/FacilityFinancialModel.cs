//**********************************************************
//* DomainName: Facilities
//* FileName:   FacilityFinancialModel.cs
//***************************************************************************

using Autobahn.Interfaces.Facilities;
using Autobahn.Interfaces.Common;
using Autobahn.Common.Models;

namespace Autobahn.Facilities.Models
{
     /// <summary>
     /// The FacilityFinancial Model
     /// </summary>
    public partial class FacilityFinancialModel : AutobahnBase, IFacilityFinancial
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="IFacilityLease"/> model
        /// </summary>
        public Guid? FacilityLeaseId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IFacilityMortgageFee"/> model
        /// </summary>
        public Guid? FacilityMortgageFeeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IFacilityMortgage"/> model
        /// </summary>
        public Guid? FacilityMortgageId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganizationFinancial"/> model
        /// </summary>
        public Guid OrganizationFinancialId { get; set; }

    }
}
