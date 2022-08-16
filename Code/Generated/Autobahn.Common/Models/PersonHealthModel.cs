//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonHealthModel.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The PersonHealth Model
     /// </summary>
    public partial class PersonHealthModel : AutobahnBase, Interfaces.IPersonHealth
    {
        /// <summary>
        /// 
        /// </summary>
        public  DentalScreeningDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  HealthScreeningEquipmentUsed { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  HealthScreeningFollowUpRecommendation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  HearingScreeningDate { get; set; }

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
        public  RefDentalInsuranceCoverageTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefDentalScreeningStatusId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefHealthInsuranceCoverageId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefHearingScreeningStatusId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefMedicalAlertIndicatorId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid? RefVisionScreeningStatusId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  VisionScreeningDate { get; set; }

    }
}
