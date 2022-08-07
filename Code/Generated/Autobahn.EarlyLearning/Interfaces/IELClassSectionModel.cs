//**********************************************************
//* DomainName: Autobahn.EarlyLearning
//* FileName:   IELClassSectionModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.EarlyLearning.Interfaces
{
     /// <summary>
     /// The IELClassSectionModel Interface
     /// </summary>
    public partial interface IELClassSectionModel : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Organization"/> model
        /// </summary>
        Guid OrganizationId { get; set; }

        /// <summary>
        /// Defines the ELClassSection.HoursAvailablePerDay nullable property
        /// </summary>
        System.Decimal? HoursAvailablePerDay { get; set; }

        /// <summary>
        /// Defines the ELClassSection.DaysAvailablePerWeek nullable property
        /// </summary>
        System.Int32? DaysAvailablePerWeek { get; set; }

        /// <summary>
        /// Defines the ELClassSection.ELProgramAnnualOperatingWeeks nullable property
        /// </summary>
        System.Int32? ELProgramAnnualOperatingWeeks { get; set; }

        /// <summary>
        /// Defines the ELClassSection.LanguageTranslationPolicy nullable property
        /// </summary>
        System.Boolean? LanguageTranslationPolicy { get; set; }

        /// <summary>
        /// Defines the ELClassSection.GroupSize nullable property
        /// </summary>
        System.Int32? GroupSize { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefServiceOption"/> model
        /// </summary>
        Guid? RefServiceOptionId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefEnvironmentSetting"/> model
        /// </summary>
        Guid? RefEnvironmentSettingId { get; set; }

    }
}
