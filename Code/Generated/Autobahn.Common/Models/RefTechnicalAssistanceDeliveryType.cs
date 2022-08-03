//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefTechnicalAssistanceDeliveryType.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The RefTechnicalAssistanceDeliveryType
     /// </summary>
    public partial class RefTechnicalAssistanceDeliveryType : IRefTechnicalAssistanceDeliveryType
    {
        /// <summary>
        /// Defines the RefTechnicalAssistanceDeliveryType.Description non nullable property
        /// </summary>
        public System.String Description { get; set; }

        /// <summary>
        /// Defines the RefTechnicalAssistanceDeliveryType.Code non nullable property
        /// </summary>
        public System.String Code { get; set; }

        /// <summary>
        /// Defines the RefTechnicalAssistanceDeliveryType.Definition non nullable property
        /// </summary>
        public System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        public Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefTechnicalAssistanceDeliveryType.SortOrder nullable property
        /// </summary>
        public System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefTechnicalAssistanceDeliveryType.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefTechnicalAssistanceDeliveryType.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

    }
}
