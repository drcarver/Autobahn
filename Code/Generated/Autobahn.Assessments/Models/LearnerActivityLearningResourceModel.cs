//**********************************************************
//* DomainName: Assessments
//* FileName:   LearnerActivityLearningResourceModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Assessments.Models
{
     /// <summary>
     /// The LearnerActivityLearningResource Model
     /// </summary>
    public partial class LearnerActivityLearningResourceModel : AutobahnBase, Interfaces.ILearnerActivityLearningResource
    {
        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        public Guid LearnerActivityId { get; set; }

        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        public Guid LearningResourceId { get; set; }

    }
}
