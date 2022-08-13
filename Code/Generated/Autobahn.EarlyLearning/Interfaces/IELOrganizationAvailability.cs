//***************************************************************************
//* DomainName: Early Learning (EL) Interfaces (used by both models and View Models
//* FileName:   IELOrganizationAvailability.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.EarlyLearning.Interfaces
{
     /// <summary>
     /// The IELOrganizationAvailability Interface
     /// </summary>
    public partial interface IELOrganizationAvailability : IAutobahnBase
    {
        /// <summary>
        /// Nature of early childhood program, class or group in which a person is enrolled.
        /// </summary>
        System.Int32? AnnualOperatingWeeks { get; set; }

        /// <summary>
        /// Nature of early childhood program, class or group in which a person is enrolled.
        /// </summary>
        System.Int32? DaysAvailablePerWeek { get; set; }

        /// <summary>
        /// Nature of early childhood program, class or group in which a person is enrolled.
        /// </summary>
        System.Decimal? HoursAvailablePerDay { get; set; }

        /// <summary>
        /// Nature of early childhood program, class or group in which a person is enrolled.
        /// </summary>
        System.Int32? NumberOfClassrooms { get; set; }

        /// <summary>
        /// Nature of early childhood program, class or group in which a person is enrolled.
        /// </summary>
        Guid OrganizationId { get; set; }

        /// <summary>
        /// Nature of early childhood program, class or group in which a person is enrolled.
        /// </summary>
        Guid? RefEnvironmentSettingId { get; set; }

        /// <summary>
        /// Nature of early childhood program, class or group in which a person is enrolled.
        /// </summary>
        Guid? RefServiceOptionId { get; set; }

    }
}
