//**********************************************************
//* DomainName: Assessments
//* FileName:   LearnerActivityLearningResourceModel.cs
//***************************************************************************

using Autobahn.Interfaces.Assessments;
using Autobahn.Interfaces.Common;
using Autobahn.Common.Models;

namespace Autobahn.Assessments.Models
{
     /// <summary>
     /// The LearnerActivityLearningResource Model
     /// </summary>
    public partial class LearnerActivityLearningResourceModel : AutobahnBase, ILearnerActivityLearningResource
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="ILearnerActivity"/> model
        /// </summary>
        public Guid LearnerActivityId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="ILearningResource"/> model
        /// </summary>
        public Guid LearningResourceId { get; set; }

    }
}
