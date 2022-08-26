//**********************************************************
//* DomainName: Facilities
//* FileName:   FacilityLeaseModel.cs
//***************************************************************************

using Autobahn.Interfaces.Facilities;
using Autobahn.Interfaces.Common;
using Autobahn.Common.Models;

namespace Autobahn.Facilities.Models
{
     /// <summary>
     /// The FacilityLease Model
     /// </summary>
    public partial class FacilityLeaseModel : AutobahnBase, IFacilityLease
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="IFacility"/> model
        /// </summary>
        public Guid FacilityId { get; set; }

        /// <summary>
        /// Facility Lease Amount
        /// <para>
        /// The amount of money the school must pay to rent the facility that it is in.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20868">Facility Lease Amount</a>
        /// </para>
        /// </summary>
        public Decimal? FacilityLeaseAmount { get; set; }

        /// <summary>
        /// Facility Lease Amount Category
        /// <para>
        /// The category of payment that a school must pay to rent the facility that it is in.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20869">Facility Lease Amount Category</a>
        /// </para>
        /// </summary>
        public Guid? RefFacilityLeaseAmountCategoryId { get; set; }

        /// <summary>
        /// Facility Lease Type
        /// <para>
        /// The type of agreement that allows the use and possession of a school, building, or other facility from a third party in return for a regularly scheduled installment payment over an agreed-upon period.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20870">Facility Lease Type</a>
        /// </para>
        /// </summary>
        public Guid? RefFacilityLeaseTypeId { get; set; }

    }
}
