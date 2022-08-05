//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   FacilityFinancial.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Facilities.Models
{
     /// <summary>
     /// The FacilityFinancial
     /// </summary>
    public partial class FacilityFinancial : AutobahnBase, Interfaces.IFacilityFinancial
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationFinancial"/> model
        /// </summary>
        public Guid OrganizationFinancialId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="FacilityLease"/> model
        /// </summary>
        public Guid? FacilityLeaseId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="FacilityMortgage"/> model
        /// </summary>
        public Guid? FacilityMortgageId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="FacilityMortgageFee"/> model
        /// </summary>
        public Guid? FacilityMortgageFeeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
