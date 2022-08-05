//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IRefParticipationType.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The RefParticipationType Interface
     /// </summary>
    public partial interface IRefParticipationType : IReferenceModel
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="Organization"/> model
        /// </summary>
        Guid? OrganizationId { get; set; }

    }
}
