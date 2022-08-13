//**********************************************************
//* DomainName: Early Learning (EL)
//* FileName:   ELStaffEmploymentModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.EarlyLearning.Models
{
     /// <summary>
     /// The ELStaffEmployment Model
     /// </summary>
    public partial class ELStaffEmploymentModel : AutobahnBase, Interfaces.IELStaffEmployment
    {
        /// <summary>
        /// The condition under which a person has agreed to serve as an employee.
        /// </summary>
        public System.Decimal? HourlyWage { get; set; }

        /// <summary>
        /// The condition under which a person has agreed to serve as an employee.
        /// </summary>
        public System.Decimal? HoursWorkedPerWeek { get; set; }

        /// <summary>
        /// The condition under which a person has agreed to serve as an employee.
        /// </summary>
        public Guid? RefELEducationStaffClassificationId { get; set; }

        /// <summary>
        /// The condition under which a person has agreed to serve as an employee.
        /// </summary>
        public Guid? RefELEmploymentSeparationReasonId { get; set; }

        /// <summary>
        /// The condition under which a person has agreed to serve as an employee.
        /// </summary>
        public Guid? RefELServiceProfessionalStaffClassificationId { get; set; }

        /// <summary>
        /// The condition under which a person has agreed to serve as an employee.
        /// </summary>
        public Guid? RefEmploymentStatusId { get; set; }

        /// <summary>
        /// The condition under which a person has agreed to serve as an employee.
        /// </summary>
        public Guid? RefWageCollectionMethodId { get; set; }

        /// <summary>
        /// The condition under which a person has agreed to serve as an employee.
        /// </summary>
        public Guid? RefWageVerificationId { get; set; }

        /// <summary>
        /// The condition under which a person has agreed to serve as an employee.
        /// </summary>
        public System.Boolean? StaffApprovalIndicator { get; set; }

        /// <summary>
        /// The condition under which a person has agreed to serve as an employee.
        /// </summary>
        public Guid StaffEmploymentId { get; set; }

        /// <summary>
        /// The condition under which a person has agreed to serve as an employee.
        /// </summary>
        public System.Boolean? UnionMembershipStatus { get; set; }

    }
}
