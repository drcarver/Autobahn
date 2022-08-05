//**********************************************************
//* DomainName: Autobahn.EarlyLearning
//* FileName:   IELStaffEmployment.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.EarlyLearning.Interfaces
{
     /// <summary>
     /// The IELStaffEmployment
     /// </summary>
    public partial interface IELStaffEmployment : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="StaffEmployment"/> model
        /// </summary>
        Guid StaffEmploymentId { get; set; }

        /// <summary>
        /// Defines the ELStaffEmployment.HoursWorkedPerWeek nullable property
        /// </summary>
        System.Decimal? HoursWorkedPerWeek { get; set; }

        /// <summary>
        /// Defines the ELStaffEmployment.HourlyWage nullable property
        /// </summary>
        System.Decimal? HourlyWage { get; set; }

        /// <summary>
        /// Defines the ELStaffEmployment.UnionMembershipStatus nullable property
        /// </summary>
        System.Boolean? UnionMembershipStatus { get; set; }

        /// <summary>
        /// Defines the ELStaffEmployment.StaffApprovalIndicator nullable property
        /// </summary>
        System.Boolean? StaffApprovalIndicator { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefEmploymentStatus"/> model
        /// </summary>
        Guid? RefEmploymentStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefWageCollectionMethod"/> model
        /// </summary>
        Guid? RefWageCollectionMethodId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefWageVerification"/> model
        /// </summary>
        Guid? RefWageVerificationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefELEducationStaffClassification"/> model
        /// </summary>
        Guid? RefELEducationStaffClassificationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefELEmploymentSeparationReason"/> model
        /// </summary>
        Guid? RefELEmploymentSeparationReasonId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefELServiceProfessionalStaffClassification"/> model
        /// </summary>
        Guid? RefELServiceProfessionalStaffClassificationId { get; set; }

    }
}
