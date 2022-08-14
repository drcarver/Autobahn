//***************************************************************************
//* DomainName: Assessments Interfaces (used by both models and View Models
//* FileName:   IGoalMeasurement.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Assessments.Interfaces
{
     /// <summary>
     /// The IGoalMeasurement Interface
     /// </summary>
    public partial interface IGoalMeasurement : IAutobahnBase
    {
        /// <summary>
        /// One or more statements that describes the criteria used by teachers and students to check for attainment of a goal.
        /// </summary>
        Guid GoalId { get; set; }

        /// <summary>
        /// One or more statements that describes the criteria used by teachers and students to check for attainment of a goal.
        /// </summary>
        Guid? RefGoalMeasurementTypeId { get; set; }

        /// <summary>
        /// One or more statements that describes the criteria used by teachers and students to check for attainment of a goal.
        /// </summary>
        System.String Schedule { get; set; }

        /// <summary>
        /// One or more statements that describes the criteria used by teachers and students to check for attainment of a goal.
        /// </summary>
        System.String SuccessCriteria { get; set; }

    }
}
