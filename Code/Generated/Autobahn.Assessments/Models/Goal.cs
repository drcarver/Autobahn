//**********************************************************
//* DomainName: Autobahn.Assessments
//* FileName:   Goal.cs
//**********************************************************

using Autobahn.Assessments.Interfaces;

namespace Autobahn.Assessments.Models
{
     /// <summary>
     /// The Goal
     /// </summary>
    public partial class Goal : IGoal
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Goal"/> model
        /// </summary>
        public Guid GoalId { get; set; }

        /// <summary>
        /// Defines the Goal.Description non nullable property
        /// </summary>
        public System.String Description { get; set; }

        /// <summary>
        /// Defines the Goal.StartDate nullable property
        /// </summary>
        public System.DateTime? StartDate { get; set; }

        /// <summary>
        /// Defines the Goal.EndDate nullable property
        /// </summary>
        public System.DateTime? EndDate { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="OrganizationPersonRole"/> model
        /// </summary>
        public Guid? OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="CompetencySet"/> model
        /// </summary>
        public Guid? CompetencySetId { get; set; }

        /// <summary>
        /// Defines the Goal.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the Goal.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatus"/> model
        /// </summary>
        public Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
