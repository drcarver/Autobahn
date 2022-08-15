//***************************************************************************
//* DomainName: Credentials Interfaces (used by both models and View Models
//* FileName:   ICredentialDefCriteria.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Credentials.Interfaces
{
     /// <summary>
     /// The ICredentialDefCriteria Interface
     /// </summary>
    public partial interface ICredentialDefCriteria : IAutobahnBase
    {
        /// <summary>
        /// The criteria for competency-based completion of the qualification, achievement, personal or organizational quality, or aspect of an identity.
        /// </summary>
        System.String Criteria { get; set; }

    }
}
