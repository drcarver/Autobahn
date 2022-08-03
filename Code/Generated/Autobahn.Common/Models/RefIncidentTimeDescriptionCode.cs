//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefIncidentTimeDescriptionCode.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The RefIncidentTimeDescriptionCode
     /// </summary>
    public partial class RefIncidentTimeDescriptionCode : IRefIncidentTimeDescriptionCode
    {
        /// <summary>
        /// Defines the RefIncidentTimeDescriptionCode.Description non nullable property
        /// </summary>
        public System.String Description { get; set; }

        /// <summary>
        /// Defines the RefIncidentTimeDescriptionCode.Code non nullable property
        /// </summary>
        public System.String Code { get; set; }

        /// <summary>
        /// Defines the RefIncidentTimeDescriptionCode.Definition non nullable property
        /// </summary>
        public System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        public Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefIncidentTimeDescriptionCode.SortOrder nullable property
        /// </summary>
        public System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefIncidentTimeDescriptionCode.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefIncidentTimeDescriptionCode.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

    }
}
