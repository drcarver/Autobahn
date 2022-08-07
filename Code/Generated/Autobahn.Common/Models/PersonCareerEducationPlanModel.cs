//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   PersonCareerEducationPlanModel.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The PersonCareerEducationPlan Model
     /// </summary>
    public partial class PersonCareerEducationPlanModel : AutobahnBase, Interfaces.IPersonCareerEducationPlanModel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Person"/> model
        /// </summary>
        public Guid PersonId { get; set; }

        /// <summary>
        /// Defines the PersonCareerEducationPlan.LastUpdated nullable property
        /// </summary>
        public System.DateTime? LastUpdated { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCareerEducationPlanType"/> model
        /// </summary>
        public Guid? RefCareerEducationPlanTypeId { get; set; }

        /// <summary>
        /// Defines the PersonCareerEducationPlan.ProfessionalDevelopmentPlanApprovedBySupervisor nullable property
        /// </summary>
        public System.Boolean? ProfessionalDevelopmentPlanApprovedBySupervisor { get; set; }

        /// <summary>
        /// Defines the PersonCareerEducationPlan.ProfessionalDevelopmentPlanCompletion nullable property
        /// </summary>
        public System.DateTime? ProfessionalDevelopmentPlanCompletion { get; set; }

        /// <summary>
        /// Defines the PersonCareerEducationPlan.TuitionFunded nullable property
        /// </summary>
        public System.Boolean? TuitionFunded { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
