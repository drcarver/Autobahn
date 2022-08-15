//***************************************************************************
//* DomainName: Assessments Interfaces (used by both models and View Models
//* FileName:   ILearnerAction.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Assessments.Interfaces
{
     /// <summary>
     /// The ILearnerAction Interface
     /// </summary>
    public partial interface ILearnerAction : IAutobahnBase
    {
        /// <summary>
        /// The type of action taken by the learner.
        /// </summary>
        Guid? RefLearnerActionTypeId { get; set; }

    }
}
