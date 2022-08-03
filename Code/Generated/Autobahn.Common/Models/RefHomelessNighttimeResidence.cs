//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefHomelessNighttimeResidence.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The RefHomelessNighttimeResidence
     /// </summary>
    public partial class RefHomelessNighttimeResidence : IRefHomelessNighttimeResidence
    {
        /// <summary>
        /// Defines the RefHomelessNighttimeResidence.Description non nullable property
        /// </summary>
        public System.String Description { get; set; }

        /// <summary>
        /// Defines the RefHomelessNighttimeResidence.Code non nullable property
        /// </summary>
        public System.String Code { get; set; }

        /// <summary>
        /// Defines the RefHomelessNighttimeResidence.Definition non nullable property
        /// </summary>
        public System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        public Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefHomelessNighttimeResidence.SortOrder nullable property
        /// </summary>
        public System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefHomelessNighttimeResidence.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefHomelessNighttimeResidence.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

    }
}
