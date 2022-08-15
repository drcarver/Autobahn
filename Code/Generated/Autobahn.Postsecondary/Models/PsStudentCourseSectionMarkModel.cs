//**********************************************************
//* DomainName: Postsecondary (PS)
//* FileName:   PsStudentCourseSectionMarkModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Postsecondary.Models
{
     /// <summary>
     /// The PsStudentCourseSectionMark Model
     /// </summary>
    public partial class PsStudentCourseSectionMarkModel : AutobahnBase, Interfaces.IPsStudentCourseSectionMark
    {
        /// <summary>
        /// Additional information regarding the context of the given grade.
        /// </summary>
        public Guid? RefCourseAcademicGradeStatusCodeId { get; set; }

    }
}
