//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   ICourseSectionLevelModel.cs
//**********************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The ICourseSectionLevelModel Interface
     /// </summary>
    public partial interface ICourseSectionLevelModel : IAutobahnBase
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
