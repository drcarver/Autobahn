//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   K12StudentEnrollment.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The K12StudentEnrollment
     /// </summary>
    public partial class K12StudentEnrollment : AutobahnBase, Interfaces.IK12StudentEnrollment
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Defines the K12StudentEnrollment.DisplacedStudentStatus nullable property
        /// </summary>
        public System.Boolean? DisplacedStudentStatus { get; set; }

        /// <summary>
        /// Defines the K12StudentEnrollment.FirstEntryDateIntoUSSchool nullable property
        /// </summary>
        public System.DateTime? FirstEntryDateIntoUSSchool { get; set; }

        /// <summary>
        /// Defines the K12StudentEnrollment.NSLPDirectCertificationIndicator nullable property
        /// </summary>
        public System.Boolean? NSLPDirectCertificationIndicator { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefEntryGradeLevel"/> model
        /// </summary>
        public Guid? RefEntryGradeLevelId { get; set; }

        /// <summary>
        /// Defines the K12StudentEnrollment.RefPublicSchoolResidence nullable property
        /// </summary>
        public System.Int32? RefPublicSchoolResidence { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefEnrollmentStatus"/> model
        /// </summary>
        public Guid? RefEnrollmentStatusId { get; set; }

        /// <summary>
        /// Defines the K12StudentEnrollment.RefEntryType nullable property
        /// </summary>
        public System.Int32? RefEntryType { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefExitGradeLevel"/> model
        /// </summary>
        public Guid? RefExitGradeLevelId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefExitOrWithdrawalStatus"/> model
        /// </summary>
        public Guid? RefExitOrWithdrawalStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefExitOrWithdrawalType"/> model
        /// </summary>
        public Guid? RefExitOrWithdrawalTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefEndOfTermStatus"/> model
        /// </summary>
        public Guid? RefEndOfTermStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPromotionReason"/> model
        /// </summary>
        public Guid? RefPromotionReasonId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefNonPromotionReason"/> model
        /// </summary>
        public Guid? RefNonPromotionReasonId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFoodServiceEligibility"/> model
        /// </summary>
        public Guid? RefFoodServiceEligibilityId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefDirectoryInformationBlockStatus"/> model
        /// </summary>
        public Guid? RefDirectoryInformationBlockStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefStudentEnrollmentAccessType"/> model
        /// </summary>
        public Guid? RefStudentEnrollmentAccessTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
