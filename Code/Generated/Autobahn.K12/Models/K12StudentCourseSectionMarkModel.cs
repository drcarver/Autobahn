//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12studentCourseSectionMarkModel.cs
//***************************************************************************

using Autobahn.Interfaces.K12;
using Autobahn.Interfaces.Common;
using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The K12studentCourseSectionMark Model
     /// </summary>
    public partial class K12studentCourseSectionMarkModel : AutobahnBase, IK12studentCourseSectionMark
    {
        public Boolean? FinalIndicator { get; set; }

        public System.String GradeEarned { get; set; }

        public System.String GradeValueQualifier { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IK12studentCourseSection"/> model
        /// </summary>
        public Guid K12studentCourseSectionId { get; set; }

        public System.String MarkingPeriodName { get; set; }

        public System.String MidTermMark { get; set; }

        public System.String StudentCourseSectionGradeNarrative { get; set; }

    }
}
