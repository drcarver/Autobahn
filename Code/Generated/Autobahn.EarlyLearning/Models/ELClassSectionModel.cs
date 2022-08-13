//**********************************************************
//* DomainName: Early Learning (EL)
//* FileName:   ELClassSectionModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.EarlyLearning.Models
{
     /// <summary>
     /// The ELClassSection Model
     /// </summary>
    public partial class ELClassSectionModel : AutobahnBase, Interfaces.IELClassSection
    {
        /// <summary>
        /// Nature of early childhood program, class or group in which a person is enrolled.
        /// </summary>
        public System.Int32? DaysAvailablePerWeek { get; set; }

        /// <summary>
        /// Nature of early childhood program, class or group in which a person is enrolled.
        /// </summary>
        public System.Int32? ELProgramAnnualOperatingWeeks { get; set; }

        /// <summary>
        /// Nature of early childhood program, class or group in which a person is enrolled.
        /// </summary>
        public System.Int32? GroupSize { get; set; }

        /// <summary>
        /// Nature of early childhood program, class or group in which a person is enrolled.
        /// </summary>
        public System.Decimal? HoursAvailablePerDay { get; set; }

        /// <summary>
        /// Nature of early childhood program, class or group in which a person is enrolled.
        /// </summary>
        public System.Boolean? LanguageTranslationPolicy { get; set; }

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
