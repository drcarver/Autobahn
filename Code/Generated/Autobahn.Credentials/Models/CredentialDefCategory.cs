//**********************************************************
//* DomainName: Autobahn.Credentials
//* FileName:   CredentialDefCategory.cs
//**********************************************************

using Autobahn.Credentials.Interfaces;

namespace Autobahn.Credentials.Models
{
     /// <summary>
     /// The CredentialDefCategory
     /// </summary>
    public partial class CredentialDefCategory : ICredentialDefCategory
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
        /// Defines the CredentialDefCategory.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the CredentialDefCategory.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatus"/> model
        /// </summary>
        public Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
