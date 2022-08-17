//***************************************************************************
//* DomainName: Elementary and Secondary (K12) Interfaces (used by both models and View Models
//* FileName:   IK12SeaAlternateFundUse.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.K12.Interfaces
{
     /// <summary>
     /// The IK12SeaAlternateFundUse Interface
     /// </summary>
    public partial interface IK12SeaAlternateFundUse : IAutobahnBase
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="IK12SeaFederalFunds"/> model
        /// </summary>
        Guid K12SeaFederalFundsId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefAlternateFundUses"/> model
        /// </summary>
        Guid RefAlternateFundUsesId { get; set; }

    }
}
