//***************************************************************************
//* DomainName: Authentication and Authorization Interfaces (used by both models and View Models
//* FileName:   ILearningResourceEducationLevel.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Authorization.Interfaces
{
     /// <summary>
     /// The ILearningResourceEducationLevel Interface
     /// </summary>
    public partial interface ILearningResourceEducationLevel : IAutobahnBase
    {
        /// <summary>
        /// The education level, grade level or primary instructional level at which a Learning Resource is intended.
        /// </summary>
        Guid LearningResourceId { get; set; }

        /// <summary>
        /// The education level, grade level or primary instructional level at which a Learning Resource is intended.
        /// </summary>
        Guid RefEducationLevelId { get; set; }

    }
}
