//**********************************************************
//* DomainName: Credentials
//* FileName:   CredentialIssuerModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Credentials.Models
{
     /// <summary>
     /// The CredentialIssuer Model
     /// </summary>
    public partial class CredentialIssuerModel : AutobahnBase, Interfaces.ICredentialIssuer
    {
        /// <summary>
        /// 
        /// </summary>
        public Guid? AwardIssuerOriginURL { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RecordStartDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefCTDLOrganizationTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RevocationListURL { get; set; }

    }
}
