//**********************************************************
//* DomainName: Autobahn.Reference
//* FileName:   RefIDEAInterimRemoval.cs
//**********************************************************

using Autobahn.Reference.Interfaces;

namespace Autobahn.Reference.Models
{
     /// <summary>
     /// The RefIDEAInterimRemoval
     /// </summary>
    public partial class RefIDEAInterimRemoval : IRefIDEAInterimRemoval
    {
        /// <summary>
        /// Defines the RefIDEAInterimRemoval.Description non nullable property
        /// </summary>
        public System.String Description { get; set; }

        /// <summary>
        /// Defines the RefIDEAInterimRemoval.Code non nullable property
        /// </summary>
        public System.String Code { get; set; }

        /// <summary>
        /// Defines the RefIDEAInterimRemoval.Definition non nullable property
        /// </summary>
        public System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        public Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefIDEAInterimRemoval.SortOrder nullable property
        /// </summary>
        public System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefIDEAInterimRemoval.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefIDEAInterimRemoval.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

    }
}
