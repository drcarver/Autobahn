//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IRefPersonIdentificationSystem.cs
//**********************************************************

namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IRefPersonIdentificationSystem
     /// </summary>
    public partial interface IRefPersonIdentificationSystem
    {
        /// <summary>
        /// Defines the RefPersonIdentificationSystem.Description non nullable property
        /// </summary>
        System.String Description { get; set; }

        /// <summary>
        /// Defines the RefPersonIdentificationSystem.Code non nullable property
        /// </summary>
        System.String Code { get; set; }

        /// <summary>
        /// Defines the RefPersonIdentificationSystem.Definition non nullable property
        /// </summary>
        System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPersonentifierType"/> model
        /// </summary>
        Guid? RefPersonIdentifierTypeId { get; set; }

        /// <summary>
        /// Defines the RefPersonIdentificationSystem.SortOrder nullable property
        /// </summary>
        System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefPersonIdentificationSystem.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefPersonIdentificationSystem.RecordEndDateTime nullable property
        /// </summary>
        System.DateTime? RecordEndDateTime { get; set; }

    }
}
