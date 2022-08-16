//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12SeaFederalFundsModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The K12SeaFederalFunds Model
     /// </summary>
    public partial class K12SeaFederalFundsModel : AutobahnBase, Interfaces.IK12SeaFederalFunds
    {
        /// <summary>
        /// 
        /// </summary>
        public  DateStateReceivedTitleIIIAllocation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  DateTitleIIIFundsAvailableToSubgrantees { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  NumberOfDaysForTitleIIISubgrants { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RecordStartDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid? StateTransferabilityOfFunds { get; set; }

    }
}
