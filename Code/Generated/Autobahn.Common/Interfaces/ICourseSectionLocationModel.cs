//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   ICourseSectionLocationModel.cs
//**********************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The ICourseSectionLocationModel Interface
     /// </summary>
    public partial interface ICourseSectionLocationModel : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Classroom"/> model
        /// </summary>
        Guid ClassroomId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="CourseSection"/> model
        /// </summary>
        Guid CourseSectionId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefInstructionLocationType"/> model
        /// </summary>
        Guid? RefInstructionLocationTypeId { get; set; }

    }
}
