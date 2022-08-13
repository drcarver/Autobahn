//***************************************************************************
//* DomainName: Credentials Interfaces (used by both models and View Models
//* FileName:   ICredentialDefCategory.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Credentials.Interfaces
{
     /// <summary>
     /// The ICredentialDefCategory Interface
     /// </summary>
    public partial interface ICredentialDefCategory : IAutobahnBase
    {
        /// <summary>
        /// A category for defining the qualification, achievement, personal or organizational quality, or aspect of an identity.
        /// </summary>
        System.String Category { get; set; }

        /// <summary>
        /// A category for defining the qualification, achievement, personal or organizational quality, or aspect of an identity.
        /// </summary>
        System.String CategorySystem { get; set; }

        /// <summary>
        /// A category for defining the qualification, achievement, personal or organizational quality, or aspect of an identity.
        /// </summary>
        Guid CredentialDefinitionId { get; set; }

    }
}
