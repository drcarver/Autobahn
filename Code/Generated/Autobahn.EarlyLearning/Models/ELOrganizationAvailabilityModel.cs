//**********************************************************
//* DomainName: Autobahn.EarlyLearning
//* FileName:   ELOrganizationAvailabilityModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.EarlyLearning.Models
{
     /// <summary>
     /// The ELOrganizationAvailability Model
     /// </summary>
    public partial class ELOrganizationAvailabilityModel : AutobahnBase, Interfaces.IELOrganizationAvailabilityModel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Organization"/> model
        /// </summary>
        public Guid OrganizationId { get; set; }

        /// <summary>
        /// Defines the ELOrganizationAvailability.DaysAvailablePerWeek nullable property
        /// </summary>
        public System.Int32? DaysAvailablePerWeek { get; set; }

        /// <summary>
        /// Defines the ELOrganizationAvailability.HoursAvailablePerDay nullable property
        /// </summary>
        public System.Decimal? HoursAvailablePerDay { get; set; }

        /// <summary>
        /// Defines the ELOrganizationAvailability.NumberOfClassrooms nullable property
        /// </summary>
        public System.Int32? NumberOfClassrooms { get; set; }

        /// <summary>
        /// Defines the ELOrganizationAvailability.AnnualOperatingWeeks nullable property
        /// </summary>
        public System.Int32? AnnualOperatingWeeks { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefEnvironmentSetting"/> model
        /// </summary>
        public Guid? RefEnvironmentSettingId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefServiceOption"/> model
        /// </summary>
        public Guid? RefServiceOptionId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
