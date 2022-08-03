//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   PersonCareerEducationPlan.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The PersonCareerEducationPlan
     /// </summary>
    public partial class PersonCareerEducationPlan : IPersonCareerEducationPlan
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
        /// Defines the PersonCareerEducationPlan.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the PersonCareerEducationPlan.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatus"/> model
        /// </summary>
        public Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
