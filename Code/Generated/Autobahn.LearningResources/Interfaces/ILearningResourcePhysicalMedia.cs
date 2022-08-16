//***************************************************************************
//* DomainName: Learning Resources Interfaces (used by both models and View Models
//* FileName:   ILearningResourcePhysicalMedia.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.LearningResources.Interfaces
{
     /// <summary>
     /// The ILearningResourcePhysicalMedia Interface
     /// </summary>
    public partial interface ILearningResourcePhysicalMedia : IAutobahnBase
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
        Guid? RefLearningResourcePhysicalMediaTypeId { get; set; }

    }
}
