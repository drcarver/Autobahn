//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefParticipationType.cs
//**********************************************************

using Autobahn.Common.Models;
using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The RefParticipationType Model
     /// </summary>
    public partial class RefParticipationType : ReferenceModelBase, IRefParticipationType
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="Organization"/> model
        /// </summary>
        public Guid? OrganizationId { get; set; }

    }
}
