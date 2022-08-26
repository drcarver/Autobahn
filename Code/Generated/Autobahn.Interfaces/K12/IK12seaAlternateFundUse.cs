//***************************************************************************
//* DomainName: Elementary and Secondary (K12) Interfaces (used by both models and View Models
//* FileName:   IK12seaAlternateFundUse.cs
//***************************************************************************

using Autobahn.Interfaces.Common;

namespace Autobahn.Interfaces.K12
{
     /// <summary>
     /// The IK12seaAlternateFundUse Interface
     /// </summary>
    public partial interface IK12seaAlternateFundUse : IAutobahnBase
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="IK12seaFederalFunds"/> model
        /// </summary>
        Guid K12seaFederalFundsId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAlternateFundUses"/> model
        /// </summary>
        Guid RefAlternateFundUsesId { get; set; }

    }
}
