//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefParticipationTypeModel.cs
//**********************************************************

using Autobahn.Common.Models;
using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The RefParticipationType Model
     /// </summary>
    public partial class RefParticipationTypeModel : ReferenceModelBase, IRefParticipationTypeModel
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="Organization"/> model
        /// </summary>
        public Guid? OrganizationId { get; set; }

    }
}
