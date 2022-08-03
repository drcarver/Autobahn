//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   IRubricCriterionLevel.cs
//**********************************************************

namespace Autobahn.Assessment.Interfaces
{
     /// <summary>
     /// The IRubricCriterionLevel
     /// </summary>
    public partial interface IRubricCriterionLevel
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

        /// <summary>
        /// Defines the RubricCriterionLevel.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RubricCriterionLevel.RecordEndDateTime nullable property
        /// </summary>
        System.DateTime? RecordEndDateTime { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatus"/> model
        /// </summary>
        Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        Guid? DataCollectionId { get; set; }

    }
}
