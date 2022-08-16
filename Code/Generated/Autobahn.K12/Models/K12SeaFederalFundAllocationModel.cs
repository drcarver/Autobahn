//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12SeaFederalFundAllocationModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The K12SeaFederalFundAllocation Model
     /// </summary>
    public partial class K12SeaFederalFundAllocationModel : AutobahnBase, Interfaces.IK12SeaFederalFundAllocation
    {
        /// <summary>
        /// 
        /// </summary>
        public  FederalProgramCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  FederalProgramsFundingAllocation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefFederalProgramFundingAllocationTypeId { get; set; }

    }
}
