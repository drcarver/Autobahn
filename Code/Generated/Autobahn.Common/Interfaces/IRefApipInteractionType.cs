//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IRefApipInteractionType.cs
//**********************************************************

namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IRefApipInteractionType
     /// </summary>
    public partial interface IRefApipInteractionType
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefAPIPInteractionType"/> model
        /// </summary>
        Guid RefAPIPInteractionTypeId { get; set; }

        /// <summary>
        /// Defines the RefApipInteractionType.Description non nullable property
        /// </summary>
        System.String Description { get; set; }

        /// <summary>
        /// Defines the RefApipInteractionType.Code non nullable property
        /// </summary>
        System.String Code { get; set; }

        /// <summary>
        /// Defines the RefApipInteractionType.Definition non nullable property
        /// </summary>
        System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefApipInteractionType.SortOrder nullable property
        /// </summary>
        System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefApipInteractionType.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefApipInteractionType.RecordEndDateTime nullable property
        /// </summary>
        System.DateTime? RecordEndDateTime { get; set; }

    }
}
