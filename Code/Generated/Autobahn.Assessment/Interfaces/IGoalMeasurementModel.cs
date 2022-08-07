//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   IGoalMeasurementModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Assessment.Interfaces
{
     /// <summary>
     /// The IGoalMeasurementModel Interface
     /// </summary>
    public partial interface IGoalMeasurementModel : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Goal"/> model
        /// </summary>
        Guid GoalId { get; set; }

        /// <summary>
        /// Defines the GoalMeasurement.Description non nullable property
        /// </summary>
        System.String Description { get; set; }

        /// <summary>
        /// Defines the GoalMeasurement.Schedule non nullable property
        /// </summary>
        System.String Schedule { get; set; }

        /// <summary>
        /// Defines the GoalMeasurement.SuccessCriteria non nullable property
        /// </summary>
        System.String SuccessCriteria { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefGoalMeasurementType"/> model
        /// </summary>
        Guid? RefGoalMeasurementTypeId { get; set; }

    }
}
