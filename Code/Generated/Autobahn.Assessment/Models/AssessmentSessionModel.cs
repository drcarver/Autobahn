//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   AssessmentSessionModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Assessment.Models
{
     /// <summary>
     /// The AssessmentSession Model
     /// </summary>
    public partial class AssessmentSessionModel : AutobahnBase, Interfaces.IAssessmentSessionModel
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="AssessmentAdministration"/> model
        /// </summary>
        public Guid? AssessmentAdministrationId { get; set; }

        /// <summary>
        /// Defines the AssessmentSession.ScheduledStartDateTime nullable property
        /// </summary>
        public System.DateTime? ScheduledStartDateTime { get; set; }

        /// <summary>
        /// Defines the AssessmentSession.ScheduledEndDateTime nullable property
        /// </summary>
        public System.DateTime? ScheduledEndDateTime { get; set; }

        /// <summary>
        /// Defines the AssessmentSession.ActualStartDateTime nullable property
        /// </summary>
        public System.DateTime? ActualStartDateTime { get; set; }

        /// <summary>
        /// Defines the AssessmentSession.ActualEndDateTime nullable property
        /// </summary>
        public System.DateTime? ActualEndDateTime { get; set; }

        /// <summary>
        /// Defines the AssessmentSession.AllottedTime nullable property
        /// </summary>
        public System.TimeSpan? AllottedTime { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentSessionType"/> model
        /// </summary>
        public Guid? RefAssessmentSessionTypeId { get; set; }

        /// <summary>
        /// Defines the AssessmentSession.SecurityIssue non nullable property
        /// </summary>
        public System.String SecurityIssue { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentSessionSpecialCircumstanceType"/> model
        /// </summary>
        public Guid? RefAssessmentSessionSpecialCircumstanceTypeId { get; set; }

        /// <summary>
        /// Defines the AssessmentSession.SpecialEventDescription non nullable property
        /// </summary>
        public System.String SpecialEventDescription { get; set; }

        /// <summary>
        /// Defines the AssessmentSession.Location non nullable property
        /// </summary>
        public System.String Location { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="Organization"/> model
        /// </summary>
        public Guid? OrganizationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="Lea_Organization"/> model
        /// </summary>
        public Guid? Lea_OrganizationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="School_Organization"/> model
        /// </summary>
        public Guid? School_OrganizationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
