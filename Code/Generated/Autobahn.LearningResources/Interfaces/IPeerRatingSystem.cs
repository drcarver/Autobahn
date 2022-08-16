//***************************************************************************
//* DomainName: Learning Resources Interfaces (used by both models and View Models
//* FileName:   IPeerRatingSystem.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.LearningResources.Interfaces
{
     /// <summary>
     /// The IPeerRatingSystem Interface
     /// </summary>
    public partial interface IPeerRatingSystem : IAutobahnBase
    {
        /// <summary>
        /// 
        /// </summary>
         MaximumValue { get; set; }

        /// <summary>
        /// 
        /// </summary>
         MinimumValue { get; set; }

        /// <summary>
        /// 
        /// </summary>
        Guid? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
         OptimumValue { get; set; }

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
