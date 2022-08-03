//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   RefCorrectiveActionType.cs
//**********************************************************

using Autobahn.K12.Interfaces;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The RefCorrectiveActionType
     /// </summary>
    public partial class RefCorrectiveActionType : IRefCorrectiveActionType
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefCorrectiveAction"/> model
        /// </summary>
        public Guid RefCorrectiveActionId { get; set; }

        /// <summary>
        /// Defines the RefCorrectiveActionType.Description non nullable property
        /// </summary>
        public System.String Description { get; set; }

        /// <summary>
        /// Defines the RefCorrectiveActionType.Code non nullable property
        /// </summary>
        public System.String Code { get; set; }

        /// <summary>
        /// Defines the RefCorrectiveActionType.Definition non nullable property
        /// </summary>
        public System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        public Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefCorrectiveActionType.SortOrder nullable property
        /// </summary>
        public System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefCorrectiveActionType.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefCorrectiveActionType.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

    }
}
