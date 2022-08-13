//***************************************************************************
//* DomainName: Common Models Interfaces (used by both models and View Models
//* FileName:   ITeacherStudentDataLinkExclusion.cs
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The ITeacherStudentDataLinkExclusion Interface
     /// </summary>
    public partial interface ITeacherStudentDataLinkExclusion : IAutobahnBase
    {
        /// <summary>
        /// Indicates that the student is excluded from calculation of value-added or growth attribution calculations used for teacher evaluation.
        /// </summary>
        Guid K12StaffAssignmentId { get; set; }

        /// <summary>
        /// Indicates that the student is excluded from calculation of value-added or growth attribution calculations used for teacher evaluation.
        /// </summary>
        Guid K12StudentCourseSectionId { get; set; }

    }
}
