//***************************************************************************
//* DomainName: Learning Resources Interfaces (used by both models and View Models
//* FileName:   ILearningResourcePeerRating.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.LearningResources.Interfaces
{
     /// <summary>
     /// The ILearningResourcePeerRating Interface
     /// </summary>
    public partial interface ILearningResourcePeerRating : IAutobahnBase
    {
        /// <summary>
        /// 
        /// </summary>
         Date { get; set; }

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
        Guid? Value { get; set; }

    }
}
