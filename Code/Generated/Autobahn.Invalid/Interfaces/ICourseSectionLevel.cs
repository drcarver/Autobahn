//***************************************************************************
//* DomainName: Invalid or Unreferenced Models Interfaces (used by both models and View Models
//* FileName:   ICourseSectionLevel.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Invalid.Interfaces
{
     /// <summary>
     /// The ICourseSectionLevel Interface
     /// </summary>
    public partial interface ICourseSectionLevel : IAutobahnBase
    {
        /// <summary>
        /// The level of work which is reflected in the credits associated with the academic course being described or the level of the typical individual taking the academic course.
        /// </summary>
        Guid CourseSectionId { get; set; }

        /// <summary>
        /// The level of work which is reflected in the credits associated with the academic course being described or the level of the typical individual taking the academic course.
        /// </summary>
        Guid RefCourseLevelTypeId { get; set; }

    }
}
