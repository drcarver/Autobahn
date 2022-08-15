//**********************************************************
//* DomainName: Assessments
//* FileName:   LearnerActionModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Assessments.Models
{
     /// <summary>
     /// The LearnerAction Model
     /// </summary>
    public partial class LearnerActionModel : AutobahnBase, Interfaces.ILearnerAction
    {
        /// <summary>
        /// The type of action taken by the learner.
        /// </summary>
        public Guid? RefLearnerActionTypeId { get; set; }

    }
}
