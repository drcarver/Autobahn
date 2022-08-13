//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12StudentDisciplineModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The K12StudentDiscipline Model
     /// </summary>
    public partial class K12StudentDisciplineModel : AutobahnBase, Interfaces.IK12StudentDiscipline
    {
        /// <summary>
        /// The year, month and day on which a discipline action ends.
        /// </summary>
        public System.DateTime? DisciplinaryActionEndDate { get; set; }

        /// <summary>
        /// The year, month and day on which a discipline action ends.
        /// </summary>
        public System.DateTime? DisciplinaryActionStartDate { get; set; }

        /// <summary>
        /// The year, month and day on which a discipline action ends.
        /// </summary>
        public System.Decimal? DurationOfDisciplinaryAction { get; set; }

        /// <summary>
        /// The year, month and day on which a discipline action ends.
        /// </summary>
        public System.Boolean? EducationalServicesAfterRemoval { get; set; }

        /// <summary>
        /// The year, month and day on which a discipline action ends.
        /// </summary>
        public System.Boolean? FullYearExpulsion { get; set; }

        /// <summary>
        /// The year, month and day on which a discipline action ends.
        /// </summary>
        public System.Boolean? IEPPlacementMeetingIndicator { get; set; }

        /// <summary>
        /// The year, month and day on which a discipline action ends.
        /// </summary>
        public Guid? IncidentId { get; set; }

        /// <summary>
        /// The year, month and day on which a discipline action ends.
        /// </summary>
        public Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// The year, month and day on which a discipline action ends.
        /// </summary>
        public Guid? RefDisciplinaryActionTakenId { get; set; }

        /// <summary>
        /// The year, month and day on which a discipline action ends.
        /// </summary>
        public Guid? RefDisciplineLengthDifferenceReasonId { get; set; }

        /// <summary>
        /// The year, month and day on which a discipline action ends.
        /// </summary>
        public Guid? RefDisciplineMethodFirearmsId { get; set; }

        /// <summary>
        /// The year, month and day on which a discipline action ends.
        /// </summary>
        public Guid? RefDisciplineMethodOfCwdId { get; set; }

        /// <summary>
        /// The year, month and day on which a discipline action ends.
        /// </summary>
        public Guid? RefDisciplineReasonId { get; set; }

        /// <summary>
        /// The year, month and day on which a discipline action ends.
        /// </summary>
        public Guid? RefIDEADisciplineMethodFirearmId { get; set; }

        /// <summary>
        /// The year, month and day on which a discipline action ends.
        /// </summary>
        public Guid? RefIdeaInterimRemovalId { get; set; }

        /// <summary>
        /// The year, month and day on which a discipline action ends.
        /// </summary>
        public Guid? RefIdeaInterimRemovalReasonId { get; set; }

        /// <summary>
        /// The year, month and day on which a discipline action ends.
        /// </summary>
        public System.Boolean? RelatedToZeroTolerancePolicy { get; set; }

        /// <summary>
        /// The year, month and day on which a discipline action ends.
        /// </summary>
        public System.Boolean? ShortenedExpulsion { get; set; }

    }
}
