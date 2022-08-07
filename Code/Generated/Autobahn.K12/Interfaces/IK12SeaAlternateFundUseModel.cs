//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   IK12SeaAlternateFundUseModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.K12.Interfaces
{
     /// <summary>
     /// The IK12SeaAlternateFundUseModel Interface
     /// </summary>
    public partial interface IK12SeaAlternateFundUseModel : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="K12SeaFederalFunds"/> model
        /// </summary>
        Guid K12SeaFederalFundsId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="RefAlternateFundUses"/> model
        /// </summary>
        Guid RefAlternateFundUsesId { get; set; }

    }
}
