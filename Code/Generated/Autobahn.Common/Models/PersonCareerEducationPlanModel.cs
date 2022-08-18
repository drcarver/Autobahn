//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonCareerEducationPlanModel.cs
//***************************************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The PersonCareerEducationPlan Model
     /// </summary>
    public partial class PersonCareerEducationPlanModel : AutobahnBase, Interfaces.IPersonCareerEducationPlan
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
        public System.DateTime? LastUpdated { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IPerson"/> model
        /// </summary>
        public Guid PersonId { get; set; }

        /// <summary>
        /// Professional Development Plan Approved by Supervisor
        /// <para>
        /// Professional development plan is approved by the employee's supervisor.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20599">Professional Development Plan Approved by Supervisor</a>
        /// </para>
        /// </summary>
        public System.Boolean? ProfessionalDevelopmentPlanApprovedBySupervisor { get; set; }

        /// <summary>
        /// Professional Development Plan Completion
        /// <para>
        /// The date the professional development plan is completed.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20600">Professional Development Plan Completion</a>
        /// </para>
        /// </summary>
        public System.DateTime? ProfessionalDevelopmentPlanCompletion { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCareerEducationPlanType"/> model
        /// </summary>
        public Guid? RefCareerEducationPlanTypeId { get; set; }

        /// <summary>
        /// Tuition Funded
        /// <para>
        /// Indicates that tuition for person's participation in a program, service, or course is funded or partially funded by an external grant program.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20554">Tuition Funded</a>
        /// </para>
        /// </summary>
        public System.Boolean? TuitionFunded { get; set; }

    }
}
