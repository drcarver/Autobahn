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
        /// The date on which an individual's professional development career plan was last updated.
        /// </summary>
        System.DateTime? LastUpdated { get; set; }

        /// <summary>
        /// The date on which an individual's professional development career plan was last updated.
        /// </summary>
        Guid PersonId { get; set; }

        /// <summary>
        /// The date on which an individual's professional development career plan was last updated.
        /// </summary>
        System.Boolean? ProfessionalDevelopmentPlanApprovedBySupervisor { get; set; }

        /// <summary>
        /// The date on which an individual's professional development career plan was last updated.
        /// </summary>
        System.DateTime? ProfessionalDevelopmentPlanCompletion { get; set; }

        /// <summary>
        /// The date on which an individual's professional development career plan was last updated.
        /// </summary>
        Guid? RefCareerEducationPlanTypeId { get; set; }

        /// <summary>
        /// The date on which an individual's professional development career plan was last updated.
        /// </summary>
        System.Boolean? TuitionFunded { get; set; }

    }
}
