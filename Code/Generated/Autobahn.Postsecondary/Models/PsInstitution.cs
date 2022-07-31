//**********************************************************
//* DomainName: Autobahn.Postsecondary
//* FileName:   PsInstitution.cs
//**********************************************************

using Autobahn.Postsecondary.Interfaces;

namespace Autobahn.Postsecondary.Models
{
     /// <summary>
     /// The PsInstitution
     /// </summary>
    public partial class PsInstitution : IPsInstitution
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="PsInstitution"/> model
        /// </summary>
        public Guid PsInstitutionId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="Organization"/> model
        /// </summary>
        public Guid OrganizationId { get; set; }

        /// <summary>
        /// Defines the PsInstitution.VirtualIndicator nullable property
        /// </summary>
        public System.Boolean? VirtualIndicator { get; set; }

        /// <summary>
        /// Defines the PsInstitution.InstitutionallyControlledHousingStatus nullable property
        /// </summary>
        public System.Boolean? InstitutionallyControlledHousingStatus { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCarnegieBasicClassification"/> model
        /// </summary>
        public Guid? RefCarnegieBasicClassificationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefControlOfInstitution"/> model
        /// </summary>
        public Guid? RefControlOfInstitutionId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLevelOfInstitution"/> model
        /// </summary>
        public Guid? RefLevelOfInstitutionId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPredominantCalendarSystem"/> model
        /// </summary>
        public Guid? RefPredominantCalendarSystemId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTenureSystem"/> model
        /// </summary>
        public Guid? RefTenureSystemId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAdmissionConsiderationLevel"/> model
        /// </summary>
        public Guid? RefAdmissionConsiderationLevelId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAdmissionConsiderationType"/> model
        /// </summary>
        public Guid? RefAdmissionConsiderationTypeId { get; set; }

        /// <summary>
        /// Defines the PsInstitution.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the PsInstitution.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAdministrativeFundingControl"/> model
        /// </summary>
        public Guid? RefAdministrativeFundingControlId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIncreasedLearningTimeType"/> model
        /// </summary>
        public Guid? RefIncreasedLearningTimeTypeId { get; set; }

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
