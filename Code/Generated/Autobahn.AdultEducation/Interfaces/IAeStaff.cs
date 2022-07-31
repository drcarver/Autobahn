//**********************************************************
//* DomainName: Autobahn.AdultEducation
//* FileName:   IAeStaff.cs
//**********************************************************

namespace Autobahn.AdultEducation.Interfaces
{
     /// <summary>
     /// The IAeStaff
     /// </summary>
    public partial Interface IAeStaff
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="AeStaff"/> model
        /// </summary>
        Guid AeStaffId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationPersonRole"/> model
        /// </summary>
        Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Defines the AeStaff.YearsOfPriorAeTeachingExperience nullable property
        /// </summary>
        System.Decimal? YearsOfPriorAeTeachingExperience { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAeStaffClassification"/> model
        /// </summary>
        Guid? RefAeStaffClassificationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAeStaffEmploymentStatus"/> model
        /// </summary>
        Guid? RefAeStaffEmploymentStatusId { get; set; }

        /// <summary>
        /// Defines the AeStaff.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the AeStaff.RecordEndDateTime nullable property
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
