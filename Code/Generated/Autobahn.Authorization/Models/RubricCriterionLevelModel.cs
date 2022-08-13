//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   RubricCriterionLevelModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Authorization.Models
{
     /// <summary>
     /// The RubricCriterionLevel Model
     /// </summary>
    public partial class RubricCriterionLevelModel : AutobahnBase, Interfaces.IRubricCriterionLevel
    {
        /// <summary>
        /// Text describing  one or more benchmarks that must be met to achieve a degree of achievement on a product, process, or performance task.
        /// </summary>
        public System.String Feedback { get; set; }

        /// <summary>
        /// Text describing  one or more benchmarks that must be met to achieve a degree of achievement on a product, process, or performance task.
        /// </summary>
        public System.Int32? Position { get; set; }

        /// <summary>
        /// Text describing  one or more benchmarks that must be met to achieve a degree of achievement on a product, process, or performance task.
        /// </summary>
        public System.String Quality { get; set; }

        /// <summary>
        /// Text describing  one or more benchmarks that must be met to achieve a degree of achievement on a product, process, or performance task.
        /// </summary>
        public Guid RubricCriterionId { get; set; }

        /// <summary>
        /// Text describing  one or more benchmarks that must be met to achieve a degree of achievement on a product, process, or performance task.
        /// </summary>
        public System.Decimal? Score { get; set; }

    }
}
