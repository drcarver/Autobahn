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
        /// 
        /// </summary>
        Guid? LastUpdated { get; set; }

        /// <summary>
        /// 
        /// </summary>
         ProfessionalDevelopmentPlanApprovedBySupervisor { get; set; }

        /// <summary>
        /// 
        /// </summary>
         ProfessionalDevelopmentPlanCompletion { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RecordStartDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefCareerEducationPlanTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         TuitionFunded { get; set; }

    }
}
