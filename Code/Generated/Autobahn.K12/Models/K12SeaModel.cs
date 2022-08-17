//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12SeaModel.cs
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.K12.Interfaces
{
     /// <summary>
     /// The K12Sea Model
     /// </summary>
    public partial class K12SeaModel : AutobahnBase, Interfaces.IK12Sea
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganization"/> model
        /// </summary>
        public Guid OrganizationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefStateANSICode"/> model
        /// </summary>
        public Guid? RefStateANSICodeId { get; set; }

    }
}
