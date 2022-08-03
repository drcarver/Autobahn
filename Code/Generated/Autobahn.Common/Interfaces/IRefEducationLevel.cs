//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IRefEducationLevel.cs
//**********************************************************

namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IRefEducationLevel
     /// </summary>
    public partial interface IRefEducationLevel
    {
        /// <summary>
        /// Defines the RefEducationLevel.Description non nullable property
        /// </summary>
        System.String Description { get; set; }

        /// <summary>
        /// Defines the RefEducationLevel.Code non nullable property
        /// </summary>
        System.String Code { get; set; }

        /// <summary>
        /// Defines the RefEducationLevel.Definition non nullable property
        /// </summary>
        System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefEducationLevelType"/> model
        /// </summary>
        Guid? RefEducationLevelTypeId { get; set; }

        /// <summary>
        /// Defines the RefEducationLevel.SortOrder nullable property
        /// </summary>
        System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefEducationLevel.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefEducationLevel.RecordEndDateTime nullable property
        /// </summary>
        System.DateTime? RecordEndDateTime { get; set; }

    }
}
