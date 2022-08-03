//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   IRefCorrectiveActionType.cs
//**********************************************************

namespace Autobahn.K12.Interfaces
{
     /// <summary>
     /// The IRefCorrectiveActionType
     /// </summary>
    public partial interface IRefCorrectiveActionType
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefCorrectiveAction"/> model
        /// </summary>
        Guid RefCorrectiveActionId { get; set; }

        /// <summary>
        /// Defines the RefCorrectiveActionType.Description non nullable property
        /// </summary>
        System.String Description { get; set; }

        /// <summary>
        /// Defines the RefCorrectiveActionType.Code non nullable property
        /// </summary>
        System.String Code { get; set; }

        /// <summary>
        /// Defines the RefCorrectiveActionType.Definition non nullable property
        /// </summary>
        System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefCorrectiveActionType.SortOrder nullable property
        /// </summary>
        System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefCorrectiveActionType.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefCorrectiveActionType.RecordEndDateTime nullable property
        /// </summary>
        System.DateTime? RecordEndDateTime { get; set; }

    }
}
