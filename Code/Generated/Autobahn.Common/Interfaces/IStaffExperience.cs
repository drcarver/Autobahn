//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IStaffExperience.cs
//**********************************************************

namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IStaffExperience
     /// </summary>
    public partial interface IStaffExperience
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationPersonRole"/> model
        /// </summary>
        Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Defines the StaffExperience.YearsOfPriorTeachingExperience nullable property
        /// </summary>
        System.Decimal? YearsOfPriorTeachingExperience { get; set; }

        /// <summary>
        /// Defines the StaffExperience.YearsOfPriorAETeachingExperience nullable property
        /// </summary>
        System.Decimal? YearsOfPriorAETeachingExperience { get; set; }

        /// <summary>
        /// Defines the StaffExperience.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the StaffExperience.RecordEndDateTime nullable property
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
