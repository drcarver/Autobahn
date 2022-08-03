//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   IRubricCriterion.cs
//**********************************************************

namespace Autobahn.Assessment.Interfaces
{
     /// <summary>
     /// The IRubricCriterion
     /// </summary>
    public partial interface IRubricCriterion
    {
        /// <summary>
        /// Defines the RubricCriterion.Category non nullable property
        /// </summary>
        System.String Category { get; set; }

        /// <summary>
        /// Defines the RubricCriterion.Title non nullable property
        /// </summary>
        System.String Title { get; set; }

        /// <summary>
        /// Defines the RubricCriterion.Description non nullable property
        /// </summary>
        System.String Description { get; set; }

        /// <summary>
        /// Defines the RubricCriterion.Weight nullable property
        /// </summary>
        System.Decimal? Weight { get; set; }

        /// <summary>
        /// Defines the RubricCriterion.Position nullable property
        /// </summary>
        System.Int32? Position { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="Rubric"/> model
        /// </summary>
        Guid RubricId { get; set; }

        /// <summary>
        /// Defines the RubricCriterion.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RubricCriterion.RecordEndDateTime nullable property
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
