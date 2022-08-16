//***************************************************************************
//* DomainName: Elementary and Secondary (K12) Interfaces (used by both models and View Models
//* FileName:   IK12StudentAcademicRecord.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.K12.Interfaces
{
     /// <summary>
     /// The IK12StudentAcademicRecord Interface
     /// </summary>
    public partial interface IK12StudentAcademicRecord : IAutobahnBase
    {
        /// <summary>
        /// 
        /// </summary>
         ClassRankingDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
         CreditsAttemptedCumulative { get; set; }

        /// <summary>
        /// 
        /// </summary>
         CreditsEarnedCumulative { get; set; }

        /// <summary>
        /// 
        /// </summary>
         DiplomaOrCredentialAwardDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
         GradePointAverageCumulative { get; set; }

        /// <summary>
        /// 
        /// </summary>
         GradePointsEarnedCumulative { get; set; }

        /// <summary>
        /// 
        /// </summary>
        Guid? HighSchoolStudentClassRank { get; set; }

        /// <summary>
        /// 
        /// </summary>
         ProjectedGraduationDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RecordStartDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefGpaWeightedIndicatorId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefHighSchoolDiplomaDistinctionTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefHighSchoolDiplomaTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefPreAndPostTestIndicatorId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefProfessionalTechnicalCredentialTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefProgressLevelId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefPsEnrollmentActionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefTechnologyLiteracyStatusId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         TotalNumberInClass { get; set; }

    }
}
