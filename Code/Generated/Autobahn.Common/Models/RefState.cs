//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefState.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The RefState
     /// </summary>
    public partial class RefState : IRefState
    {
        /// <summary>
        /// Defines the RefState.Description non nullable property
        /// </summary>
        public System.String Description { get; set; }

        /// <summary>
        /// Defines the RefState.Code non nullable property
        /// </summary>
        public System.String Code { get; set; }

        /// <summary>
        /// Defines the RefState.Definition non nullable property
        /// </summary>
        public System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        public Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefState.SortOrder nullable property
        /// </summary>
        public System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefState.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefState.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

    }
}
