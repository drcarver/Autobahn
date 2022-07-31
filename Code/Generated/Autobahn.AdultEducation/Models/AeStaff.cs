//**********************************************************
//* DomainName: Autobahn.AdultEducation
//* FileName:   AeStaff.cs
//**********************************************************

using Autobahn.AdultEducation.Interfaces;

namespace Autobahn.AdultEducation.Models
{
     /// <summary>
     /// The AeStaff
     /// </summary>
    public partial class AeStaff : IAeStaff
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="AeStaff"/> model
        /// </summary>
        public Guid AeStaffId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Defines the AeStaff.YearsOfPriorAeTeachingExperience nullable property
        /// </summary>
        public System.Decimal? YearsOfPriorAeTeachingExperience { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAeStaffClassification"/> model
        /// </summary>
        public Guid? RefAeStaffClassificationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAeStaffEmploymentStatus"/> model
        /// </summary>
        public Guid? RefAeStaffEmploymentStatusId { get; set; }

        /// <summary>
        /// Defines the AeStaff.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the AeStaff.RecordEndDateTime nullable property
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
