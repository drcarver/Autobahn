//**********************************************************
//* DomainName: Autobahn.LearningResource
//* FileName:   ILearningResourceEducationLevel.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.LearningResource.Interfaces
{
     /// <summary>
     /// The ILearningResourceEducationLevel
     /// </summary>
    public partial interface ILearningResourceEducationLevel : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="LearningResource"/> model
        /// </summary>
        Guid LearningResourceId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="RefEducationLevel"/> model
        /// </summary>
        Guid RefEducationLevelId { get; set; }

    }
}
