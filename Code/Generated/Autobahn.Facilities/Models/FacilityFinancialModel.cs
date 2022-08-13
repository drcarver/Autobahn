//**********************************************************
//* DomainName: Facilities
//* FileName:   FacilityFinancialModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Facilities.Models
{
     /// <summary>
     /// The FacilityFinancial Model
     /// </summary>
    public partial class FacilityFinancialModel : AutobahnBase, Interfaces.IFacilityFinancial
    {
        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        public Guid? FacilityLeaseId { get; set; }

        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        public Guid? FacilityMortgageFeeId { get; set; }

        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        public Guid? FacilityMortgageId { get; set; }

        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        public Guid OrganizationFinancialId { get; set; }

    }
}
