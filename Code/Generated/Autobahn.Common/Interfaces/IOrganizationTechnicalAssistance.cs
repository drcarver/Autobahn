//***************************************************************************
//* DomainName: Common Models Interfaces (used by both models and View Models
//* FileName:   IOrganizationTechnicalAssistance.cs
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IOrganizationTechnicalAssistance Interface
     /// </summary>
    public partial interface IOrganizationTechnicalAssistance : IAutobahnBase
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
