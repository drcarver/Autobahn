//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IPersonCareerEducationPlan.cs
//**********************************************************

namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IPersonCareerEducationPlan
     /// </summary>
    public partial interface IPersonCareerEducationPlan
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Person"/> model
        /// </summary>
        Guid PersonId { get; set; }

        /// <summary>
        /// Defines the PersonCareerEducationPlan.LastUpdated nullable property
        /// </summary>
        System.DateTime? LastUpdated { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCareerEducationPlanType"/> model
        /// </summary>
        Guid? RefCareerEducationPlanTypeId { get; set; }

        /// <summary>
        /// Defines the PersonCareerEducationPlan.ProfessionalDevelopmentPlanApprovedBySupervisor nullable property
        /// </summary>
        System.Boolean? ProfessionalDevelopmentPlanApprovedBySupervisor { get; set; }

        /// <summary>
        /// Defines the PersonCareerEducationPlan.ProfessionalDevelopmentPlanCompletion nullable property
        /// </summary>
        System.DateTime? ProfessionalDevelopmentPlanCompletion { get; set; }

        /// <summary>
        /// Defines the PersonCareerEducationPlan.TuitionFunded nullable property
        /// </summary>
        System.Boolean? TuitionFunded { get; set; }

        /// <summary>
        /// Defines the PersonCareerEducationPlan.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the PersonCareerEducationPlan.RecordEndDateTime nullable property
        /// </summary>
        System.DateTime? RecordEndDateTime { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatus"/> model
        /// </summary>
        Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        Guid? DataCollectionId { get; set; }

    }
}
