//***************************************************************************
//* DomainName: Early Learning (EL) Interfaces (used by both models and View Models
//* FileName:   IELClassSection.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.EarlyLearning.Interfaces
{
     /// <summary>
     /// The IELClassSection Interface
     /// </summary>
    public partial interface IELClassSection : IAutobahnBase
    {
        /// <summary>
        /// Nature of early childhood program, class or group in which a person is enrolled.
        /// </summary>
        System.Int32? DaysAvailablePerWeek { get; set; }

        /// <summary>
        /// Nature of early childhood program, class or group in which a person is enrolled.
        /// </summary>
        System.Int32? ELProgramAnnualOperatingWeeks { get; set; }

        /// <summary>
        /// Nature of early childhood program, class or group in which a person is enrolled.
        /// </summary>
        System.Int32? GroupSize { get; set; }

        /// <summary>
        /// Nature of early childhood program, class or group in which a person is enrolled.
        /// </summary>
        System.Decimal? HoursAvailablePerDay { get; set; }

        /// <summary>
        /// Nature of early childhood program, class or group in which a person is enrolled.
        /// </summary>
        System.Boolean? LanguageTranslationPolicy { get; set; }

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
