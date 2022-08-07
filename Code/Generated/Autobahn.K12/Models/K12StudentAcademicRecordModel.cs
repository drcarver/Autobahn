//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   K12StudentAcademicRecordModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The K12StudentAcademicRecord Model
     /// </summary>
    public partial class K12StudentAcademicRecordModel : AutobahnBase, Interfaces.IK12StudentAcademicRecordModel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Defines the K12StudentAcademicRecord.CreditsAttemptedCumulative nullable property
        /// </summary>
        public System.Decimal? CreditsAttemptedCumulative { get; set; }

        /// <summary>
        /// Defines the K12StudentAcademicRecord.CreditsEarnedCumulative nullable property
        /// </summary>
        public System.Decimal? CreditsEarnedCumulative { get; set; }

        /// <summary>
        /// Defines the K12StudentAcademicRecord.GradePointsEarnedCumulative nullable property
        /// </summary>
        public System.Decimal? GradePointsEarnedCumulative { get; set; }

        /// <summary>
        /// Defines the K12StudentAcademicRecord.GradePointAverageCumulative nullable property
        /// </summary>
        public System.Decimal? GradePointAverageCumulative { get; set; }

        /// <summary>
        /// Defines the K12StudentAcademicRecord.ProjectedGraduationDate nullable property
        /// </summary>
        public System.DateTime? ProjectedGraduationDate { get; set; }

        /// <summary>
        /// Defines the K12StudentAcademicRecord.HighSchoolStudentClassRank nullable property
        /// </summary>
        public System.Int32? HighSchoolStudentClassRank { get; set; }

        /// <summary>
        /// Defines the K12StudentAcademicRecord.ClassRankingDate nullable property
        /// </summary>
        public System.DateTime? ClassRankingDate { get; set; }

        /// <summary>
        /// Defines the K12StudentAcademicRecord.TotalNumberInClass nullable property
        /// </summary>
        public System.Int32? TotalNumberInClass { get; set; }

        /// <summary>
        /// Defines the K12StudentAcademicRecord.DiplomaOrCredentialAwardDate nullable property
        /// </summary>
        public System.DateTime? DiplomaOrCredentialAwardDate { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefGpaWeightedIndicator"/> model
        /// </summary>
        public Guid? RefGpaWeightedIndicatorId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefHighSchoolDiplomaType"/> model
        /// </summary>
        public Guid? RefHighSchoolDiplomaTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefHighSchoolDiplomaDistinctionType"/> model
        /// </summary>
        public Guid? RefHighSchoolDiplomaDistinctionTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTechnologyLiteracyStatus"/> model
        /// </summary>
        public Guid? RefTechnologyLiteracyStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPsEnrollmentAction"/> model
        /// </summary>
        public Guid? RefPsEnrollmentActionId { get; set; }

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
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
