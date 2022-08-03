//**********************************************************
//* DomainName: Autobahn.Credentials
//* FileName:   CredentialDefCriteria.cs
//**********************************************************

using Autobahn.Credentials.Interfaces;

namespace Autobahn.Credentials.Models
{
     /// <summary>
     /// The CredentialDefCriteria
     /// </summary>
    public partial class CredentialDefCriteria : ICredentialDefCriteria
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="CredentialDefinition"/> model
        /// </summary>
        public Guid CredentialDefinitionId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="CompetencySet"/> model
        /// </summary>
        public Guid? CompetencySetId { get; set; }

        /// <summary>
        /// Defines the CredentialDefCriteria.Criteria non nullable property
        /// </summary>
        public System.String Criteria { get; set; }

        /// <summary>
        /// Defines the CredentialDefCriteria.CriteriaUrl non nullable property
        /// </summary>
        public System.String CriteriaUrl { get; set; }

        /// <summary>
        /// Defines the CredentialDefCriteria.EstimatedDuration non nullable property
        /// </summary>
        public System.String EstimatedDuration { get; set; }

        /// <summary>
        /// Defines the CredentialDefCriteria.MaximumDuration non nullable property
        /// </summary>
        public System.String MaximumDuration { get; set; }

        /// <summary>
        /// Defines the CredentialDefCriteria.MinimumAge nullable property
        /// </summary>
        public System.Int32? MinimumAge { get; set; }

        /// <summary>
        /// Defines the CredentialDefCriteria.MinimumDuration non nullable property
        /// </summary>
        public System.String MinimumDuration { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCredentialDefAssessMethodType"/> model
        /// </summary>
        public Guid? RefCredentialDefAssessMethodTypeId { get; set; }

        /// <summary>
        /// Defines the CredentialDefCriteria.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the CredentialDefCriteria.RecordEndDateTime nullable property
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
