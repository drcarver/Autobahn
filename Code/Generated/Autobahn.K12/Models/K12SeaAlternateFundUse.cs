//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   K12SeaAlternateFundUse.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The K12SeaAlternateFundUse
     /// </summary>
    public partial class K12SeaAlternateFundUse : AutobahnBase, Interfaces.IK12SeaAlternateFundUse
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="K12SeaFederalFunds"/> model
        /// </summary>
        public Guid K12SeaFederalFundsId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="RefAlternateFundUses"/> model
        /// </summary>
        public Guid RefAlternateFundUsesId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
