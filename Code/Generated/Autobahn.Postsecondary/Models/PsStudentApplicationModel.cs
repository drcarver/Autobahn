//**********************************************************
//* DomainName: Postsecondary (PS)
//* FileName:   PsStudentApplicationModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Postsecondary.Models
{
     /// <summary>
     /// The PsStudentApplication Model
     /// </summary>
    public partial class PsStudentApplicationModel : AutobahnBase, Interfaces.IPsStudentApplication
    {
        /// <summary>
        /// The academic rank of a student in relation to his or her high school graduating class (e.g., 1, 2, 3) based on high school GPA.
        /// </summary>
        public System.Decimal? GradePointAverageCumulative { get; set; }

        /// <summary>
        /// The academic rank of a student in relation to his or her high school graduating class (e.g., 1, 2, 3) based on high school GPA.
        /// </summary>
        public System.Int32? HighSchoolGraduatingClassSize { get; set; }

        /// <summary>
        /// The academic rank of a student in relation to his or her high school graduating class (e.g., 1, 2, 3) based on high school GPA.
        /// </summary>
        public System.Decimal? HighSchoolPercentile { get; set; }

        /// <summary>
        /// The academic rank of a student in relation to his or her high school graduating class (e.g., 1, 2, 3) based on high school GPA.
        /// </summary>
        public System.Int32? HighSchoolStudentClassRank { get; set; }

        /// <summary>
        /// The academic rank of a student in relation to his or her high school graduating class (e.g., 1, 2, 3) based on high school GPA.
        /// </summary>
        public Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// The academic rank of a student in relation to his or her high school graduating class (e.g., 1, 2, 3) based on high school GPA.
        /// </summary>
        public System.Boolean? PostsecondaryApplicant { get; set; }

        /// <summary>
        /// The academic rank of a student in relation to his or her high school graduating class (e.g., 1, 2, 3) based on high school GPA.
        /// </summary>
        public Guid? RefAdmittedStudentId { get; set; }

        /// <summary>
        /// The academic rank of a student in relation to his or her high school graduating class (e.g., 1, 2, 3) based on high school GPA.
        /// </summary>
        public Guid? RefGpaWeightedIndicatorId { get; set; }

        /// <summary>
        /// The academic rank of a student in relation to his or her high school graduating class (e.g., 1, 2, 3) based on high school GPA.
        /// </summary>
        public Guid? RefGradePointAverageDomainId { get; set; }

        /// <summary>
        /// The academic rank of a student in relation to his or her high school graduating class (e.g., 1, 2, 3) based on high school GPA.
        /// </summary>
        public System.Boolean? WaitListedStudent { get; set; }

    }
}
