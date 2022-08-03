//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefPersonIdentificationSystem.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The RefPersonIdentificationSystem
     /// </summary>
    public partial class RefPersonIdentificationSystem : IRefPersonIdentificationSystem
    {
        /// <summary>
        /// Defines the RefPersonIdentificationSystem.Description non nullable property
        /// </summary>
        public System.String Description { get; set; }

        /// <summary>
        /// Defines the RefPersonIdentificationSystem.Code non nullable property
        /// </summary>
        public System.String Code { get; set; }

        /// <summary>
        /// Defines the RefPersonIdentificationSystem.Definition non nullable property
        /// </summary>
        public System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        public Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPersonentifierType"/> model
        /// </summary>
        public Guid? RefPersonIdentifierTypeId { get; set; }

        /// <summary>
        /// Defines the RefPersonIdentificationSystem.SortOrder nullable property
        /// </summary>
        public System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefPersonIdentificationSystem.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefPersonIdentificationSystem.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

    }
}
