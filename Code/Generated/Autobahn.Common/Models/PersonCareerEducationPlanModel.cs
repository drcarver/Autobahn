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
        /// 
        /// </summary>
        public Guid? LastUpdated { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  ProfessionalDevelopmentPlanApprovedBySupervisor { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  ProfessionalDevelopmentPlanCompletion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RecordStartDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefCareerEducationPlanTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  TuitionFunded { get; set; }

    }
}
