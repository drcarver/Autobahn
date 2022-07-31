//**********************************************************
//* DomainName: Autobahn.AdultEducation
//* FileName:   IAeProvider.cs
//**********************************************************

namespace Autobahn.AdultEducation.Interfaces
{
     /// <summary>
     /// The IAeProvider
     /// </summary>
    public partial interface IAeProvider
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="AeProvider"/> model
        /// </summary>
        Guid AeProviderId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="Organization"/> model
        /// </summary>
        Guid OrganizationId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="RefLevelOfInstitution"/> model
        /// </summary>
        Guid RefLevelOfInstitutionId { get; set; }

        /// <summary>
        /// Defines the AeProvider.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the AeProvider.RecordEndDateTime nullable property
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
