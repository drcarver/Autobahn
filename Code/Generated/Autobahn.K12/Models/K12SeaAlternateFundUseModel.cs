//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12SeaAlternateFundUseModel.cs
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.K12.Interfaces
{
     /// <summary>
     /// The K12SeaAlternateFundUse Model
     /// </summary>
    public partial class K12SeaAlternateFundUseModel : AutobahnBase, Interfaces.IK12SeaAlternateFundUse
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="IK12SeaFederalFunds"/> model
        /// </summary>
        public Guid K12SeaFederalFundsId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefAlternateFundUses"/> model
        /// </summary>
        public Guid RefAlternateFundUsesId { get; set; }

    }
}
