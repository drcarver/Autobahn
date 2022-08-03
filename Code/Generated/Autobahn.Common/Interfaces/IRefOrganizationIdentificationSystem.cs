//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IRefOrganizationIdentificationSystem.cs
//**********************************************************

namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IRefOrganizationIdentificationSystem
     /// </summary>
    public partial interface IRefOrganizationIdentificationSystem
    {
        /// <summary>
        /// Defines the RefOrganizationIdentificationSystem.Description non nullable property
        /// </summary>
        System.String Description { get; set; }

        /// <summary>
        /// Defines the RefOrganizationIdentificationSystem.Code non nullable property
        /// </summary>
        System.String Code { get; set; }

        /// <summary>
        /// Defines the RefOrganizationIdentificationSystem.Definition non nullable property
        /// </summary>
        System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefOrganizationentifierType"/> model
        /// </summary>
        Guid? RefOrganizationIdentifierTypeId { get; set; }

        /// <summary>
        /// Defines the RefOrganizationIdentificationSystem.SortOrder nullable property
        /// </summary>
        System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefOrganizationIdentificationSystem.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefOrganizationIdentificationSystem.RecordEndDateTime nullable property
        /// </summary>
        System.DateTime? RecordEndDateTime { get; set; }

    }
}
