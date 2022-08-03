//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefElementaryMiddleAdditional.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The RefElementaryMiddleAdditional
     /// </summary>
    public partial class RefElementaryMiddleAdditional : IRefElementaryMiddleAdditional
    {
        /// <summary>
        /// Defines the RefElementaryMiddleAdditional.Description non nullable property
        /// </summary>
        public System.String Description { get; set; }

        /// <summary>
        /// Defines the RefElementaryMiddleAdditional.Code non nullable property
        /// </summary>
        public System.String Code { get; set; }

        /// <summary>
        /// Defines the RefElementaryMiddleAdditional.Definition non nullable property
        /// </summary>
        public System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        public Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefElementaryMiddleAdditional.SortOrder nullable property
        /// </summary>
        public System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefElementaryMiddleAdditional.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefElementaryMiddleAdditional.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

    }
}
