//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   RubricCriterionModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Authorization.Models
{
     /// <summary>
     /// The RubricCriterion Model
     /// </summary>
    public partial class RubricCriterionModel : AutobahnBase, Interfaces.IRubricCriterion
    {
        /// <summary>
        /// A textual label for category by which Rubric Criterion may be grouped.
        /// </summary>
        public System.String Category { get; set; }

        /// <summary>
        /// A textual label for category by which Rubric Criterion may be grouped.
        /// </summary>
        public System.Int32? Position { get; set; }

        /// <summary>
        /// A textual label for category by which Rubric Criterion may be grouped.
        /// </summary>
        public Guid RubricId { get; set; }

        /// <summary>
        /// A textual label for category by which Rubric Criterion may be grouped.
        /// </summary>
        public System.String Title { get; set; }

        /// <summary>
        /// A textual label for category by which Rubric Criterion may be grouped.
        /// </summary>
        public System.Decimal? Weight { get; set; }

    }
}
