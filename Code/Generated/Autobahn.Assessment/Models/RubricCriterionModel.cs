//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   RubricCriterionModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Assessment.Models
{
     /// <summary>
     /// The RubricCriterion Model
     /// </summary>
    public partial class RubricCriterionModel : AutobahnBase, Interfaces.IRubricCriterionModel
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
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
