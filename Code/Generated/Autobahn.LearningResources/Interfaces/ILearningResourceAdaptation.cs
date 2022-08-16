//***************************************************************************
//* DomainName: Learning Resources Interfaces (used by both models and View Models
//* FileName:   ILearningResourceAdaptation.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.LearningResources.Interfaces
{
     /// <summary>
     /// The ILearningResourceAdaptation Interface
     /// </summary>
    public partial interface ILearningResourceAdaptation : IAutobahnBase
    {
        /// <summary>
        /// 
        /// </summary>
        Guid? AdaptationURL { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RecordStartDateTime { get; set; }

    }
}
