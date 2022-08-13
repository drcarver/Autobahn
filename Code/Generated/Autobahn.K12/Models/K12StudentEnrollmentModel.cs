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
        /// An indication of a student's level of eligibility to participate in the National School Lunch Program for breakfast, lunch, snack, supper, and milk programs.
        /// </summary>
        public System.Boolean? DisplacedStudentStatus { get; set; }

        /// <summary>
        /// An indication of a student's level of eligibility to participate in the National School Lunch Program for breakfast, lunch, snack, supper, and milk programs.
        /// </summary>
        public System.DateTime? FirstEntryDateIntoUSSchool { get; set; }

        /// <summary>
        /// An indication of a student's level of eligibility to participate in the National School Lunch Program for breakfast, lunch, snack, supper, and milk programs.
        /// </summary>
        public System.Boolean? NSLPDirectCertificationIndicator { get; set; }

        /// <summary>
        /// An indication of a student's level of eligibility to participate in the National School Lunch Program for breakfast, lunch, snack, supper, and milk programs.
        /// </summary>
        public Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// An indication of a student's level of eligibility to participate in the National School Lunch Program for breakfast, lunch, snack, supper, and milk programs.
        /// </summary>
        public Guid? RefDirectoryInformationBlockStatusId { get; set; }

        /// <summary>
        /// An indication of a student's level of eligibility to participate in the National School Lunch Program for breakfast, lunch, snack, supper, and milk programs.
        /// </summary>
        public Guid? RefEndOfTermStatusId { get; set; }

        /// <summary>
        /// An indication of a student's level of eligibility to participate in the National School Lunch Program for breakfast, lunch, snack, supper, and milk programs.
        /// </summary>
        public Guid? RefEnrollmentStatusId { get; set; }

        /// <summary>
        /// An indication of a student's level of eligibility to participate in the National School Lunch Program for breakfast, lunch, snack, supper, and milk programs.
        /// </summary>
        public Guid? RefEntryGradeLevelId { get; set; }

        /// <summary>
        /// An indication of a student's level of eligibility to participate in the National School Lunch Program for breakfast, lunch, snack, supper, and milk programs.
        /// </summary>
        public System.Int32? RefEntryType { get; set; }

        /// <summary>
        /// An indication of a student's level of eligibility to participate in the National School Lunch Program for breakfast, lunch, snack, supper, and milk programs.
        /// </summary>
        public Guid? RefExitGradeLevelId { get; set; }

        /// <summary>
        /// An indication of a student's level of eligibility to participate in the National School Lunch Program for breakfast, lunch, snack, supper, and milk programs.
        /// </summary>
        public Guid? RefExitOrWithdrawalStatusId { get; set; }

        /// <summary>
        /// An indication of a student's level of eligibility to participate in the National School Lunch Program for breakfast, lunch, snack, supper, and milk programs.
        /// </summary>
        public Guid? RefExitOrWithdrawalTypeId { get; set; }

        /// <summary>
        /// An indication of a student's level of eligibility to participate in the National School Lunch Program for breakfast, lunch, snack, supper, and milk programs.
        /// </summary>
        public Guid? RefFoodServiceEligibilityId { get; set; }

        /// <summary>
        /// An indication of a student's level of eligibility to participate in the National School Lunch Program for breakfast, lunch, snack, supper, and milk programs.
        /// </summary>
        public Guid? RefNonPromotionReasonId { get; set; }

        /// <summary>
        /// An indication of a student's level of eligibility to participate in the National School Lunch Program for breakfast, lunch, snack, supper, and milk programs.
        /// </summary>
        public Guid? RefPromotionReasonId { get; set; }

        /// <summary>
        /// An indication of a student's level of eligibility to participate in the National School Lunch Program for breakfast, lunch, snack, supper, and milk programs.
        /// </summary>
        public System.Int32? RefPublicSchoolResidence { get; set; }

        /// <summary>
        /// An indication of a student's level of eligibility to participate in the National School Lunch Program for breakfast, lunch, snack, supper, and milk programs.
        /// </summary>
        public Guid? RefStudentEnrollmentAccessTypeId { get; set; }

    }
}
