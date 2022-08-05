//**********************************************************
//* DomainName: Autobahn.EarlyLearning
//* FileName:   IELOrganizationAvailability.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.EarlyLearning.Interfaces
{
     /// <summary>
     /// The IELOrganizationAvailability
     /// </summary>
    public partial interface IELOrganizationAvailability : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Organization"/> model
        /// </summary>
        Guid OrganizationId { get; set; }

        /// <summary>
        /// Defines the ELOrganizationAvailability.DaysAvailablePerWeek nullable property
        /// </summary>
        System.Int32? DaysAvailablePerWeek { get; set; }

        /// <summary>
        /// Defines the ELOrganizationAvailability.HoursAvailablePerDay nullable property
        /// </summary>
        System.Decimal? HoursAvailablePerDay { get; set; }

        /// <summary>
        /// Defines the ELOrganizationAvailability.NumberOfClassrooms nullable property
        /// </summary>
        System.Int32? NumberOfClassrooms { get; set; }

        /// <summary>
        /// Defines the ELOrganizationAvailability.AnnualOperatingWeeks nullable property
        /// </summary>
        System.Int32? AnnualOperatingWeeks { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefEnvironmentSetting"/> model
        /// </summary>
        Guid? RefEnvironmentSettingId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefServiceOption"/> model
        /// </summary>
        Guid? RefServiceOptionId { get; set; }

    }
}
