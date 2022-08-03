//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefApipInteractionType.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The RefApipInteractionType
     /// </summary>
    public partial class RefApipInteractionType : IRefApipInteractionType
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefAPIPInteractionType"/> model
        /// </summary>
        public Guid RefAPIPInteractionTypeId { get; set; }

        /// <summary>
        /// Defines the RefApipInteractionType.Description non nullable property
        /// </summary>
        public System.String Description { get; set; }

        /// <summary>
        /// Defines the RefApipInteractionType.Code non nullable property
        /// </summary>
        public System.String Code { get; set; }

        /// <summary>
        /// Defines the RefApipInteractionType.Definition non nullable property
        /// </summary>
        public System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        public Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefApipInteractionType.SortOrder nullable property
        /// </summary>
        public System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefApipInteractionType.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefApipInteractionType.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

    }
}
