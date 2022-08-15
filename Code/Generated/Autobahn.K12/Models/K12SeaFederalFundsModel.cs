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
        /// Did the State transfer funds under the State Transferability authority of Section 6123(a)
        /// </summary>
        public System.Boolean? StateTransferabilityOfFunds { get; set; }

    }
}
