//***************************************************************************
//* DomainName: Elementary and Secondary (K12) Interfaces (used by both models and View Models
//* FileName:   IK12SeaFederalFunds.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.K12.Interfaces
{
     /// <summary>
     /// The IK12SeaFederalFunds Interface
     /// </summary>
    public partial interface IK12SeaFederalFunds : IAutobahnBase
    {
        /// <summary>
        /// 
        /// </summary>
         DateStateReceivedTitleIIIAllocation { get; set; }

        /// <summary>
        /// 
        /// </summary>
         DateTitleIIIFundsAvailableToSubgrantees { get; set; }

        /// <summary>
        /// 
        /// </summary>
         NumberOfDaysForTitleIIISubgrants { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RecordStartDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        Guid? StateTransferabilityOfFunds { get; set; }

    }
}
