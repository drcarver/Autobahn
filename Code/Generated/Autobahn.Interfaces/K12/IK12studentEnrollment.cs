//***************************************************************************
//* DomainName: Elementary and Secondary (K12) Interfaces (used by both models and View Models
//* FileName:   IK12studentEnrollment.cs
//***************************************************************************

using Autobahn.Interfaces.Common;

namespace Autobahn.Interfaces.K12
{
     /// <summary>
     /// The IK12studentEnrollment Interface
     /// </summary>
    public partial interface IK12studentEnrollment : IAutobahnBase
    {
        Boolean? DisplacedStudentStatus { get; set; }

        DateTime? FirstEntryDateIntoUsschool { get; set; }

        Boolean? NslpdirectCertificationIndicator { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
        /// </summary>
        Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefDirectoryInformationBlockStatus"/> model
        /// </summary>
        Guid? RefDirectoryInformationBlockStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefEndOfTermStatus"/> model
        /// </summary>
        Guid? RefEndOfTermStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefEnrollmentStatus"/> model
        /// </summary>
        Guid? RefEnrollmentStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefEntryGradeLevel"/> model
        /// </summary>
        Guid? RefEntryGradeLevelId { get; set; }

        Int32? RefEntryType { get; set; }

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
        /// Reference to an optional instance of the <see cref="RefFoodServiceEligibility"/> model
        /// </summary>
        Guid? RefFoodServiceEligibilityId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefNonPromotionReason"/> model
        /// </summary>
        Guid? RefNonPromotionReasonId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPromotionReason"/> model
        /// </summary>
        Guid? RefPromotionReasonId { get; set; }

        Int32? RefPublicSchoolResidence { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefStudentEnrollmentAccessType"/> model
        /// </summary>
        Guid? RefStudentEnrollmentAccessTypeId { get; set; }

    }
}
