//***************************************************************************
//* DomainName: Elementary and Secondary (K12) Interfaces (used by both models and View Models
//* FileName:   IK12SeaFederalFundAllocation.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.K12.Interfaces
{
     /// <summary>
     /// The IK12SeaFederalFundAllocation Interface
     /// </summary>
    public partial interface IK12SeaFederalFundAllocation : IAutobahnBase
    {
        /// <summary>
        /// 
        /// </summary>
         FederalProgramCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
         FederalProgramsFundingAllocation { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefFederalProgramFundingAllocationTypeId { get; set; }

    }
}
