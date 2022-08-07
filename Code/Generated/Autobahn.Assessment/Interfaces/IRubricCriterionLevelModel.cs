//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   IRubricCriterionLevelModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Assessment.Interfaces
{
     /// <summary>
     /// The IRubricCriterionLevelModel Interface
     /// </summary>
    public partial interface IRubricCriterionLevelModel : IAutobahnBase
    {
        /// <summary>
        /// Defines the RubricCriterionLevel.Description non nullable property
        /// </summary>
        System.String Description { get; set; }

        /// <summary>
        /// Defines the RubricCriterionLevel.Quality non nullable property
        /// </summary>
        System.String Quality { get; set; }

        /// <summary>
        /// Defines the RubricCriterionLevel.Score nullable property
        /// </summary>
        System.Decimal? Score { get; set; }

        /// <summary>
        /// Defines the RubricCriterionLevel.Feedback non nullable property
        /// </summary>
        System.String Feedback { get; set; }

        /// <summary>
        /// Defines the RubricCriterionLevel.Position nullable property
        /// </summary>
        System.Int32? Position { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="RubricCriterion"/> model
        /// </summary>
        Guid RubricCriterionId { get; set; }

    }
}
