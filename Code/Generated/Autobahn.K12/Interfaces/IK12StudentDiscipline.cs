//***************************************************************************
//* DomainName: Elementary and Secondary (K12) Interfaces (used by both models and View Models
//* FileName:   IK12StudentDiscipline.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.K12.Interfaces
{
     /// <summary>
     /// The IK12StudentDiscipline Interface
     /// </summary>
    public partial interface IK12StudentDiscipline : IAutobahnBase
    {
        /// <summary>
        /// The year, month and day on which a discipline action ends.
        /// </summary>
        System.DateTime? DisciplinaryActionEndDate { get; set; }

        /// <summary>
        /// The year, month and day on which a discipline action ends.
        /// </summary>
        System.DateTime? DisciplinaryActionStartDate { get; set; }

        /// <summary>
        /// The year, month and day on which a discipline action ends.
        /// </summary>
        System.Decimal? DurationOfDisciplinaryAction { get; set; }

        /// <summary>
        /// The year, month and day on which a discipline action ends.
        /// </summary>
        System.Boolean? EducationalServicesAfterRemoval { get; set; }

        /// <summary>
        /// The year, month and day on which a discipline action ends.
        /// </summary>
        System.Boolean? FullYearExpulsion { get; set; }

        /// <summary>
        /// The year, month and day on which a discipline action ends.
        /// </summary>
        System.Boolean? IEPPlacementMeetingIndicator { get; set; }

        /// <summary>
        /// The year, month and day on which a discipline action ends.
        /// </summary>
        Guid? IncidentId { get; set; }

        /// <summary>
        /// The year, month and day on which a discipline action ends.
        /// </summary>
        Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// The year, month and day on which a discipline action ends.
        /// </summary>
        Guid? RefDisciplinaryActionTakenId { get; set; }

        /// <summary>
        /// The year, month and day on which a discipline action ends.
        /// </summary>
        Guid? RefDisciplineLengthDifferenceReasonId { get; set; }

        /// <summary>
        /// The year, month and day on which a discipline action ends.
        /// </summary>
        Guid? RefDisciplineMethodFirearmsId { get; set; }

        /// <summary>
        /// The year, month and day on which a discipline action ends.
        /// </summary>
        Guid? RefDisciplineMethodOfCwdId { get; set; }

        /// <summary>
        /// The year, month and day on which a discipline action ends.
        /// </summary>
        Guid? RefDisciplineReasonId { get; set; }

        /// <summary>
        /// The year, month and day on which a discipline action ends.
        /// </summary>
        Guid? RefIDEADisciplineMethodFirearmId { get; set; }

        /// <summary>
        /// The year, month and day on which a discipline action ends.
        /// </summary>
        Guid? RefIdeaInterimRemovalId { get; set; }

        /// <summary>
        /// The year, month and day on which a discipline action ends.
        /// </summary>
        Guid? RefIdeaInterimRemovalReasonId { get; set; }

        /// <summary>
        /// The year, month and day on which a discipline action ends.
        /// </summary>
        System.Boolean? RelatedToZeroTolerancePolicy { get; set; }

        /// <summary>
        /// The year, month and day on which a discipline action ends.
        /// </summary>
        System.Boolean? ShortenedExpulsion { get; set; }

    }
}
