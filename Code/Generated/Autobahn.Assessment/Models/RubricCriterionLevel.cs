//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   RubricCriterionLevel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Assessment.Models
{
     /// <summary>
     /// The RubricCriterionLevel
     /// </summary>
    public partial class RubricCriterionLevel : AutobahnBase, Interfaces.IRubricCriterionLevel
    {
        /// <summary>
        /// Defines the RubricCriterionLevel.Description non nullable property
        /// </summary>
        public System.String Description { get; set; }

        /// <summary>
        /// Defines the RubricCriterionLevel.Quality non nullable property
        /// </summary>
        public System.String Quality { get; set; }

        /// <summary>
        /// Defines the RubricCriterionLevel.Score nullable property
        /// </summary>
        public System.Decimal? Score { get; set; }

        /// <summary>
        /// Defines the RubricCriterionLevel.Feedback non nullable property
        /// </summary>
        public System.String Feedback { get; set; }

        /// <summary>
        /// Defines the RubricCriterionLevel.Position nullable property
        /// </summary>
        public System.Int32? Position { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="RubricCriterion"/> model
        /// </summary>
        public Guid RubricCriterionId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
