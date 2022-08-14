//***************************************************************************
//* DomainName: Assessments Interfaces (used by both models and View Models
//* FileName:   IRubricCriterion.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Assessments.Interfaces
{
     /// <summary>
     /// The IRubricCriterion Interface
     /// </summary>
    public partial interface IRubricCriterion : IAutobahnBase
    {
        /// <summary>
        /// A textual label for category by which Rubric Criterion may be grouped.
        /// </summary>
        System.String Category { get; set; }

        /// <summary>
        /// A textual label for category by which Rubric Criterion may be grouped.
        /// </summary>
        System.Int32? Position { get; set; }

        /// <summary>
        /// A textual label for category by which Rubric Criterion may be grouped.
        /// </summary>
        Guid RubricId { get; set; }

        /// <summary>
        /// A textual label for category by which Rubric Criterion may be grouped.
        /// </summary>
        System.String Title { get; set; }

        /// <summary>
        /// A textual label for category by which Rubric Criterion may be grouped.
        /// </summary>
        System.Decimal? Weight { get; set; }

    }
}
