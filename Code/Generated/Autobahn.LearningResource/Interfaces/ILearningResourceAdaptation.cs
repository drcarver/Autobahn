//**********************************************************
//* DomainName: Autobahn.LearningResource
//* FileName:   ILearningResourceAdaptation.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.LearningResource.Interfaces
{
     /// <summary>
     /// The ILearningResourceAdaptation
     /// </summary>
    public partial interface ILearningResourceAdaptation : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="LearningResource"/> model
        /// </summary>
        Guid LearningResourceId { get; set; }

        /// <summary>
        /// Defines the LearningResourceAdaptation.AdaptationURL non nullable property
        /// </summary>
        System.String AdaptationURL { get; set; }

    }
}
