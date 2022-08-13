//**********************************************************
//* DomainName: Early Learning (EL)
//* FileName:   ELOrganizationAvailabilityModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.EarlyLearning.Models
{
     /// <summary>
     /// The ELOrganizationAvailability Model
     /// </summary>
    public partial class ELOrganizationAvailabilityModel : AutobahnBase, Interfaces.IELOrganizationAvailability
    {
        /// <summary>
        /// Nature of early childhood program, class or group in which a person is enrolled.
        /// </summary>
        public System.Int32? AnnualOperatingWeeks { get; set; }

        /// <summary>
        /// Nature of early childhood program, class or group in which a person is enrolled.
        /// </summary>
        public System.Int32? DaysAvailablePerWeek { get; set; }

        /// <summary>
        /// Nature of early childhood program, class or group in which a person is enrolled.
        /// </summary>
        public System.Decimal? HoursAvailablePerDay { get; set; }

        /// <summary>
        /// Nature of early childhood program, class or group in which a person is enrolled.
        /// </summary>
        public System.Int32? NumberOfClassrooms { get; set; }

        /// <summary>
        /// Nature of early childhood program, class or group in which a person is enrolled.
        /// </summary>
        public Guid OrganizationId { get; set; }

        /// <summary>
        /// Nature of early childhood program, class or group in which a person is enrolled.
        /// </summary>
        public Guid? RefEnvironmentSettingId { get; set; }

        /// <summary>
        /// Nature of early childhood program, class or group in which a person is enrolled.
        /// </summary>
        public Guid? RefServiceOptionId { get; set; }

    }
}
