//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   LearnerActivity_LearningResourceModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Authorization.Models
{
     /// <summary>
     /// The LearnerActivity_LearningResource Model
     /// </summary>
    public partial class LearnerActivity_LearningResourceModel : AutobahnBase, Interfaces.ILearnerActivity_LearningResource
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
