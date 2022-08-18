//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12SeaFederalFundAllocationModel.cs
//* Name:       Federal Program Code
//* Definition: The unique five-digit number assigned to each federal program as listed in the Catalog of Federal Domestic Assistance (CFDA) Programs.  See http://www.cfda.gov/.
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The unique five-digit number assigned to each federal program as listed in the Catalog of Federal Domestic Assistance (CFDA) Programs.  See http://www.cfda.gov/.
     /// </summary>
    public partial class K12SeaFederalFundAllocationModel : AutobahnBase, Interfaces.IK12SeaFederalFundAllocation
    {
    }
}
