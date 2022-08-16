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
        /// 
        /// </summary>
         LearnerActionActorIdentifier { get; set; }

        /// <summary>
        /// 
        /// </summary>
         LearnerActionDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
         LearnerActionObjectDescription { get; set; }

        /// <summary>
        /// 
        /// </summary>
         LearnerActionObjectIdentifier { get; set; }

        /// <summary>
        /// 
        /// </summary>
         LearnerActionObjectType { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RecordStartDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        Guid? RefLearnerActionTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         Value { get; set; }

    }
}
