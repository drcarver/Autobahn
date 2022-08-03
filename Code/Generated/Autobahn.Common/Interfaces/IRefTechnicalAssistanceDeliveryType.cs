//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IRefTechnicalAssistanceDeliveryType.cs
//**********************************************************

namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IRefTechnicalAssistanceDeliveryType
     /// </summary>
    public partial interface IRefTechnicalAssistanceDeliveryType
    {
        /// <summary>
        /// Defines the RefTechnicalAssistanceDeliveryType.Description non nullable property
        /// </summary>
        System.String Description { get; set; }

        /// <summary>
        /// Defines the RefTechnicalAssistanceDeliveryType.Code non nullable property
        /// </summary>
        System.String Code { get; set; }

        /// <summary>
        /// Defines the RefTechnicalAssistanceDeliveryType.Definition non nullable property
        /// </summary>
        System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefTechnicalAssistanceDeliveryType.SortOrder nullable property
        /// </summary>
        System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefTechnicalAssistanceDeliveryType.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefTechnicalAssistanceDeliveryType.RecordEndDateTime nullable property
        /// </summary>
        System.DateTime? RecordEndDateTime { get; set; }

    }
}
