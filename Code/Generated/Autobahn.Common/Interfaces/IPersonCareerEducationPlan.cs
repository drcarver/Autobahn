//***************************************************************************
//* DomainName: Common Models Interfaces (used by both models and View Models
//* FileName:   IPersonCareerEducationPlan.cs
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IPersonCareerEducationPlan Interface
     /// </summary>
    public partial interface IPersonCareerEducationPlan : IAutobahnBase
    {
        /// <summary>
        /// Career Education Plan Date
        /// <para>
        /// The date on which an individual's professional development career plan was last updated.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20255">Career Education Plan Date</a>
        /// </para>
        /// </summary>
        System.DateTime? LastUpdated { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IPerson"/> model
        /// </summary>
        Guid PersonId { get; set; }

        /// <summary>
        /// Professional Development Plan Approved by Supervisor
        /// <para>
        /// Professional development plan is approved by the employee's supervisor.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20599">Professional Development Plan Approved by Supervisor</a>
        /// </para>
        /// </summary>
        System.Boolean? ProfessionalDevelopmentPlanApprovedBySupervisor { get; set; }

        /// <summary>
        /// Professional Development Plan Completion
        /// <para>
        /// The date the professional development plan is completed.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20600">Professional Development Plan Completion</a>
        /// </para>
        /// </summary>
        System.DateTime? ProfessionalDevelopmentPlanCompletion { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefCareerEducationPlanType"/> model
        /// </summary>
        Guid? RefCareerEducationPlanTypeId { get; set; }

        /// <summary>
        /// Tuition Funded
        /// <para>
        /// Indicates that tuition for person's participation in a program, service, or course is funded or partially funded by an external grant program.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20554">Tuition Funded</a>
        /// </para>
        /// </summary>
        System.Boolean? TuitionFunded { get; set; }

    }
}
