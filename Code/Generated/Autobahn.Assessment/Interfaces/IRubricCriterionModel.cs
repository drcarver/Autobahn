//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   IRubricCriterionModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Assessment.Interfaces
{
     /// <summary>
     /// The IRubricCriterionModel Interface
     /// </summary>
    public partial interface IRubricCriterionModel : IAutobahnBase
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

    }
}
