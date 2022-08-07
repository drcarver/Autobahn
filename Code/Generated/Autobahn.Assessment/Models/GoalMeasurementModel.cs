//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   GoalMeasurementModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Assessment.Models
{
     /// <summary>
     /// The GoalMeasurement Model
     /// </summary>
    public partial class GoalMeasurementModel : AutobahnBase, Interfaces.IGoalMeasurementModel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Goal"/> model
        /// </summary>
        public Guid GoalId { get; set; }

        /// <summary>
        /// Defines the GoalMeasurement.Description non nullable property
        /// </summary>
        public System.String Description { get; set; }

        /// <summary>
        /// Defines the GoalMeasurement.Schedule non nullable property
        /// </summary>
        public System.String Schedule { get; set; }

        /// <summary>
        /// Defines the GoalMeasurement.SuccessCriteria non nullable property
        /// </summary>
        public System.String SuccessCriteria { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefGoalMeasurementType"/> model
        /// </summary>
        public Guid? RefGoalMeasurementTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
