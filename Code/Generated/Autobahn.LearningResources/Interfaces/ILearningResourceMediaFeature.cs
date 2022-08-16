//***************************************************************************
//* DomainName: Learning Resources Interfaces (used by both models and View Models
//* FileName:   ILearningResourceMediaFeature.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.LearningResources.Interfaces
{
     /// <summary>
     /// The ILearningResourceMediaFeature Interface
     /// </summary>
    public partial interface ILearningResourceMediaFeature : IAutobahnBase
    {
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
        Guid? RefLearningResourceMediaFeatureTypeId { get; set; }

    }
}
