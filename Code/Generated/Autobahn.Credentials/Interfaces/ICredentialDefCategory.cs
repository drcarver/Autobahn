//**********************************************************
//* DomainName: Autobahn.Credentials
//* FileName:   ICredentialDefCategory.cs
//**********************************************************

namespace Autobahn.Credentials.Interfaces
{
     /// <summary>
     /// The ICredentialDefCategory
     /// </summary>
    public partial interface ICredentialDefCategory
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

        /// <summary>
        /// Defines the CredentialDefCategory.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the CredentialDefCategory.RecordEndDateTime nullable property
        /// </summary>
        System.DateTime? RecordEndDateTime { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatus"/> model
        /// </summary>
        Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        Guid? DataCollectionId { get; set; }

    }
}
