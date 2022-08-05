//**********************************************************
//* DomainName: Autobahn.Postsecondary
//* FileName:   IPsInstitution.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Postsecondary.Interfaces
{
     /// <summary>
     /// The IPsInstitution
     /// </summary>
    public partial interface IPsInstitution : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Organization"/> model
        /// </summary>
        Guid OrganizationId { get; set; }

        /// <summary>
        /// Defines the PsInstitution.VirtualIndicator nullable property
        /// </summary>
        System.Boolean? VirtualIndicator { get; set; }

        /// <summary>
        /// Defines the PsInstitution.InstitutionallyControlledHousingStatus nullable property
        /// </summary>
        System.Boolean? InstitutionallyControlledHousingStatus { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCarnegieBasicClassification"/> model
        /// </summary>
        Guid? RefCarnegieBasicClassificationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefControlOfInstitution"/> model
        /// </summary>
        Guid? RefControlOfInstitutionId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLevelOfInstitution"/> model
        /// </summary>
        Guid? RefLevelOfInstitutionId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPredominantCalendarSystem"/> model
        /// </summary>
        Guid? RefPredominantCalendarSystemId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTenureSystem"/> model
        /// </summary>
        Guid? RefTenureSystemId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAdmissionConsiderationLevel"/> model
        /// </summary>
        Guid? RefAdmissionConsiderationLevelId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAdmissionConsiderationType"/> model
        /// </summary>
        Guid? RefAdmissionConsiderationTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAdministrativeFundingControl"/> model
        /// </summary>
        Guid? RefAdministrativeFundingControlId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIncreasedLearningTimeType"/> model
        /// </summary>
        Guid? RefIncreasedLearningTimeTypeId { get; set; }

    }
}
