//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12SeaAlternateFundUseModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The K12SeaAlternateFundUse Model
     /// </summary>
    public partial class K12SeaAlternateFundUseModel : AutobahnBase, Interfaces.IK12SeaAlternateFundUse
    {
        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        public Guid K12SeaFederalFundsId { get; set; }

        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        public Guid RefAlternateFundUsesId { get; set; }

    }
}
