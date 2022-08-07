//**********************************************************
//* DomainName: Autobahn.EarlyLearning
//* FileName:   ELStaffEmploymentModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.EarlyLearning.Models
{
     /// <summary>
     /// The ELStaffEmployment Model
     /// </summary>
    public partial class ELStaffEmploymentModel : AutobahnBase, Interfaces.IELStaffEmploymentModel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="StaffEmployment"/> model
        /// </summary>
        public Guid StaffEmploymentId { get; set; }

        /// <summary>
        /// Defines the ELStaffEmployment.HoursWorkedPerWeek nullable property
        /// </summary>
        public System.Decimal? HoursWorkedPerWeek { get; set; }

        /// <summary>
        /// Defines the ELStaffEmployment.HourlyWage nullable property
        /// </summary>
        public System.Decimal? HourlyWage { get; set; }

        /// <summary>
        /// Defines the ELStaffEmployment.UnionMembershipStatus nullable property
        /// </summary>
        public System.Boolean? UnionMembershipStatus { get; set; }

        /// <summary>
        /// Defines the ELStaffEmployment.StaffApprovalIndicator nullable property
        /// </summary>
        public System.Boolean? StaffApprovalIndicator { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefEmploymentStatus"/> model
        /// </summary>
        public Guid? RefEmploymentStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefWageCollectionMethod"/> model
        /// </summary>
        public Guid? RefWageCollectionMethodId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefWageVerification"/> model
        /// </summary>
        public Guid? RefWageVerificationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefELEducationStaffClassification"/> model
        /// </summary>
        public Guid? RefELEducationStaffClassificationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefELEmploymentSeparationReason"/> model
        /// </summary>
        public Guid? RefELEmploymentSeparationReasonId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefELServiceProfessionalStaffClassification"/> model
        /// </summary>
        public Guid? RefELServiceProfessionalStaffClassificationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
