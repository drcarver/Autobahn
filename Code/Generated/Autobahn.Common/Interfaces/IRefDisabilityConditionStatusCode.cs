//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IRefDisabilityConditionStatusCode.cs
//**********************************************************

namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IRefDisabilityConditionStatusCode
     /// </summary>
    public partial interface IRefDisabilityConditionStatusCode
    {
        /// <summary>
        /// Defines the RefDisabilityConditionStatusCode.Description non nullable property
        /// </summary>
        System.String Description { get; set; }

        /// <summary>
        /// Defines the RefDisabilityConditionStatusCode.Code non nullable property
        /// </summary>
        System.String Code { get; set; }

        /// <summary>
        /// Defines the RefDisabilityConditionStatusCode.Definition non nullable property
        /// </summary>
        System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefDisabilityConditionStatusCode.SortOrder nullable property
        /// </summary>
        System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefDisabilityConditionStatusCode.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefDisabilityConditionStatusCode.RecordEndDateTime nullable property
        /// </summary>
        System.DateTime? RecordEndDateTime { get; set; }

    }
}
