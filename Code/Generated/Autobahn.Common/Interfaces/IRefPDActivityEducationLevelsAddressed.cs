//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IRefPDActivityEducationLevelsAddressed.cs
//**********************************************************

namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IRefPDActivityEducationLevelsAddressed
     /// </summary>
    public partial interface IRefPDActivityEducationLevelsAddressed
    {
        /// <summary>
        /// Defines the RefPDActivityEducationLevelsAddressed.Description non nullable property
        /// </summary>
        System.String Description { get; set; }

        /// <summary>
        /// Defines the RefPDActivityEducationLevelsAddressed.Code non nullable property
        /// </summary>
        System.String Code { get; set; }

        /// <summary>
        /// Defines the RefPDActivityEducationLevelsAddressed.Definition non nullable property
        /// </summary>
        System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefPDActivityEducationLevelsAddressed.SortOrder nullable property
        /// </summary>
        System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefPDActivityEducationLevelsAddressed.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefPDActivityEducationLevelsAddressed.RecordEndDateTime nullable property
        /// </summary>
        System.DateTime? RecordEndDateTime { get; set; }

    }
}
