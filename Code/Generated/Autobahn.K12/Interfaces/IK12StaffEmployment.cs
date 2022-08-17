//***************************************************************************
//* DomainName: Elementary and Secondary (K12) Interfaces (used by both models and View Models
//* FileName:   IK12StaffEmployment.cs
//* Name:       Contract Days of Service Per Year
//* Definition: 
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.K12.Interfaces
{
     /// <summary>
     /// 
     /// </summary>
    public partial interface IK12StaffEmployment : IAutobahnBase
    {
        /// <summary>
        /// Contract Days of Service Per Year
        /// <para>
        /// The number of days per year that a person is expected to work as outlined specifically in his or her employment agreement.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19047">Contract Days of Service Per Year</a>
        /// </para>
        /// </summary>
        System.Decimal? ContractDaysOfServicePerYear { get; set; }

        /// <summary>
        /// Migrant Education Program Personnel Indicator
        /// <para>
        /// An indication that a staff member's salary is paid by the Title I, Part C Migrant Education Program (MEP) of ESEA as amended.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19534">Migrant Education Program Personnel Indicator</a>
        /// </para>
        /// </summary>
        System.Boolean? MepPersonnelIndicator { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefEmploymentStatus"/> model
        /// </summary>
        Guid? RefEmploymentStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefK12StaffClassification"/> model
        /// </summary>
        Guid? RefK12StaffClassificationId { get; set; }

        /// <summary>
        /// Salary for Teaching Assignment Only Indicator
        /// <para>
        /// Indicator to determine whether the teacher's base salary includes pay for teaching assignments alone.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19234">Salary for Teaching Assignment Only Indicator</a>
        /// </para>
        /// </summary>
        System.Boolean? SalaryForTeachingAssignmentOnlyIndicator { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IStaffEmployment"/> model
        /// </summary>
        Guid StaffEmploymentId { get; set; }

        /// <summary>
        /// Title I Targeted Assistance Staff Funded
        /// <para>
        /// An indication that a staff member is targeted assistance (TAS) program staff funded by Title I, Part A, Section 1115 of ESEA as amended.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19543">Title I Targeted Assistance Staff Funded</a>
        /// </para>
        /// </summary>
        System.Boolean? TitleITargetedAssistanceStaffFunded { get; set; }

    }
}
