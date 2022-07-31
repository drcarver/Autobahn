//**********************************************************
//* DomainName: Autobahn.Assessments
//* FileName:   IRubric.cs
//**********************************************************

namespace Autobahn.Assessments.Interfaces
{
     /// <summary>
     /// The IRubric
     /// </summary>
    public partial interface IRubric
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Rubric"/> model
        /// </summary>
        Guid RubricId { get; set; }

        /// <summary>
        /// Defines the Rubric.Identifier non nullable property
        /// </summary>
        System.String Identifier { get; set; }

        /// <summary>
        /// Defines the Rubric.Title non nullable property
        /// </summary>
        System.String Title { get; set; }

        /// <summary>
        /// Defines the Rubric.UrlReference non nullable property
        /// </summary>
        System.String UrlReference { get; set; }

        /// <summary>
        /// Defines the Rubric.Description non nullable property
        /// </summary>
        System.String Description { get; set; }

        /// <summary>
        /// Defines the Rubric.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the Rubric.RecordEndDateTime nullable property
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
