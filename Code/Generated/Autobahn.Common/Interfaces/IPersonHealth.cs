//***************************************************************************
//* DomainName: Common Models Interfaces (used by both models and View Models
//* FileName:   IPersonHealth.cs
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IPersonHealth Interface
     /// </summary>
    public partial interface IPersonHealth : IAutobahnBase
    {
        /// <summary>
        /// 
        /// </summary>
         DentalScreeningDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
         HealthScreeningEquipmentUsed { get; set; }

        /// <summary>
        /// 
        /// </summary>
         HealthScreeningFollowUpRecommendation { get; set; }

        /// <summary>
        /// 
        /// </summary>
         HearingScreeningDate { get; set; }

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
         RefDentalInsuranceCoverageTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefDentalScreeningStatusId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefHealthInsuranceCoverageId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefHearingScreeningStatusId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefMedicalAlertIndicatorId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        Guid? RefVisionScreeningStatusId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         VisionScreeningDate { get; set; }

    }
}
