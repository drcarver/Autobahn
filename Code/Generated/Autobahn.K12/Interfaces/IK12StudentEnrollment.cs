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
        /// An indication of a student's level of eligibility to participate in the National School Lunch Program for breakfast, lunch, snack, supper, and milk programs.
        /// </summary>
        System.Boolean? DisplacedStudentStatus { get; set; }

        /// <summary>
        /// An indication of a student's level of eligibility to participate in the National School Lunch Program for breakfast, lunch, snack, supper, and milk programs.
        /// </summary>
        System.DateTime? FirstEntryDateIntoUSSchool { get; set; }

        /// <summary>
        /// An indication of a student's level of eligibility to participate in the National School Lunch Program for breakfast, lunch, snack, supper, and milk programs.
        /// </summary>
        System.Boolean? NSLPDirectCertificationIndicator { get; set; }

        /// <summary>
        /// An indication of a student's level of eligibility to participate in the National School Lunch Program for breakfast, lunch, snack, supper, and milk programs.
        /// </summary>
        Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// An indication of a student's level of eligibility to participate in the National School Lunch Program for breakfast, lunch, snack, supper, and milk programs.
        /// </summary>
        Guid? RefDirectoryInformationBlockStatusId { get; set; }

        /// <summary>
        /// An indication of a student's level of eligibility to participate in the National School Lunch Program for breakfast, lunch, snack, supper, and milk programs.
        /// </summary>
        Guid? RefEndOfTermStatusId { get; set; }

        /// <summary>
        /// An indication of a student's level of eligibility to participate in the National School Lunch Program for breakfast, lunch, snack, supper, and milk programs.
        /// </summary>
        Guid? RefEnrollmentStatusId { get; set; }

        /// <summary>
        /// An indication of a student's level of eligibility to participate in the National School Lunch Program for breakfast, lunch, snack, supper, and milk programs.
        /// </summary>
        Guid? RefEntryGradeLevelId { get; set; }

        /// <summary>
        /// An indication of a student's level of eligibility to participate in the National School Lunch Program for breakfast, lunch, snack, supper, and milk programs.
        /// </summary>
        System.Int32? RefEntryType { get; set; }

        /// <summary>
        /// An indication of a student's level of eligibility to participate in the National School Lunch Program for breakfast, lunch, snack, supper, and milk programs.
        /// </summary>
        Guid? RefExitGradeLevelId { get; set; }

        /// <summary>
        /// An indication of a student's level of eligibility to participate in the National School Lunch Program for breakfast, lunch, snack, supper, and milk programs.
        /// </summary>
        Guid? RefExitOrWithdrawalStatusId { get; set; }

        /// <summary>
        /// An indication of a student's level of eligibility to participate in the National School Lunch Program for breakfast, lunch, snack, supper, and milk programs.
        /// </summary>
        Guid? RefExitOrWithdrawalTypeId { get; set; }

        /// <summary>
        /// An indication of a student's level of eligibility to participate in the National School Lunch Program for breakfast, lunch, snack, supper, and milk programs.
        /// </summary>
        Guid? RefFoodServiceEligibilityId { get; set; }

        /// <summary>
        /// An indication of a student's level of eligibility to participate in the National School Lunch Program for breakfast, lunch, snack, supper, and milk programs.
        /// </summary>
        Guid? RefNonPromotionReasonId { get; set; }

        /// <summary>
        /// An indication of a student's level of eligibility to participate in the National School Lunch Program for breakfast, lunch, snack, supper, and milk programs.
        /// </summary>
        Guid? RefPromotionReasonId { get; set; }

        /// <summary>
        /// An indication of a student's level of eligibility to participate in the National School Lunch Program for breakfast, lunch, snack, supper, and milk programs.
        /// </summary>
        System.Int32? RefPublicSchoolResidence { get; set; }

        /// <summary>
        /// An indication of a student's level of eligibility to participate in the National School Lunch Program for breakfast, lunch, snack, supper, and milk programs.
        /// </summary>
        Guid? RefStudentEnrollmentAccessTypeId { get; set; }

    }
}
