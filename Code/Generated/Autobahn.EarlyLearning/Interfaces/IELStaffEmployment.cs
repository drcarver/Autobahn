//***************************************************************************
//* DomainName: Early Learning (EL) Interfaces (used by both models and View Models
//* FileName:   IELStaffEmployment.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.EarlyLearning.Interfaces
{
     /// <summary>
     /// The IELStaffEmployment Interface
     /// </summary>
    public partial interface IELStaffEmployment : IAutobahnBase
    {
        /// <summary>
        /// The condition under which a person has agreed to serve as an employee.
        /// </summary>
        System.Decimal? HourlyWage { get; set; }

        /// <summary>
        /// The condition under which a person has agreed to serve as an employee.
        /// </summary>
        System.Decimal? HoursWorkedPerWeek { get; set; }

        /// <summary>
        /// The condition under which a person has agreed to serve as an employee.
        /// </summary>
        Guid? RefELEducationStaffClassificationId { get; set; }

        /// <summary>
        /// The condition under which a person has agreed to serve as an employee.
        /// </summary>
        Guid? RefELEmploymentSeparationReasonId { get; set; }

        /// <summary>
        /// The condition under which a person has agreed to serve as an employee.
        /// </summary>
        Guid? RefELServiceProfessionalStaffClassificationId { get; set; }

        /// <summary>
        /// The condition under which a person has agreed to serve as an employee.
        /// </summary>
        Guid? RefEmploymentStatusId { get; set; }

        /// <summary>
        /// The condition under which a person has agreed to serve as an employee.
        /// </summary>
        Guid? RefWageCollectionMethodId { get; set; }

        /// <summary>
        /// The condition under which a person has agreed to serve as an employee.
        /// </summary>
        Guid? RefWageVerificationId { get; set; }

        /// <summary>
        /// The condition under which a person has agreed to serve as an employee.
        /// </summary>
        System.Boolean? StaffApprovalIndicator { get; set; }

        /// <summary>
        /// The condition under which a person has agreed to serve as an employee.
        /// </summary>
        Guid StaffEmploymentId { get; set; }

        /// <summary>
        /// The condition under which a person has agreed to serve as an employee.
        /// </summary>
        System.Boolean? UnionMembershipStatus { get; set; }

    }
}
