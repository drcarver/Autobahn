//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   IDEAEligibilityEvaluationCategoryModel.cs
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.K12.Interfaces
{
     /// <summary>
     /// The IDEAEligibilityEvaluationCategory Model
     /// </summary>
    public partial class IDEAEligibilityEvaluationCategoryModel : AutobahnBase, Interfaces.IIDEAEligibilityEvaluationCategory
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="IEligibilityEvaluation"/> model
        /// </summary>
        public Guid EligibilityEvaluationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefIDEAEligibilityEvaluationCategory"/> model
        /// </summary>
        public Guid RefIDEAEligibilityEvaluationCategoryId { get; set; }

    }
}
