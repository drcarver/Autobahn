//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   IRefBuildingVerticalTransportationSystemType.cs
//**********************************************************

namespace Autobahn.Facilities.Interfaces
{
     /// <summary>
     /// The IRefBuildingVerticalTransportationSystemType
     /// </summary>
    public partial interface IRefBuildingVerticalTransportationSystemType
    {
        /// <summary>
        /// Defines the RefBuildingVerticalTransportationSystemType.Description non nullable property
        /// </summary>
        System.String Description { get; set; }

        /// <summary>
        /// Defines the RefBuildingVerticalTransportationSystemType.Code non nullable property
        /// </summary>
        System.String Code { get; set; }

        /// <summary>
        /// Defines the RefBuildingVerticalTransportationSystemType.Definition non nullable property
        /// </summary>
        System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefBuildingVerticalTransportationSystemType.SortOrder nullable property
        /// </summary>
        System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefBuildingVerticalTransportationSystemType.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefBuildingVerticalTransportationSystemType.RecordEndDateTime nullable property
        /// </summary>
        System.DateTime? RecordEndDateTime { get; set; }

    }
}
