//***************************************************************************
//* DomainName: Credentials Interfaces (used by both models and View Models
//* FileName:   ICredentialAwardEvidence.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Credentials.Interfaces
{
     /// <summary>
     /// The ICredentialAwardEvidence Interface
     /// </summary>
    public partial interface ICredentialAwardEvidence : IAutobahnBase
    {
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
        Guid? Statement { get; set; }

    }
}
