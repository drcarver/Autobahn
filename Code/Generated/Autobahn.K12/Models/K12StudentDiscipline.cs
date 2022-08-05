//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   K12StudentDiscipline.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The K12StudentDiscipline
     /// </summary>
    public partial class K12StudentDiscipline : AutobahnBase, Interfaces.IK12StudentDiscipline
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefDisciplineReason"/> model
        /// </summary>
        public Guid? RefDisciplineReasonId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefDisciplinaryActionTaken"/> model
        /// </summary>
        public Guid? RefDisciplinaryActionTakenId { get; set; }

        /// <summary>
        /// Defines the K12StudentDiscipline.DisciplinaryActionStartDate nullable property
        /// </summary>
        public System.DateTime? DisciplinaryActionStartDate { get; set; }

        /// <summary>
        /// Defines the K12StudentDiscipline.DisciplinaryActionEndDate nullable property
        /// </summary>
        public System.DateTime? DisciplinaryActionEndDate { get; set; }

        /// <summary>
        /// Defines the K12StudentDiscipline.DurationOfDisciplinaryAction nullable property
        /// </summary>
        public System.Decimal? DurationOfDisciplinaryAction { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefDisciplineLengthDifferenceReason"/> model
        /// </summary>
        public Guid? RefDisciplineLengthDifferenceReasonId { get; set; }

        /// <summary>
        /// Defines the K12StudentDiscipline.FullYearExpulsion nullable property
        /// </summary>
        public System.Boolean? FullYearExpulsion { get; set; }

        /// <summary>
        /// Defines the K12StudentDiscipline.ShortenedExpulsion nullable property
        /// </summary>
        public System.Boolean? ShortenedExpulsion { get; set; }

        /// <summary>
        /// Defines the K12StudentDiscipline.EducationalServicesAfterRemoval nullable property
        /// </summary>
        public System.Boolean? EducationalServicesAfterRemoval { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefeaInterimRemoval"/> model
        /// </summary>
        public Guid? RefIdeaInterimRemovalId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefeaInterimRemovalReason"/> model
        /// </summary>
        public Guid? RefIdeaInterimRemovalReasonId { get; set; }

        /// <summary>
        /// Defines the K12StudentDiscipline.RelatedToZeroTolerancePolicy nullable property
        /// </summary>
        public System.Boolean? RelatedToZeroTolerancePolicy { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="Incident"/> model
        /// </summary>
        public Guid? IncidentId { get; set; }

        /// <summary>
        /// Defines the K12StudentDiscipline.IEPPlacementMeetingIndicator nullable property
        /// </summary>
        public System.Boolean? IEPPlacementMeetingIndicator { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefDisciplineMethodFirearms"/> model
        /// </summary>
        public Guid? RefDisciplineMethodFirearmsId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefDisciplineMethodOfCwd"/> model
        /// </summary>
        public Guid? RefDisciplineMethodOfCwdId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIDEADisciplineMethodFirearm"/> model
        /// </summary>
        public Guid? RefIDEADisciplineMethodFirearmId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
