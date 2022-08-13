//***************************************************************************
//* DomainName: Authentication and Authorization Interfaces (used by both models and View Models
//* FileName:   IRubricCriterionLevel.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Authorization.Interfaces
{
     /// <summary>
     /// The IRubricCriterionLevel Interface
     /// </summary>
    public partial interface IRubricCriterionLevel : IAutobahnBase
    {
        /// <summary>
        /// Text describing  one or more benchmarks that must be met to achieve a degree of achievement on a product, process, or performance task.
        /// </summary>
        System.String Feedback { get; set; }

        /// <summary>
        /// Text describing  one or more benchmarks that must be met to achieve a degree of achievement on a product, process, or performance task.
        /// </summary>
        System.Int32? Position { get; set; }

        /// <summary>
        /// Text describing  one or more benchmarks that must be met to achieve a degree of achievement on a product, process, or performance task.
        /// </summary>
        System.String Quality { get; set; }

        /// <summary>
        /// Text describing  one or more benchmarks that must be met to achieve a degree of achievement on a product, process, or performance task.
        /// </summary>
        Guid RubricCriterionId { get; set; }

        /// <summary>
        /// Text describing  one or more benchmarks that must be met to achieve a degree of achievement on a product, process, or performance task.
        /// </summary>
        System.Decimal? Score { get; set; }

    }
}
