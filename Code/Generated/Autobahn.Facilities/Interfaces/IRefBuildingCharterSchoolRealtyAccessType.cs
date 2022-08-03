//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   IRefBuildingCharterSchoolRealtyAccessType.cs
//**********************************************************

namespace Autobahn.Facilities.Interfaces
{
     /// <summary>
     /// The IRefBuildingCharterSchoolRealtyAccessType
     /// </summary>
    public partial interface IRefBuildingCharterSchoolRealtyAccessType
    {
        /// <summary>
        /// Defines the RefBuildingCharterSchoolRealtyAccessType.Description non nullable property
        /// </summary>
        System.String Description { get; set; }

        /// <summary>
        /// Defines the RefBuildingCharterSchoolRealtyAccessType.Code non nullable property
        /// </summary>
        System.String Code { get; set; }

        /// <summary>
        /// Defines the RefBuildingCharterSchoolRealtyAccessType.Definition non nullable property
        /// </summary>
        System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefBuildingCharterSchoolRealtyAccessType.SortOrder nullable property
        /// </summary>
        System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefBuildingCharterSchoolRealtyAccessType.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefBuildingCharterSchoolRealtyAccessType.RecordEndDateTime nullable property
        /// </summary>
        System.DateTime? RecordEndDateTime { get; set; }

    }
}
