//***************************************************************************
//* DomainName: Common Models Interfaces (used by both models and View Models
//* FileName:   IStaffTechnicalAssistance.cs
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IStaffTechnicalAssistance Interface
     /// </summary>
    public partial interface IStaffTechnicalAssistance : IAutobahnBase
    {
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
         RefTechnicalAssistanceDeliveryTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefTechnicalAssistanceTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        Guid? TechnicalAssistanceApprovedInd { get; set; }

    }
}
