//**********************************************************
//* DomainName: Autobahn.Credentials
//* FileName:   ICredentialDefCategoryModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Credentials.Interfaces
{
     /// <summary>
     /// The ICredentialDefCategoryModel Interface
     /// </summary>
    public partial interface ICredentialDefCategoryModel : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="CredentialDefinition"/> model
        /// </summary>
        Guid CredentialDefinitionId { get; set; }

        /// <summary>
        /// Defines the CredentialDefCategory.Category non nullable property
        /// </summary>
        System.String Category { get; set; }

        /// <summary>
        /// Defines the CredentialDefCategory.CategorySystem non nullable property
        /// </summary>
        System.String CategorySystem { get; set; }

    }
}
