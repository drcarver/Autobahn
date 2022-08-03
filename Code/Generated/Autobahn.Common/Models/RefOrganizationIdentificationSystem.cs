//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefOrganizationIdentificationSystem.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The RefOrganizationIdentificationSystem
     /// </summary>
    public partial class RefOrganizationIdentificationSystem : IRefOrganizationIdentificationSystem
    {
        /// <summary>
        /// Defines the RefOrganizationIdentificationSystem.Description non nullable property
        /// </summary>
        public System.String Description { get; set; }

        /// <summary>
        /// Defines the RefOrganizationIdentificationSystem.Code non nullable property
        /// </summary>
        public System.String Code { get; set; }

        /// <summary>
        /// Defines the RefOrganizationIdentificationSystem.Definition non nullable property
        /// </summary>
        public System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        public Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefOrganizationentifierType"/> model
        /// </summary>
        public Guid? RefOrganizationIdentifierTypeId { get; set; }

        /// <summary>
        /// Defines the RefOrganizationIdentificationSystem.SortOrder nullable property
        /// </summary>
        public System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefOrganizationIdentificationSystem.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefOrganizationIdentificationSystem.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

    }
}
