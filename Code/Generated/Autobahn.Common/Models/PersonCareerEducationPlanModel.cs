//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonCareerEducationPlanModel.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The PersonCareerEducationPlan Model
     /// </summary>
    public partial class PersonCareerEducationPlanModel : AutobahnBase, Interfaces.IPersonCareerEducationPlan
    {
        /// <summary>
        /// The date on which an individual's professional development career plan was last updated.
        /// </summary>
        public System.DateTime? LastUpdated { get; set; }

        /// <summary>
        /// The date on which an individual's professional development career plan was last updated.
        /// </summary>
        public Guid PersonId { get; set; }

        /// <summary>
        /// The date on which an individual's professional development career plan was last updated.
        /// </summary>
        public System.Boolean? ProfessionalDevelopmentPlanApprovedBySupervisor { get; set; }

        /// <summary>
        /// The date on which an individual's professional development career plan was last updated.
        /// </summary>
        public System.DateTime? ProfessionalDevelopmentPlanCompletion { get; set; }

        /// <summary>
        /// The date on which an individual's professional development career plan was last updated.
        /// </summary>
        public Guid? RefCareerEducationPlanTypeId { get; set; }

        /// <summary>
        /// The date on which an individual's professional development career plan was last updated.
        /// </summary>
        public System.Boolean? TuitionFunded { get; set; }

    }
}
