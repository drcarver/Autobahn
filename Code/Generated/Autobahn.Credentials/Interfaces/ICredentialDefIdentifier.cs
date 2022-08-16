//***************************************************************************
//* DomainName: Credentials Interfaces (used by both models and View Models
//* FileName:   ICredentialDefIdentifier.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Credentials.Interfaces
{
     /// <summary>
     /// The ICredentialDefIdentifier Interface
     /// </summary>
    public partial interface ICredentialDefIdentifier : IAutobahnBase
    {
        /// <summary>
        /// 
        /// </summary>
        Guid? Identifier { get; set; }

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
         RefCredentialIdentifierSystemId { get; set; }

    }
}
