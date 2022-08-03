//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   IRefFacilityHazardousMaterialsOrCondType.cs
//**********************************************************

namespace Autobahn.Facilities.Interfaces
{
     /// <summary>
     /// The IRefFacilityHazardousMaterialsOrCondType
     /// </summary>
    public partial interface IRefFacilityHazardousMaterialsOrCondType
    {
        /// <summary>
        /// Defines the RefFacilityHazardousMaterialsOrCondType.Description non nullable property
        /// </summary>
        System.String Description { get; set; }

        /// <summary>
        /// Defines the RefFacilityHazardousMaterialsOrCondType.Code non nullable property
        /// </summary>
        System.String Code { get; set; }

        /// <summary>
        /// Defines the RefFacilityHazardousMaterialsOrCondType.Definition non nullable property
        /// </summary>
        System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefFacilityHazardousMaterialsOrCondType.SortOrder nullable property
        /// </summary>
        System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefFacilityHazardousMaterialsOrCondType.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefFacilityHazardousMaterialsOrCondType.RecordEndDateTime nullable property
        /// </summary>
        System.DateTime? RecordEndDateTime { get; set; }

    }
}
