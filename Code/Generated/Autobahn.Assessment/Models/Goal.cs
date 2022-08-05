//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   Goal.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Assessment.Models
{
     /// <summary>
     /// The Goal
     /// </summary>
    public partial class Goal : AutobahnBase, Interfaces.IGoal
    {
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
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
