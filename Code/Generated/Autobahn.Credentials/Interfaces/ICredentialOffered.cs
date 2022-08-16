//***************************************************************************
//* DomainName: Credentials Interfaces (used by both models and View Models
//* FileName:   ICredentialOffered.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Credentials.Interfaces
{
     /// <summary>
     /// The ICredentialOffered Interface
     /// </summary>
    public partial interface ICredentialOffered : IAutobahnBase
    {
        /// <summary>
        /// 
        /// </summary>
         CredentialOfferedEndDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        Guid? CredentialOfferedStartDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RecordStartDateTime { get; set; }

    }
}
