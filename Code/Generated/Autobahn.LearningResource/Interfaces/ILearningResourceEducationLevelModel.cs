//**********************************************************
//* DomainName: Autobahn.LearningResource
//* FileName:   ILearningResourceEducationLevelModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.LearningResource.Interfaces
{
     /// <summary>
     /// The ILearningResourceEducationLevelModel Interface
     /// </summary>
    public partial interface ILearningResourceEducationLevelModel : IAutobahnBase
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
