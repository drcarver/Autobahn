//**********************************************************
//* DomainName: Autobahn.Assessments
//* FileName:   Rubric.cs
//**********************************************************

using Autobahn.Assessments.Interfaces;

namespace Autobahn.Assessments.Models
{
     /// <summary>
     /// The Rubric
     /// </summary>
    public partial class Rubric : IRubric
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Rubric"/> model
        /// </summary>
        public Guid RubricId { get; set; }

        /// <summary>
        /// Defines the Rubric.Identifier non nullable property
        /// </summary>
        public System.String Identifier { get; set; }

        /// <summary>
        /// Defines the Rubric.Title non nullable property
        /// </summary>
        public System.String Title { get; set; }

        /// <summary>
        /// Defines the Rubric.UrlReference non nullable property
        /// </summary>
        public System.String UrlReference { get; set; }

        /// <summary>
        /// Defines the Rubric.Description non nullable property
        /// </summary>
        public System.String Description { get; set; }

        /// <summary>
        /// Defines the Rubric.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the Rubric.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatus"/> model
        /// </summary>
        public Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
