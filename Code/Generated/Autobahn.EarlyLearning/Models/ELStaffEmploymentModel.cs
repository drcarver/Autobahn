//**********************************************************
//* DomainName: Early Learning (EL)
//* FileName:   ELStaffEmploymentModel.cs
//***************************************************************************

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
        /// Hourly Wage
        /// <para>
        /// Hourly wage associated with the employment position being reported.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19796">Hourly Wage</a>
        /// </para>
        /// </summary>
        public System.Decimal? HourlyWage { get; set; }

        /// <summary>
        /// Hours Worked Per Week
        /// <para>
        /// The number of hours worked per week in employment.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19795">Hours Worked Per Week</a>
        /// </para>
        /// </summary>
        public System.Decimal? HoursWorkedPerWeek { get; set; }

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
        /// Staff Approval Indicator
        /// <para>
        /// Individual is approved to Work with Children
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20560">Staff Approval Indicator</a>
        /// </para>
        /// </summary>
        public System.Boolean? StaffApprovalIndicator { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IStaffEmployment"/> model
        /// </summary>
        public Guid StaffEmploymentId { get; set; }

        /// <summary>
        /// Union Membership Status
        /// <para>
        /// An indication of whether the person is a member of a union.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19798">Union Membership Status</a>
        /// </para>
        /// </summary>
        public System.Boolean? UnionMembershipStatus { get; set; }

    }
}
