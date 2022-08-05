//**********************************************************
//* DomainName: Autobahn.EarlyLearning
//* FileName:   ELClassSection.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.EarlyLearning.Models
{
     /// <summary>
     /// The ELClassSection
     /// </summary>
    public partial class ELClassSection : AutobahnBase, Interfaces.IELClassSection
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Organization"/> model
        /// </summary>
        public Guid OrganizationId { get; set; }

        /// <summary>
        /// Defines the ELClassSection.HoursAvailablePerDay nullable property
        /// </summary>
        public System.Decimal? HoursAvailablePerDay { get; set; }

        /// <summary>
        /// Defines the ELClassSection.DaysAvailablePerWeek nullable property
        /// </summary>
        public System.Int32? DaysAvailablePerWeek { get; set; }

        /// <summary>
        /// Defines the ELClassSection.ELProgramAnnualOperatingWeeks nullable property
        /// </summary>
        public System.Int32? ELProgramAnnualOperatingWeeks { get; set; }

        /// <summary>
        /// Defines the ELClassSection.LanguageTranslationPolicy nullable property
        /// </summary>
        public System.Boolean? LanguageTranslationPolicy { get; set; }

        /// <summary>
        /// Defines the ELClassSection.GroupSize nullable property
        /// </summary>
        public System.Int32? GroupSize { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefServiceOption"/> model
        /// </summary>
        public Guid? RefServiceOptionId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefEnvironmentSetting"/> model
        /// </summary>
        public Guid? RefEnvironmentSettingId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
