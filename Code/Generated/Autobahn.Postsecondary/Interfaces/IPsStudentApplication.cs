//***************************************************************************
//* DomainName: Postsecondary (PS) Interfaces (used by both models and View Models
//* FileName:   IPsStudentApplication.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Postsecondary.Interfaces
{
     /// <summary>
     /// The IPsStudentApplication Interface
     /// </summary>
    public partial interface IPsStudentApplication : IAutobahnBase
    {
        /// <summary>
        /// The academic rank of a student in relation to his or her high school graduating class (e.g., 1, 2, 3) based on high school GPA.
        /// </summary>
        System.Decimal? GradePointAverageCumulative { get; set; }

        /// <summary>
        /// The academic rank of a student in relation to his or her high school graduating class (e.g., 1, 2, 3) based on high school GPA.
        /// </summary>
        System.Int32? HighSchoolGraduatingClassSize { get; set; }

        /// <summary>
        /// The academic rank of a student in relation to his or her high school graduating class (e.g., 1, 2, 3) based on high school GPA.
        /// </summary>
        System.Decimal? HighSchoolPercentile { get; set; }

        /// <summary>
        /// The academic rank of a student in relation to his or her high school graduating class (e.g., 1, 2, 3) based on high school GPA.
        /// </summary>
        System.Int32? HighSchoolStudentClassRank { get; set; }

        /// <summary>
        /// The academic rank of a student in relation to his or her high school graduating class (e.g., 1, 2, 3) based on high school GPA.
        /// </summary>
        Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// The academic rank of a student in relation to his or her high school graduating class (e.g., 1, 2, 3) based on high school GPA.
        /// </summary>
        System.Boolean? PostsecondaryApplicant { get; set; }

        /// <summary>
        /// The academic rank of a student in relation to his or her high school graduating class (e.g., 1, 2, 3) based on high school GPA.
        /// </summary>
        Guid? RefAdmittedStudentId { get; set; }

        /// <summary>
        /// The academic rank of a student in relation to his or her high school graduating class (e.g., 1, 2, 3) based on high school GPA.
        /// </summary>
        Guid? RefGpaWeightedIndicatorId { get; set; }

        /// <summary>
        /// The academic rank of a student in relation to his or her high school graduating class (e.g., 1, 2, 3) based on high school GPA.
        /// </summary>
        Guid? RefGradePointAverageDomainId { get; set; }

        /// <summary>
        /// The academic rank of a student in relation to his or her high school graduating class (e.g., 1, 2, 3) based on high school GPA.
        /// </summary>
        System.Boolean? WaitListedStudent { get; set; }

    }
}
