//**********************************************************
//* DomainName: Credentials
//* FileName:   CredentialDefCategoryModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Credentials.Models
{
     /// <summary>
     /// The CredentialDefCategory Model
     /// </summary>
    public partial class CredentialDefCategoryModel : AutobahnBase, Interfaces.ICredentialDefCategory
    {
        /// <summary>
        /// A category for defining the qualification, achievement, personal or organizational quality, or aspect of an identity.
        /// </summary>
        public System.String Category { get; set; }

        /// <summary>
        /// A category for defining the qualification, achievement, personal or organizational quality, or aspect of an identity.
        /// </summary>
        public System.String CategorySystem { get; set; }

        /// <summary>
        /// A category for defining the qualification, achievement, personal or organizational quality, or aspect of an identity.
        /// </summary>
        public Guid CredentialDefinitionId { get; set; }

    }
}
