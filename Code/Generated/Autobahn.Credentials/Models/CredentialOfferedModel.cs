//**********************************************************
//* DomainName: Credentials
//* FileName:   CredentialOfferedModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Credentials.Models
{
     /// <summary>
     /// The CredentialOffered Model
     /// </summary>
    public partial class CredentialOfferedModel : AutobahnBase, Interfaces.ICredentialOffered
    {
        /// <summary>
        /// 
        /// </summary>
        public  CredentialOfferedEndDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid? CredentialOfferedStartDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RecordStartDateTime { get; set; }

    }
}
