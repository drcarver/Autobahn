//***************************************************************************
//* DomainName: Elementary and Secondary (K12) Interfaces (used by both models and View Models
//* FileName:   IK12seaAlternateFundUse.cs
//***************************************************************************

using Autobahn.Education.Interfaces.Common;

namespace Autobahn.Education.Interfaces.K12
{
     /// <summary>
     /// The IK12seaAlternateFundUse Interface
     /// </summary>
    public partial interface IK12seaAlternateFundUse : IAutobahnBase
    {
        #region IK12seaAlternateFundUse
        /// <summary>
        /// Reference to an optional instance of the <see cref="IK12seaFederalFunds"/> model
        /// </summary>
        Guid K12seaFederalFundsId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAlternateFundUses"/> model
        /// </summary>
        Guid RefAlternateFundUsesId { get; set; }

        #endregion
    }
}
