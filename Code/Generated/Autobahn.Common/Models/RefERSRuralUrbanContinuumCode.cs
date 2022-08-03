//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefERSRuralUrbanContinuumCode.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The RefERSRuralUrbanContinuumCode
     /// </summary>
    public partial class RefERSRuralUrbanContinuumCode : IRefERSRuralUrbanContinuumCode
    {
        /// <summary>
        /// Defines the RefERSRuralUrbanContinuumCode.Description non nullable property
        /// </summary>
        public System.String Description { get; set; }

        /// <summary>
        /// Defines the RefERSRuralUrbanContinuumCode.Code non nullable property
        /// </summary>
        public System.String Code { get; set; }

        /// <summary>
        /// Defines the RefERSRuralUrbanContinuumCode.Definition non nullable property
        /// </summary>
        public System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        public Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefERSRuralUrbanContinuumCode.SortOrder nullable property
        /// </summary>
        public System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefERSRuralUrbanContinuumCode.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefERSRuralUrbanContinuumCode.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

    }
}
