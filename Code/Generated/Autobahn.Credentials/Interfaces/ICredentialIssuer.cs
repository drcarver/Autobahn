//***************************************************************************
//* DomainName: Credentials Interfaces (used by both models and View Models
//* FileName:   ICredentialIssuer.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Credentials.Interfaces
{
     /// <summary>
     /// The ICredentialIssuer Interface
     /// </summary>
    public partial interface ICredentialIssuer : IAutobahnBase
    {
        /// <summary>
        /// 
        /// </summary>
        Guid? AwardIssuerOriginURL { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RecordStartDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefCTDLOrganizationTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RevocationListURL { get; set; }

    }
}
