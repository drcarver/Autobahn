//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IRefParticipationTypeModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The RefParticipationType Interface Model
     /// </summary>
    public partial interface IRefParticipationTypeModel : IReferenceModel
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="Organization"/> model
        /// </summary>
        Guid? OrganizationId { get; set; }

    }
}
