//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   ProfessionalDevelopmentSessionModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Invalid.Models
{
     /// <summary>
     /// The ProfessionalDevelopmentSession Model
     /// </summary>
    public partial class ProfessionalDevelopmentSessionModel : AutobahnBase, Interfaces.IProfessionalDevelopmentSession
    {
        /// <summary>
        /// 
        /// </summary>
        public  Capacity { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  EndDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  EndTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  EvaluationMethod { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  EvaluationScore { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  ExpirationDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  FundingSource { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  LocationName { get; set; }

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
        public  RefELTrainerCoreKnowledgeAreaId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid? RefLanguageId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefPDDeliveryMethodId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefPDInstructionalDeliveryModeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefPDSessionStatusId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  SessionIdentifier { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  SponsoringAgencyName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  StartDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  StartTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  TrainingAndTechnicalAssistanceLevel { get; set; }

    }
}
