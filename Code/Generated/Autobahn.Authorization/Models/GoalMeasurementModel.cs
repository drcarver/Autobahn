//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   GoalMeasurementModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Authorization.Models
{
     /// <summary>
     /// The GoalMeasurement Model
     /// </summary>
    public partial class GoalMeasurementModel : AutobahnBase, Interfaces.IGoalMeasurement
    {
        /// <summary>
        /// One or more statements that describes the criteria used by teachers and students to check for attainment of a goal.
        /// </summary>
        public Guid GoalId { get; set; }

        /// <summary>
        /// One or more statements that describes the criteria used by teachers and students to check for attainment of a goal.
        /// </summary>
        public Guid? RefGoalMeasurementTypeId { get; set; }

        /// <summary>
        /// One or more statements that describes the criteria used by teachers and students to check for attainment of a goal.
        /// </summary>
        public System.String Schedule { get; set; }

        /// <summary>
        /// One or more statements that describes the criteria used by teachers and students to check for attainment of a goal.
        /// </summary>
        public System.String SuccessCriteria { get; set; }

    }
}
