//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12seaModel.cs
//***************************************************************************

using Autobahn.Interfaces.K12;
using Autobahn.Interfaces.Common;
using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The K12sea Model
     /// </summary>
    public partial class K12seaModel : AutobahnBase, IK12sea
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganization"/> model
        /// </summary>
        public Guid OrganizationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefStateAnsicode"/> model
        /// </summary>
        public Guid? RefStateAnsicodeId { get; set; }

    }
}
