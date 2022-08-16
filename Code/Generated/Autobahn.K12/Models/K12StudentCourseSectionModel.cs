//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12StudentCourseSectionModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The K12StudentCourseSection Model
     /// </summary>
    public partial class K12StudentCourseSectionModel : AutobahnBase, Interfaces.IK12StudentCourseSection
    {
        /// <summary>
        /// 
        /// </summary>
        public  ExitWithdrawalDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  GradeEarned { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  GradeValueQualifier { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  NumberOfCreditsAttempted { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  NumberOfCreditsEarned { get; set; }

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
        public  RefAdditionalCreditTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid? RefCourseGpaApplicabilityId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefCourseRepeatCodeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefCourseSectionEnrollmentStatusTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefCourseSectionEntryTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefCourseSectionExitTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefCreditTypeEarnedId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefExitOrWithdrawalStatusId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefGradeLevelWhenCourseTakenId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefPreAndPostTestIndicatorId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefProgressLevelId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  TuitionFunded { get; set; }

    }
}
