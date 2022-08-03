//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   IK12StudentAcademicRecord.cs
//**********************************************************

namespace Autobahn.K12.Interfaces
{
     /// <summary>
     /// The IK12StudentAcademicRecord
     /// </summary>
    public partial interface IK12StudentAcademicRecord
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationPersonRole"/> model
        /// </summary>
        Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Defines the K12StudentAcademicRecord.CreditsAttemptedCumulative nullable property
        /// </summary>
        System.Decimal? CreditsAttemptedCumulative { get; set; }

        /// <summary>
        /// Defines the K12StudentAcademicRecord.CreditsEarnedCumulative nullable property
        /// </summary>
        System.Decimal? CreditsEarnedCumulative { get; set; }

        /// <summary>
        /// Defines the K12StudentAcademicRecord.GradePointsEarnedCumulative nullable property
        /// </summary>
        System.Decimal? GradePointsEarnedCumulative { get; set; }

        /// <summary>
        /// Defines the K12StudentAcademicRecord.GradePointAverageCumulative nullable property
        /// </summary>
        System.Decimal? GradePointAverageCumulative { get; set; }

        /// <summary>
        /// Defines the K12StudentAcademicRecord.ProjectedGraduationDate nullable property
        /// </summary>
        System.DateTime? ProjectedGraduationDate { get; set; }

        /// <summary>
        /// Defines the K12StudentAcademicRecord.HighSchoolStudentClassRank nullable property
        /// </summary>
        System.Int32? HighSchoolStudentClassRank { get; set; }

        /// <summary>
        /// Defines the K12StudentAcademicRecord.ClassRankingDate nullable property
        /// </summary>
        System.DateTime? ClassRankingDate { get; set; }

        /// <summary>
        /// Defines the K12StudentAcademicRecord.TotalNumberInClass nullable property
        /// </summary>
        System.Int32? TotalNumberInClass { get; set; }

        /// <summary>
        /// Defines the K12StudentAcademicRecord.DiplomaOrCredentialAwardDate nullable property
        /// </summary>
        System.DateTime? DiplomaOrCredentialAwardDate { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefGpaWeightedIndicator"/> model
        /// </summary>
        Guid? RefGpaWeightedIndicatorId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefHighSchoolDiplomaType"/> model
        /// </summary>
        Guid? RefHighSchoolDiplomaTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefHighSchoolDiplomaDistinctionType"/> model
        /// </summary>
        Guid? RefHighSchoolDiplomaDistinctionTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTechnologyLiteracyStatus"/> model
        /// </summary>
        Guid? RefTechnologyLiteracyStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPsEnrollmentAction"/> model
        /// </summary>
        Guid? RefPsEnrollmentActionId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPreAndPostTestIndicator"/> model
        /// </summary>
        Guid? RefPreAndPostTestIndicatorId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefProfessionalTechnicalCredentialType"/> model
        /// </summary>
        Guid? RefProfessionalTechnicalCredentialTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefProgressLevel"/> model
        /// </summary>
        Guid? RefProgressLevelId { get; set; }

        /// <summary>
        /// Defines the K12StudentAcademicRecord.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the K12StudentAcademicRecord.RecordEndDateTime nullable property
        /// </summary>
        System.DateTime? RecordEndDateTime { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatus"/> model
        /// </summary>
        Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        Guid? DataCollectionId { get; set; }

    }
}
