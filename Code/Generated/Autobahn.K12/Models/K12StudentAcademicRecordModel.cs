//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12StudentAcademicRecordModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The K12StudentAcademicRecord Model
     /// </summary>
    public partial class K12StudentAcademicRecordModel : AutobahnBase, Interfaces.IK12StudentAcademicRecord
    {
        /// <summary>
        /// The academic rank of a student in relation to his or her high school graduating class (e.g., 1, 2, 3) based on high school GPA.
        /// </summary>
        public System.DateTime? ClassRankingDate { get; set; }

        /// <summary>
        /// The academic rank of a student in relation to his or her high school graduating class (e.g., 1, 2, 3) based on high school GPA.
        /// </summary>
        public System.Decimal? CreditsAttemptedCumulative { get; set; }

        /// <summary>
        /// The academic rank of a student in relation to his or her high school graduating class (e.g., 1, 2, 3) based on high school GPA.
        /// </summary>
        public System.Decimal? CreditsEarnedCumulative { get; set; }

        /// <summary>
        /// The academic rank of a student in relation to his or her high school graduating class (e.g., 1, 2, 3) based on high school GPA.
        /// </summary>
        public System.DateTime? DiplomaOrCredentialAwardDate { get; set; }

        /// <summary>
        /// The academic rank of a student in relation to his or her high school graduating class (e.g., 1, 2, 3) based on high school GPA.
        /// </summary>
        public System.Decimal? GradePointAverageCumulative { get; set; }

        /// <summary>
        /// The academic rank of a student in relation to his or her high school graduating class (e.g., 1, 2, 3) based on high school GPA.
        /// </summary>
        public System.Decimal? GradePointsEarnedCumulative { get; set; }

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
        public System.DateTime? ProjectedGraduationDate { get; set; }

        /// <summary>
        /// The academic rank of a student in relation to his or her high school graduating class (e.g., 1, 2, 3) based on high school GPA.
        /// </summary>
        public Guid? RefGpaWeightedIndicatorId { get; set; }

        /// <summary>
        /// The academic rank of a student in relation to his or her high school graduating class (e.g., 1, 2, 3) based on high school GPA.
        /// </summary>
        public Guid? RefHighSchoolDiplomaDistinctionTypeId { get; set; }

        /// <summary>
        /// The academic rank of a student in relation to his or her high school graduating class (e.g., 1, 2, 3) based on high school GPA.
        /// </summary>
        public Guid? RefHighSchoolDiplomaTypeId { get; set; }

        /// <summary>
        /// The academic rank of a student in relation to his or her high school graduating class (e.g., 1, 2, 3) based on high school GPA.
        /// </summary>
        public Guid? RefPreAndPostTestIndicatorId { get; set; }

        /// <summary>
        /// The academic rank of a student in relation to his or her high school graduating class (e.g., 1, 2, 3) based on high school GPA.
        /// </summary>
        public Guid? RefProfessionalTechnicalCredentialTypeId { get; set; }

        /// <summary>
        /// The academic rank of a student in relation to his or her high school graduating class (e.g., 1, 2, 3) based on high school GPA.
        /// </summary>
        public Guid? RefProgressLevelId { get; set; }

        /// <summary>
        /// The academic rank of a student in relation to his or her high school graduating class (e.g., 1, 2, 3) based on high school GPA.
        /// </summary>
        public Guid? RefPsEnrollmentActionId { get; set; }

        /// <summary>
        /// The academic rank of a student in relation to his or her high school graduating class (e.g., 1, 2, 3) based on high school GPA.
        /// </summary>
        public Guid? RefTechnologyLiteracyStatusId { get; set; }

        /// <summary>
        /// The academic rank of a student in relation to his or her high school graduating class (e.g., 1, 2, 3) based on high school GPA.
        /// </summary>
        public System.Int32? TotalNumberInClass { get; set; }

    }
}
