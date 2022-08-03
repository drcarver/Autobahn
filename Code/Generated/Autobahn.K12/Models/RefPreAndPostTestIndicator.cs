//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   RefPreAndPostTestIndicator.cs
//**********************************************************

using Autobahn.K12.Interfaces;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The RefPreAndPostTestIndicator
     /// </summary>
    public partial class RefPreAndPostTestIndicator : IRefPreAndPostTestIndicator
    {
        /// <summary>
        /// Defines the RefPreAndPostTestIndicator.Description non nullable property
        /// </summary>
        public System.String Description { get; set; }

        /// <summary>
        /// Defines the RefPreAndPostTestIndicator.Code non nullable property
        /// </summary>
        public System.String Code { get; set; }

        /// <summary>
        /// Defines the RefPreAndPostTestIndicator.Definition non nullable property
        /// </summary>
        public System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        public Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefPreAndPostTestIndicator.SortOrder nullable property
        /// </summary>
        public System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefPreAndPostTestIndicator.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefPreAndPostTestIndicator.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

    }
}
