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
        /// 
        /// </summary>
        public  ClassRankingDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  CreditsAttemptedCumulative { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  CreditsEarnedCumulative { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  DiplomaOrCredentialAwardDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  GradePointAverageCumulative { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  GradePointsEarnedCumulative { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid? HighSchoolStudentClassRank { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  ProjectedGraduationDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RecordStartDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefGpaWeightedIndicatorId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefHighSchoolDiplomaDistinctionTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefHighSchoolDiplomaTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefPreAndPostTestIndicatorId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefProfessionalTechnicalCredentialTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefProgressLevelId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefPsEnrollmentActionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefTechnologyLiteracyStatusId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  TotalNumberInClass { get; set; }

    }
}
