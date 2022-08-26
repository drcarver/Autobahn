//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12studentAcademicRecordModel.cs
//***************************************************************************

using Autobahn.Interfaces.K12;
using Autobahn.Interfaces.Common;
using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The K12studentAcademicRecord Model
     /// </summary>
    public partial class K12studentAcademicRecordModel : AutobahnBase, IK12studentAcademicRecord
    {
        public DateTime? ClassRankingDate { get; set; }

        public Decimal? CreditsAttemptedCumulative { get; set; }

        public Decimal? CreditsEarnedCumulative { get; set; }

        public DateTime? DiplomaOrCredentialAwardDate { get; set; }

        public Decimal? GradePointAverageCumulative { get; set; }

        public Decimal? GradePointsEarnedCumulative { get; set; }

        public Int32? HighSchoolStudentClassRank { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get; set; }

        public DateTime? ProjectedGraduationDate { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefGpaWeightedIndicator"/> model
        /// </summary>
        public Guid? RefGpaWeightedIndicatorId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefHighSchoolDiplomaDistinctionType"/> model
        /// </summary>
        public Guid? RefHighSchoolDiplomaDistinctionTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefHighSchoolDiplomaType"/> model
        /// </summary>
        public Guid? RefHighSchoolDiplomaTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPreAndPostTestIndicator"/> model
        /// </summary>
        public Guid? RefPreAndPostTestIndicatorId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefProfessionalTechnicalCredentialType"/> model
        /// </summary>
        public Guid? RefProfessionalTechnicalCredentialTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefProgressLevel"/> model
        /// </summary>
        public Guid? RefProgressLevelId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPsEnrollmentAction"/> model
        /// </summary>
        public Guid? RefPsEnrollmentActionId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTechnologyLiteracyStatus"/> model
        /// </summary>
        public Guid? RefTechnologyLiteracyStatusId { get; set; }

        public Int32? TotalNumberInClass { get; set; }

    }
}
