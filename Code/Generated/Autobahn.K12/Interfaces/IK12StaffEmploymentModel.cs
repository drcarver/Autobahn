//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   IK12StaffEmploymentModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.K12.Interfaces
{
     /// <summary>
     /// The IK12StaffEmploymentModel Interface
     /// </summary>
    public partial interface IK12StaffEmploymentModel : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="StaffEmployment"/> model
        /// </summary>
        Guid StaffEmploymentId { get; set; }

        /// <summary>
        /// Defines the K12StaffEmployment.ContractDaysOfServicePerYear nullable property
        /// </summary>
        System.Decimal? ContractDaysOfServicePerYear { get; set; }

        /// <summary>
        /// Defines the K12StaffEmployment.MepPersonnelIndicator nullable property
        /// </summary>
        System.Boolean? MepPersonnelIndicator { get; set; }

        /// <summary>
        /// Defines the K12StaffEmployment.TitleITargetedAssistanceStaffFunded nullable property
        /// </summary>
        System.Boolean? TitleITargetedAssistanceStaffFunded { get; set; }

        /// <summary>
        /// Defines the K12StaffEmployment.SalaryForTeachingAssignmentOnlyIndicator nullable property
        /// </summary>
        System.Boolean? SalaryForTeachingAssignmentOnlyIndicator { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefK12StaffClassification"/> model
        /// </summary>
        Guid? RefK12StaffClassificationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefEmploymentStatus"/> model
        /// </summary>
        Guid? RefEmploymentStatusId { get; set; }

    }
}
