//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   StaffExperience.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The StaffExperience
     /// </summary>
    public partial class StaffExperience : IStaffExperience
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Defines the StaffExperience.YearsOfPriorTeachingExperience nullable property
        /// </summary>
        public System.Decimal? YearsOfPriorTeachingExperience { get; set; }

        /// <summary>
        /// Defines the StaffExperience.YearsOfPriorAETeachingExperience nullable property
        /// </summary>
        public System.Decimal? YearsOfPriorAETeachingExperience { get; set; }

        /// <summary>
        /// Defines the StaffExperience.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the StaffExperience.RecordEndDateTime nullable property
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
