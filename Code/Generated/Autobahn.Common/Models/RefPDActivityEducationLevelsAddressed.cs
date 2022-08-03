//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefPDActivityEducationLevelsAddressed.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The RefPDActivityEducationLevelsAddressed
     /// </summary>
    public partial class RefPDActivityEducationLevelsAddressed : IRefPDActivityEducationLevelsAddressed
    {
        /// <summary>
        /// Defines the RefPDActivityEducationLevelsAddressed.Description non nullable property
        /// </summary>
        public System.String Description { get; set; }

        /// <summary>
        /// Defines the RefPDActivityEducationLevelsAddressed.Code non nullable property
        /// </summary>
        public System.String Code { get; set; }

        /// <summary>
        /// Defines the RefPDActivityEducationLevelsAddressed.Definition non nullable property
        /// </summary>
        public System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        public Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefPDActivityEducationLevelsAddressed.SortOrder nullable property
        /// </summary>
        public System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefPDActivityEducationLevelsAddressed.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefPDActivityEducationLevelsAddressed.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

    }
}
