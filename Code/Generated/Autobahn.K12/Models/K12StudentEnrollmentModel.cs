//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12StudentEnrollmentModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The K12StudentEnrollment Model
     /// </summary>
    public partial class K12StudentEnrollmentModel : AutobahnBase, Interfaces.IK12StudentEnrollment
    {
        /// <summary>
        /// 
        /// </summary>
        public  DisplacedStudentStatus { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  FirstEntryDateIntoUSSchool { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  NSLPDirectCertificationIndicator { get; set; }

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
        public  RefDirectoryInformationBlockStatusId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefEndOfTermStatusId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefEnrollmentStatusId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefEntryGradeLevelId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefEntryType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefExitGradeLevelId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefExitOrWithdrawalStatusId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefExitOrWithdrawalTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid? RefFoodServiceEligibilityId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefNonPromotionReasonId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefPromotionReasonId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefPublicSchoolResidence { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefStudentEnrollmentAccessTypeId { get; set; }

    }
}
