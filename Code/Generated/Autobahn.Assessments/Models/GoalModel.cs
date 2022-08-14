//**********************************************************
//* DomainName: Assessments
//* FileName:   GoalModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Assessments.Models
{
     /// <summary>
     /// The Goal Model
     /// </summary>
    public partial class GoalModel : AutobahnBase, Interfaces.IGoal
    {
        /// <summary>
        /// A statement that describes the desired outcomes.
        /// </summary>
        public Guid? CompetencySetId { get; set; }

        /// <summary>
        /// A statement that describes the desired outcomes.
        /// </summary>
        public System.DateTime? EndDate { get; set; }

        /// <summary>
        /// A statement that describes the desired outcomes.
        /// </summary>
        public Guid? OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// A statement that describes the desired outcomes.
        /// </summary>
        public System.DateTime? StartDate { get; set; }

    }
}
