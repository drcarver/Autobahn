//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   RubricCriterion.cs
//**********************************************************

using Autobahn.Assessment.Interfaces;

namespace Autobahn.Assessment.Models
{
     /// <summary>
     /// The RubricCriterion
     /// </summary>
    public partial class RubricCriterion : IRubricCriterion
    {
        /// <summary>
        /// Defines the RubricCriterion.Category non nullable property
        /// </summary>
        public System.String Category { get; set; }

        /// <summary>
        /// Defines the RubricCriterion.Title non nullable property
        /// </summary>
        public System.String Title { get; set; }

        /// <summary>
        /// Defines the RubricCriterion.Description non nullable property
        /// </summary>
        public System.String Description { get; set; }

        /// <summary>
        /// Defines the RubricCriterion.Weight nullable property
        /// </summary>
        public System.Decimal? Weight { get; set; }

        /// <summary>
        /// Defines the RubricCriterion.Position nullable property
        /// </summary>
        public System.Int32? Position { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="Rubric"/> model
        /// </summary>
        public Guid RubricId { get; set; }

        /// <summary>
        /// Defines the RubricCriterion.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RubricCriterion.RecordEndDateTime nullable property
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
