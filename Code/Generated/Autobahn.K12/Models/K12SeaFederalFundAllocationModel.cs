//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12SeaFederalFundAllocationModel.cs
//* Name:       Federal Program Code
//* Definition: The unique five-digit number assigned to each federal program as listed in the Catalog of Federal Domestic Assistance (CFDA) Programs.  See http://www.cfda.gov/.
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.K12.Interfaces
{
     /// <summary>
     /// The unique five-digit number assigned to each federal program as listed in the Catalog of Federal Domestic Assistance (CFDA) Programs.  See http://www.cfda.gov/.
     /// </summary>
    public partial class K12SeaFederalFundAllocationModel : AutobahnBase, Interfaces.IK12SeaFederalFundAllocation
    {
        /// <summary>
        /// Federal Program Code
        /// <para>
        /// The unique five-digit number assigned to each federal program as listed in the Catalog of Federal Domestic Assistance (CFDA) Programs.  See http://www.cfda.gov/.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19538">Federal Program Code</a>
        /// </para>
        /// </summary>
        public  FederalProgramCode { get; set; }

        /// <summary>
        /// Federal Programs Funding Allocation
        /// <para>
        /// The amount of federal dollars distributed to local education agencies (LEAs), retained by the state education agency (SEA) for program administration or other approved state-level activities (including unallocated, transferred to another state agency, or distributed to entities other than LEAs).
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19540">Federal Programs Funding Allocation</a>
        /// </para>
        /// </summary>
        public  FederalProgramsFundingAllocation { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefFederalProgramFundingAllocationType"/> model
        /// </summary>
        public  RefFederalProgramFundingAllocationTypeId { get; set; }

    }
}
