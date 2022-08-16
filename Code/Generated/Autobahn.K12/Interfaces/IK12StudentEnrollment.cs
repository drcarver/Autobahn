//***************************************************************************
//* DomainName: Elementary and Secondary (K12) Interfaces (used by both models and View Models
//* FileName:   IK12StudentEnrollment.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.K12.Interfaces
{
     /// <summary>
     /// The IK12StudentEnrollment Interface
     /// </summary>
    public partial interface IK12StudentEnrollment : IAutobahnBase
    {
        /// <summary>
        /// 
        /// </summary>
         DisplacedStudentStatus { get; set; }

        /// <summary>
        /// 
        /// </summary>
         FirstEntryDateIntoUSSchool { get; set; }

        /// <summary>
        /// 
        /// </summary>
         NSLPDirectCertificationIndicator { get; set; }

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
         RefDirectoryInformationBlockStatusId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefEndOfTermStatusId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefEnrollmentStatusId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefEntryGradeLevelId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefEntryType { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefExitGradeLevelId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefExitOrWithdrawalStatusId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefExitOrWithdrawalTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        Guid? RefFoodServiceEligibilityId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefNonPromotionReasonId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefPromotionReasonId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefPublicSchoolResidence { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefStudentEnrollmentAccessTypeId { get; set; }

    }
}
