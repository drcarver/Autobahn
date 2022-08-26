//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12seaAlternateFundUseModel.cs
//***************************************************************************

using Autobahn.Interfaces.K12;
using Autobahn.Interfaces.Common;
using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The K12seaAlternateFundUse Model
     /// </summary>
    public partial class K12seaAlternateFundUseModel : AutobahnBase, IK12seaAlternateFundUse
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="IK12seaFederalFunds"/> model
        /// </summary>
        public Guid K12seaFederalFundsId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAlternateFundUses"/> model
        /// </summary>
        public Guid RefAlternateFundUsesId { get; set; }

    }
}
