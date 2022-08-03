//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   RefBuildingFullServiceKitchenType.cs
//**********************************************************

using Autobahn.Facilities.Interfaces;

namespace Autobahn.Facilities.Models
{
     /// <summary>
     /// The RefBuildingFullServiceKitchenType
     /// </summary>
    public partial class RefBuildingFullServiceKitchenType : IRefBuildingFullServiceKitchenType
    {
        /// <summary>
        /// Defines the RefBuildingFullServiceKitchenType.Description non nullable property
        /// </summary>
        public System.String Description { get; set; }

        /// <summary>
        /// Defines the RefBuildingFullServiceKitchenType.Code non nullable property
        /// </summary>
        public System.String Code { get; set; }

        /// <summary>
        /// Defines the RefBuildingFullServiceKitchenType.Definition non nullable property
        /// </summary>
        public System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        public Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefBuildingFullServiceKitchenType.SortOrder nullable property
        /// </summary>
        public System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefBuildingFullServiceKitchenType.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefBuildingFullServiceKitchenType.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

    }
}
