//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   IK12StudentDiscipline.cs
//**********************************************************

namespace Autobahn.K12.Interfaces
{
     /// <summary>
     /// The IK12StudentDiscipline
     /// </summary>
    public partial interface IK12StudentDiscipline
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationPersonRole"/> model
        /// </summary>
        Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefDisciplineReason"/> model
        /// </summary>
        Guid? RefDisciplineReasonId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefDisciplinaryActionTaken"/> model
        /// </summary>
        Guid? RefDisciplinaryActionTakenId { get; set; }

        /// <summary>
        /// Defines the K12StudentDiscipline.DisciplinaryActionStartDate nullable property
        /// </summary>
        System.DateTime? DisciplinaryActionStartDate { get; set; }

        /// <summary>
        /// Defines the K12StudentDiscipline.DisciplinaryActionEndDate nullable property
        /// </summary>
        System.DateTime? DisciplinaryActionEndDate { get; set; }

        /// <summary>
        /// Defines the K12StudentDiscipline.DurationOfDisciplinaryAction nullable property
        /// </summary>
        System.Decimal? DurationOfDisciplinaryAction { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefDisciplineLengthDifferenceReason"/> model
        /// </summary>
        Guid? RefDisciplineLengthDifferenceReasonId { get; set; }

        /// <summary>
        /// Defines the K12StudentDiscipline.FullYearExpulsion nullable property
        /// </summary>
        System.Boolean? FullYearExpulsion { get; set; }

        /// <summary>
        /// Defines the K12StudentDiscipline.ShortenedExpulsion nullable property
        /// </summary>
        System.Boolean? ShortenedExpulsion { get; set; }

        /// <summary>
        /// Defines the K12StudentDiscipline.EducationalServicesAfterRemoval nullable property
        /// </summary>
        System.Boolean? EducationalServicesAfterRemoval { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefeaInterimRemoval"/> model
        /// </summary>
        Guid? RefIdeaInterimRemovalId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefeaInterimRemovalReason"/> model
        /// </summary>
        Guid? RefIdeaInterimRemovalReasonId { get; set; }

        /// <summary>
        /// Defines the K12StudentDiscipline.RelatedToZeroTolerancePolicy nullable property
        /// </summary>
        System.Boolean? RelatedToZeroTolerancePolicy { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="Incident"/> model
        /// </summary>
        Guid? IncidentId { get; set; }

        /// <summary>
        /// Defines the K12StudentDiscipline.IEPPlacementMeetingIndicator nullable property
        /// </summary>
        System.Boolean? IEPPlacementMeetingIndicator { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefDisciplineMethodFirearms"/> model
        /// </summary>
        Guid? RefDisciplineMethodFirearmsId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefDisciplineMethodOfCwd"/> model
        /// </summary>
        Guid? RefDisciplineMethodOfCwdId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIDEADisciplineMethodFirearm"/> model
        /// </summary>
        Guid? RefIDEADisciplineMethodFirearmId { get; set; }

        /// <summary>
        /// Defines the K12StudentDiscipline.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the K12StudentDiscipline.RecordEndDateTime nullable property
        /// </summary>
        System.DateTime? RecordEndDateTime { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatus"/> model
        /// </summary>
        Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        Guid? DataCollectionId { get; set; }

    }
}
