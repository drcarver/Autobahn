//**********************************************************
//* DomainName: Autobahn.Credentials
//* FileName:   ICredentialDefCriteria.cs
//**********************************************************

namespace Autobahn.Credentials.Interfaces
{
     /// <summary>
     /// The ICredentialDefCriteria
     /// </summary>
    public partial interface ICredentialDefCriteria
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="CredentialDefinition"/> model
        /// </summary>
        Guid CredentialDefinitionId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="CompetencySet"/> model
        /// </summary>
        Guid? CompetencySetId { get; set; }

        /// <summary>
        /// Defines the CredentialDefCriteria.Criteria non nullable property
        /// </summary>
        System.String Criteria { get; set; }

        /// <summary>
        /// Defines the CredentialDefCriteria.CriteriaUrl non nullable property
        /// </summary>
        System.String CriteriaUrl { get; set; }

        /// <summary>
        /// Defines the CredentialDefCriteria.EstimatedDuration non nullable property
        /// </summary>
        System.String EstimatedDuration { get; set; }

        /// <summary>
        /// Defines the CredentialDefCriteria.MaximumDuration non nullable property
        /// </summary>
        System.String MaximumDuration { get; set; }

        /// <summary>
        /// Defines the CredentialDefCriteria.MinimumAge nullable property
        /// </summary>
        System.Int32? MinimumAge { get; set; }

        /// <summary>
        /// Defines the CredentialDefCriteria.MinimumDuration non nullable property
        /// </summary>
        System.String MinimumDuration { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCredentialDefAssessMethodType"/> model
        /// </summary>
        Guid? RefCredentialDefAssessMethodTypeId { get; set; }

        /// <summary>
        /// Defines the CredentialDefCriteria.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the CredentialDefCriteria.RecordEndDateTime nullable property
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
