//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   ICourseSectionLevel.cs
//**********************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The ICourseSectionLevel
     /// </summary>
    public partial interface ICourseSectionLevel : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="CourseSection"/> model
        /// </summary>
        Guid CourseSectionId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="RefCourseLevelType"/> model
        /// </summary>
        Guid RefCourseLevelTypeId { get; set; }

    }
}
