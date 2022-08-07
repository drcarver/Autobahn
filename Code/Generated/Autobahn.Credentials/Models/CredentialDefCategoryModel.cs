//**********************************************************
//* DomainName: Autobahn.Credentials
//* FileName:   CredentialDefCategoryModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Credentials.Models
{
     /// <summary>
     /// The CredentialDefCategory Model
     /// </summary>
    public partial class CredentialDefCategoryModel : AutobahnBase, Interfaces.ICredentialDefCategoryModel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="CredentialDefinition"/> model
        /// </summary>
        public Guid CredentialDefinitionId { get; set; }

        /// <summary>
        /// Defines the CredentialDefCategory.Category non nullable property
        /// </summary>
        public System.String Category { get; set; }

        /// <summary>
        /// Defines the CredentialDefCategory.CategorySystem non nullable property
        /// </summary>
        public System.String CategorySystem { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
