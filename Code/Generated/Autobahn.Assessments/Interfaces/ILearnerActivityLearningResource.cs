//***************************************************************************
//* DomainName: Assessments Interfaces (used by both models and View Models
//* FileName:   ILearnerActivityLearningResource.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Assessments.Interfaces
{
     /// <summary>
     /// The ILearnerActivityLearningResource Interface
     /// </summary>
    public partial interface ILearnerActivityLearningResource : IAutobahnBase
    {
        /// <summary>
        /// 
        /// </summary>
         RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        Guid? RecordStartDateTime { get; set; }

    }
}
