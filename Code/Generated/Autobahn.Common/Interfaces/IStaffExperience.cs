//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IStaffExperience.cs
//**********************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IStaffExperience
     /// </summary>
    public partial interface IStaffExperience : IAutobahnBase
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

    }
}
