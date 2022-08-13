//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12SeaModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The K12Sea Model
     /// </summary>
    public partial class K12SeaModel : AutobahnBase, Interfaces.IK12Sea
    {
        /// <summary>
        /// The American National Standards Institute (ANSI) two-digit code for the state.
        /// </summary>
        public Guid OrganizationId { get; set; }

        /// <summary>
        /// The American National Standards Institute (ANSI) two-digit code for the state.
        /// </summary>
        public Guid? RefStateANSICodeId { get; set; }

    }
}
