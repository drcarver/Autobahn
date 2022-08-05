//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   IK12StudentEnrollment.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.K12.Interfaces
{
     /// <summary>
     /// The IK12StudentEnrollment
     /// </summary>
    public partial interface IK12StudentEnrollment : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationPersonRole"/> model
        /// </summary>
        Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Defines the K12StudentEnrollment.DisplacedStudentStatus nullable property
        /// </summary>
        System.Boolean? DisplacedStudentStatus { get; set; }

        /// <summary>
        /// Defines the K12StudentEnrollment.FirstEntryDateIntoUSSchool nullable property
        /// </summary>
        System.DateTime? FirstEntryDateIntoUSSchool { get; set; }

        /// <summary>
        /// Defines the K12StudentEnrollment.NSLPDirectCertificationIndicator nullable property
        /// </summary>
        System.Boolean? NSLPDirectCertificationIndicator { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefEntryGradeLevel"/> model
        /// </summary>
        Guid? RefEntryGradeLevelId { get; set; }

        /// <summary>
        /// Defines the K12StudentEnrollment.RefPublicSchoolResidence nullable property
        /// </summary>
        System.Int32? RefPublicSchoolResidence { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefEnrollmentStatus"/> model
        /// </summary>
        Guid? RefEnrollmentStatusId { get; set; }

        /// <summary>
        /// Defines the K12StudentEnrollment.RefEntryType nullable property
        /// </summary>
        System.Int32? RefEntryType { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefExitGradeLevel"/> model
        /// </summary>
        Guid? RefExitGradeLevelId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefExitOrWithdrawalStatus"/> model
        /// </summary>
        Guid? RefExitOrWithdrawalStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefExitOrWithdrawalType"/> model
        /// </summary>
        Guid? RefExitOrWithdrawalTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefEndOfTermStatus"/> model
        /// </summary>
        Guid? RefEndOfTermStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPromotionReason"/> model
        /// </summary>
        Guid? RefPromotionReasonId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefNonPromotionReason"/> model
        /// </summary>
        Guid? RefNonPromotionReasonId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFoodServiceEligibility"/> model
        /// </summary>
        Guid? RefFoodServiceEligibilityId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefDirectoryInformationBlockStatus"/> model
        /// </summary>
        Guid? RefDirectoryInformationBlockStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefStudentEnrollmentAccessType"/> model
        /// </summary>
        Guid? RefStudentEnrollmentAccessTypeId { get; set; }

    }
}
