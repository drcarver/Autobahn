//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   IDEAEligibilityEvaluationCategoryModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Authorization.Models
{
     /// <summary>
     /// The IDEAEligibilityEvaluationCategory Model
     /// </summary>
    public partial class IDEAEligibilityEvaluationCategoryModel : AutobahnBase, Interfaces.IIDEAEligibilityEvaluationCategory
    {
        /// <summary>
        /// Category of evaluation used for IDEA eligibility.
        /// </summary>
        public Guid EligibilityEvaluationId { get; set; }

        /// <summary>
        /// Category of evaluation used for IDEA eligibility.
        /// </summary>
        public Guid RefIDEAEligibilityEvaluationCategoryId { get; set; }

    }
}
