//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   RefBuildingCharterSchoolRealtyAccessType.cs
//**********************************************************

using Autobahn.Facilities.Interfaces;

namespace Autobahn.Facilities.Models
{
     /// <summary>
     /// The RefBuildingCharterSchoolRealtyAccessType
     /// </summary>
    public partial class RefBuildingCharterSchoolRealtyAccessType : IRefBuildingCharterSchoolRealtyAccessType
    {
        /// <summary>
        /// Defines the RefBuildingCharterSchoolRealtyAccessType.Description non nullable property
        /// </summary>
        public System.String Description { get; set; }

        /// <summary>
        /// Defines the RefBuildingCharterSchoolRealtyAccessType.Code non nullable property
        /// </summary>
        public System.String Code { get; set; }

        /// <summary>
        /// Defines the RefBuildingCharterSchoolRealtyAccessType.Definition non nullable property
        /// </summary>
        public System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        public Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefBuildingCharterSchoolRealtyAccessType.SortOrder nullable property
        /// </summary>
        public System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefBuildingCharterSchoolRealtyAccessType.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefBuildingCharterSchoolRealtyAccessType.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

    }
}
